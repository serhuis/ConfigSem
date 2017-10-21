using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Ports;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Q_Config
{
    public partial class Form1 : Form
    {
        readonly string version = "0.01";

        readonly byte Q_COMMAND				= 1;
        readonly byte Q_GET_MEM				= 2;
        readonly byte Q_SET_MEM_WORD		= 3;
        readonly byte Q_SET_MEM_ALL			= 4;
        readonly byte Q_GET_PARAM			= 5;
		readonly byte Q_GET_GRAPH			= 6;
		readonly byte Q_SEND_GRAPH1			= 7;
		readonly byte Q_SEND_GRAPH2			= 8;


        readonly byte COMMAND_RESET		    = 1;
        readonly byte COMMAND_DIAGN			= 2;
        readonly byte COMMAND_PROGRAM_ON	= 3;
        readonly byte COMMAND_PROGRAM_OFF	= 4;
		readonly byte COMMAND_GET_DELTA		= 5;
        readonly byte COMMAND_DELTA_SEND_OFF = 6;
        readonly byte COMMAND_CALIBR_10		= 7;
        readonly byte COMMAND_FLASH_LED     = 8;
		readonly byte COMMAND_CLEAR_FAULTS	= 9;
		readonly byte COMMAND_CALIBR_00		= 10;
		readonly byte COMMAND_GET_RSSI		= 11;

		readonly byte Q_DEVINIT_PHASE1		= 21;
		readonly byte Q_DEVINIT_PHASE2		= 22;
		readonly byte Q_DEVINIT_PHASE3		= 23;
		readonly byte Q_DEVINIT_PHASE4		= 24;
		readonly byte Q_DEVINIT_PHASE5		= 25;

		readonly byte Q_GRAPH				= 30;

		int curSN = 1;
		String DateProd = "";
		int NormLevel = 0;
		int PreFireLevel = 0;
		int FireLevel = 0;
		int TimerCalibr = 0;
		int DarkLevel = 0;
		String VBAT_LoadString = "";
		String HiVoltageString = "";
		String dHV_IR_VoltageString = "";
		UInt16 FaultsWord = 0;

		//
		UInt16 norm;

		string confFileName = "q-config.sys";
		string confLogName = "q-conf_stat.csv";
		string confLogWriteName = "q-conf_write.csv";  
		System.IO.StreamWriter fileLog;
		System.IO.StreamWriter fileWrite;
        // Delete the file if it exists.
        
        public Form1() {

            InitializeComponent();
            dataGridProp.RowCount = 4;
            dataGridProp.CurrentCell = null;
            dataGridProp[0, 0].Value = "1";     dataGridProp[1, 0].Value = "Уровень фона (0dB/m), инкр.";
            dataGridProp[0, 1].Value = "2";     dataGridProp[1, 1].Value = "Порог Пожара (0,10dB/m), инкр.";

            //
            String[] portNames = SerialPort.GetPortNames();
            int count = portNames.Length;
            int i;
            for (i = 0; i < count; i++)
            {
                portsComboBox.Items.Add(portNames[i]);
            }
            //
            serial1 = new SerialPort();
            portsComboBox.SelectedIndex = i - 1;    // Выбираем COM - вызывает обработчик
			//
			numUpDownSN.Value = 1;		// Default
			//
			// Открываем файл конфигурации
			//
			if (File.Exists(confFileName)) {
				StreamReader sr = System.IO.File.OpenText(confFileName);
				string s = "";
				string ss = "1";
				while ((s = sr.ReadLine()) != null) {
					if (s.Substring(0, 3).Equals("sn=")) {
						ss = s.Substring(3, s.Length - 3);
						//curSN = Convert.ToUInt16(ss);
						numUpDownSN.Value = Convert.ToUInt16(ss);
						//numUpDownSN.Value = curSN;
						break;
					}
				}
				sr.Close();
			}
			//
			// Открываем log статистики
			fileLog = new StreamWriter(confLogName, true);
			// Открываем log записи в сигнализаторы
			fileWrite = new StreamWriter(confLogWriteName, true);

        }

		private void Form1_FormClosing ( object sender, FormClosingEventArgs e ) {
			//if (File.Exists(confFileName)) {
			StreamWriter sw = new StreamWriter(confFileName);
			sw.WriteLine("ver=1.00");
			sw.WriteLine("sn=" + numUpDownSN.Value.ToString());
			sw.Close();
			//
			if (fileLog != null) {
				fileLog.Close();
			}
			if (fileWrite != null) {
				fileWrite.Close();
			}
		}

        private void portsComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			if (!serial1.IsOpen) {
				serial1.PortName = (String)portsComboBox.SelectedItem;	//"COM8";
				serial1.BaudRate = 9600;
				serial1.Handshake = Handshake.None;
				serial1.StopBits = StopBits.Two;
				serial1.Parity = Parity.None;
				serial1.ReadTimeout = 2000;
			}
        }
		//*************************************************************************

        Byte[] RxBuf = new byte[128];
        Byte lastQualifier;
        Byte lastCommand;
        //int len_sent = 0;
        int len_rx = 0;
		bool fLogEnabled;
		bool fLogWaitReceive;
		bool fRSSIEnabled;
		bool fRSSIWaitReceive;
		string log_item;
		string rssi_item;

		Byte[] BackupMem = new byte[64];
		Byte[] TxMem = new byte[64];

		//*************************************************************************

		private void serial1_DataReceived ( object sender, SerialDataReceivedEventArgs e ) {
			if (fLogEnabled) {
				serial1.Read(RxBuf, 0, 4);
				// Norm Level
				int dark = RxBuf[0] + RxBuf[1] * 256;
				int delta = RxBuf[2] + RxBuf[3] * 256;

				log_item = delta.ToString() + "\r\n";
				//
			}
			if (fRSSIEnabled) {
				serial1.Read(RxBuf, 0, 2);
				// Norm Level
				int rssi = RxBuf[0];
				int LQI = RxBuf[1];

				log_item = rssi.ToString() + "  " + LQI.ToString() + "\r\n";
				//
			}
		}


		private void serial1_ErrorReceived ( object sender, SerialErrorReceivedEventArgs e ) {
			//serial1.Close();
		}


		int[] tmp = new int[3];

        private void buttonRead_Click(object sender, EventArgs e) {
            len_rx = 64;
            lastQualifier = Q_GET_MEM;
            Byte[] TxBuf = { lastQualifier, 0, (byte)len_rx };
            
			try {
				serial1.Open();
            
				serial1.Write(TxBuf, 0, 3);
				// Получаем только что отосланное
			
				tmp[0] = serial1.ReadByte();
				tmp[1] = serial1.ReadByte();
				tmp[2] = serial1.ReadByte();
				//
				timer1.Interval = 600;
				timer1.Enabled = true;
				buttonRead.Enabled = false;
			} catch (Exception ex) {
				serial1.Close();
			}
        }


		private String getDevName ( int dev_type ) {
			switch (dev_type) {
				case 1: return "ASD-10Q";
				case 2: return "FMR4320Q";
				case 3: return "ASD-10QR";
                case 4: return "Артон-ДЛ1";
                case 5: return "Артон-ДЛ1-Р";
                case 6: return "Артон-ДЛ3";
			}			
			return "";
		}

	
        private void ParseRxBuf() {
			//
            // Version
			int ver = RxBuf[1];
			int build = RxBuf[0];
			textBoxVersion.Text = "v" + ver.ToString() + "." + build.ToString("D2");

			// About devices
			//String str = Encoding.ASCII.GetString(RxBuf, 32, 32);
			textBoxAbout.Text = getDevName(RxBuf[2]);

			// Serial
			int ser = RxBuf[3] + RxBuf[4] * 256 + RxBuf[5] * 256 * 256;
			textBoxSerial.Text = ser.ToString("D7");

			// Date production
            int month = RxBuf[7];  
            int year = RxBuf[6] + 2000;
            textBoxDateProd.Text = month.ToString("D2") + "." + year.ToString("D4");
			DateProd = textBoxDateProd.Text;

            // TimerCalibr
			TimerCalibr = RxBuf[8] + RxBuf[9] * 256;
			textBoxCalibrTimer.Text = TimerCalibr.ToString();

            // Config Reg
			short conf = (short)(RxBuf[16] + RxBuf[17] * 256);
            if ((conf & 0x0001) == 0x0001) {
                checkBoxDrift.Checked = true;
            }else{
                checkBoxDrift.Checked = false;
            }

			String text;
            // Norm Level
            int level = RxBuf[18] + RxBuf[19] * 256;
			if (level != 0xFFFF) text = level.ToString(); else text = "----";
			textBoxLevelNorm.Text = text;
			NormLevel = level;

            // Prefire Level
            level = RxBuf[20] + RxBuf[21] * 256;
			if (level != 0xFFFF) text = level.ToString(); else text = "----";
            textBoxLevelPrefire.Text = text;
			PreFireLevel = level;

            // Fire Level
            level = RxBuf[22] + RxBuf[23] * 256;
			if (level != 0xFFFF) text = level.ToString(); else text = "----";
            textBoxLevelFire.Text = text;
			FireLevel = level;

            // Fire Hister
            level = RxBuf[26] + RxBuf[27] * 256;
			if (level != 0xFFFF) text = level.ToString(); else text = "----";
            textBoxFireHist.Text = text;

            // Drift Level
            level = RxBuf[28] + RxBuf[29] * 256;
			if (level != 0xFFFF) text = level.ToString(); else text = "----";
            textBoxLevelDrift.Text = text;

            // Chamber Lo
            level = RxBuf[30] + RxBuf[31] * 256;
            textBoxChamberLo.Text = level.ToString();
            // Chamber Hi
            level = RxBuf[32] + RxBuf[33] * 256;
            textBoxChamberHi.Text = level.ToString();
            // BAT Level
            level = RxBuf[34] + RxBuf[35] * 256;
            textBoxLevelBAT.Text = (level / 100).ToString("D1") + "." + (level % 100).ToString("D2");
            // CRC
            level = RxBuf[38] + RxBuf[39] * 256;
            textBoxCRC.Text = "0x" + level.ToString("X4");


        }

		readonly UInt16  DARK_LEVEL_LO	= 150;
		readonly UInt16  DARK_LEVEL_HI	= 350;

		readonly UInt16  HV_LEVEL_LO 	= 700;
		readonly UInt16  HV_LEVEL_HI	= 850;

		readonly UInt16  HV_DIFF_HV_LO	= 14;
		readonly UInt16  HV_DIFF_HV_HI	= 42;

		readonly UInt16 HV_LEAKAGE		= 22;


        private void ParseFaults() {
            // Version
            UInt16  faults = (UInt16)(RxBuf[0] + RxBuf[1] * 256);
			
            int level;
            // Dark
            level = RxBuf[2] + RxBuf[3] * 256;
			DarkLevel = level;

			UInt16 levelV = (UInt16)(150 * level / 1024);
            //textBoxDark.Text = level.ToString();
			textBoxDark.Text = (levelV / 100).ToString("D1") + "." + (levelV % 100).ToString("D2");
			///if ((level < DARK_LEVEL_LO) || (level > DARK_LEVEL_HI)) {		// Fault AMP
			///	faults |= 0x0020;	//DeviceFault.fFaultAMP = 1;
			///}
			//
			if ((levelV < 25) || (levelV > 42)) {		// Fault AMP		// 0.25V  0.42V  
				faults |= 0x0020;	//DeviceFault.fFaultAMP = 1;
			}

            // Delta
            level = RxBuf[4] + RxBuf[5] * 256;
            textBoxDelta.Text = level.ToString();
            
			// Drift factor
            short val = (short)(RxBuf[6] + RxBuf[7] * 256);
            textBoxDriftFactor.Text = val.ToString();
            
			// VCC_NO
            UInt16 vcc_no = (UInt16)(RxBuf[8] + RxBuf[9] * 256);
            if (vcc_no < 302) {
				textBoxVCC_NO.Text = (vcc_no / 100).ToString("D1") + "." + (vcc_no % 100).ToString("D2");
            }else{
				vcc_no = 302;
                textBoxVCC_NO.Text = ">3.0";
            }
			
			// VCC
			UInt16 vcc = (UInt16)(RxBuf[10] + RxBuf[11] * 256);
			if (vcc < 302) {
				textBoxVCC.Text = (vcc / 100).ToString("D1") + "." + (vcc % 100).ToString("D2");
			} else {
				vcc = 302;
				textBoxVCC.Text = ">3.0";
			}
			VBAT_LoadString = textBoxVCC.Text;

			//
			//Define Rbat
			int Rbat = ((vcc_no - vcc) * 1000 / (vcc / 4));		// Rload = 40 Ом (расчетное)
			if ((vcc_no == 302) && (vcc == 302)) {
				labelRbat.Text = "";
			} else
			if (vcc_no == 302) {
				Rbat = ((302 - vcc) * 1000 / (vcc / 4));		// Rload = 40 Ом  (расчетное)
				labelRbat.Text = "Расчетное значение Rbat > " + (Rbat / 100).ToString() + "." + (Rbat % 100).ToString("D2") + " Ω";
			} else
				labelRbat.Text = "Расчетное значение Rbat = " + (Rbat / 100).ToString() + "." + (Rbat % 100).ToString("D2") + " Ω";
			

			//labelRbat.Text = "Расчетное значение Rbat = " + (Rbat / 100).ToString() + "." + (Rbat % 100).ToString("D2") + " Ω";
			
			// HV
			level = RxBuf[12] + RxBuf[13] * 256;
			//if ((level < HV_LEVEL_LO) || (level > HV_LEVEL_HI)) {
			//	faults |= 0x0010; //DeviceFault.fFaultBoost = 1;
			//}
			level = 1650 * level / 1024;
			if ((level < 1100) || (level > 1300)) {
				faults |= 0x0010; //DeviceFault.fFaultBoost = 1;
			}
			textBoxHV.Text = (level / 100).ToString("D2") + "." + (level % 100).ToString("D2");
			HiVoltageString = textBoxHV.Text;

			// dHV
			level = RxBuf[14] + RxBuf[15] * 256;
			if (level < 65000) {
				/*
				if (level > HV_DIFF_HV_HI) {
					faults |= 0x0040;		//DeviceFault.fFaultCap = 1;
				}
				if (level < HV_DIFF_HV_LO) {
					faults |= 0x0100;		//DeviceFault.fFaultIRLed = 1;
				}
				 * */
				level = 1650 * level / 1024;
				//
				if (level > 40) {			// 0.4V
					faults |= 0x0040;		//DeviceFault.fFaultCap = 1;
				}
				if (level < 10) {
					faults |= 0x0100;		//DeviceFault.fFaultIRLed = 1;
				}

				textBoxDHV.Text = (level / 100).ToString("D1") + "." + (level % 100).ToString("D2");
			} else {
				textBoxDHV.Text = "---";
			}
			//
			dHV_IR_VoltageString = textBoxDHV.Text;
			
			// lHV
			level = RxBuf[16] + RxBuf[17] * 256;
			if (level < 65000) {
				if (level > HV_LEAKAGE) {
					faults |= 0x0080;		//DeviceFault.fFaultHVLeakage = 1;
				}
				level = 1650 * level / 1024;
				textBoxLHV.Text = (level / 100).ToString("D1") + "." + (level % 100).ToString("D2");
			} else {
				textBoxLHV.Text = "0.00";
			}
			//
			// Temperature
			level = RxBuf[18] + RxBuf[19] * 256;
			level = ((level - 673) * 423) / 1024;
			if (level < 0) level = 0;
			textBoxTemperature.Text = level.ToString();

			//
			if ((faults & 0x0001) == 0x0001) checkBoxFaultBAT.Checked = true; else checkBoxFaultBAT.Checked = false;
			if ((faults & 0x0002) == 0x0002) checkBoxFaultChamber.Checked = true; else checkBoxFaultChamber.Checked = false;
			if ((faults & 0x0004) == 0x0004) checkBoxFaultDrift.Checked = true; else checkBoxFaultDrift.Checked = false;
			if ((faults & 0x0008) == 0x0008) checkBoxFaultSystem.Checked = true; else checkBoxFaultSystem.Checked = false;
			if ((faults & 0x0010) == 0x0010) checkBoxFaultBOOST.Checked = true; else checkBoxFaultBOOST.Checked = false;
			if ((faults & 0x0020) == 0x0020) checkBoxFaultAMP.Checked = true; else checkBoxFaultAMP.Checked = false;
			if ((faults & 0x0040) == 0x0040) checkBoxFaultCAP.Checked = true; else checkBoxFaultCAP.Checked = false;
			if ((faults & 0x0080) == 0x0080) checkBoxFaultLeakage.Checked = true; else checkBoxFaultLeakage.Checked = false;
			if ((faults & 0x0100) == 0x0100) checkBoxFaultIRLed.Checked = true; else checkBoxFaultIRLed.Checked = false;
			//if ((faults & 0x0200) > 0)		checkBoxFaultBuzzer.Checked = true; else checkBoxFaultBuzzer.Checked = false;
			if ((faults & 0x0C00) > 0)		 checkBoxFaultConfig.Checked = true; else checkBoxFaultConfig.Checked = false;
			if ((faults & 0x1000) > 0)		 checkBoxFaultTimer.Checked = true; else checkBoxFaultTimer.Checked = false;
			if ((faults & 0x2000) > 0)		 checkBoxFaultSWReset.Checked = true; else checkBoxFaultSWReset.Checked = false;
			//
			if (faults == 0) {
				panelFault.BackColor = Color.FromArgb(0, 192, 0);
			} else {
				panelFault.BackColor = Color.FromArgb(240, 0, 0);
			}
			//
			FaultsWord = faults;
        }

		bool g1_begin = false;
		bool g2_begin = false;

// Timer 1 tick
        private void timer1_Tick(object sender, EventArgs e)         {
            try {
                timer1.Enabled = false;
				//
				if (len_rx > 0) {
					serial1.Read(RxBuf, 0, len_rx);
				}
				serial1.Close();

				//
				if (lastQualifier == Q_DEVINIT_PHASE1) {
					//
					labelText.Text = "Чтение параметров из энергонезависимой памяти";
					progressBar.Value = 40;
					buttonRead.Enabled = false;
					//
					len_rx = 64;
					lastQualifier = Q_GET_MEM;
					Byte[] TxBuf = { lastQualifier, 0, (byte)len_rx };

					serial1.Open();
					serial1.Write(TxBuf, 0, 3);
					// Получаем только что отосланное
					tmp[0] = serial1.ReadByte();
					tmp[1] = serial1.ReadByte();
					tmp[2] = serial1.ReadByte();
					//
					timer1.Interval = 1000;
					timer1.Enabled = true;
					
					lastQualifier = Q_DEVINIT_PHASE2;
					return;
				}

				if (lastQualifier == Q_DEVINIT_PHASE2) {
					//
					labelText.Text = "Запись серийного номера и даты производства";
					progressBar.Value = 70;
					//
					// Serial
					RxBuf[3] = Convert.ToByte(numUpDownSN.Value % 256);	// curSN;
					RxBuf[4] = Convert.ToByte(numUpDownSN.Value / 256 % 256);
					RxBuf[5] = Convert.ToByte(numUpDownSN.Value / 256 / 256 % 256);
					//
					// Date production
					RxBuf[6] = (byte)DateTime.Now.Month;				// month  
					RxBuf[7] = (byte)(DateTime.Now.Year - 2000);		// year
					//
					Array.Copy(RxBuf, BackupMem, 64);
					ParseRxBuf();
					
					lastQualifier = 0;			// На случай сработки исключения
					//
					// Write new parameters
					//
					CreateConfigMem();		// Create TxMem array
					//
					lastQualifier = 0;
					len_rx = 0;
					//
					try {
						lastQualifier = Q_SET_MEM_ALL;
						Byte[] TxBuf = { lastQualifier, 0 };		//  0 offset

						serial1.Open();

						serial1.Write(TxBuf, 0, 2);
						serial1.Write(TxMem, 0, 32);
						//
						int b;
						for (int i = 0; i < 34; i++) {
							b = serial1.ReadByte();
						}
						serial1.Close();
						//
						lastQualifier = Q_DEVINIT_PHASE3;
						timer1.Interval = 1800;
						timer1.Enabled = true;

					} catch (Exception ex) {
						serial1.Close();
					}
					//
					return;
				}
				//
				if (lastQualifier == Q_DEVINIT_PHASE3) {
					//
					// Diagnostic
					//
					labelText.Text = "Диагностика неисправностей";
					progressBar.Value = 85;
					//
					try {
						len_rx = 20;
						lastQualifier = Q_COMMAND;
						lastCommand = COMMAND_DIAGN;
						Byte[] TxBuf = { lastQualifier, COMMAND_DIAGN };
						serial1.Open();
						serial1.Write(TxBuf, 0, 2);
						// Получаем только что отосланное
						int b = serial1.ReadByte();
						b = serial1.ReadByte();

						timer1.Interval = 1400;
						timer1.Enabled = true;
						//
						lastQualifier = Q_DEVINIT_PHASE4;
						
					} catch (Exception ex) {
						serial1.Close();
					}
					//
					return;
				}
				//
				//
				if (lastQualifier == Q_DEVINIT_PHASE4) {
					//
					// Diagnostic
					//
					labelText.Text = "Диагностика неисправностей";
					progressBar.Value = 100;
					//
					try {
						len_rx = 20;
						lastQualifier = Q_COMMAND;
						lastCommand = COMMAND_DIAGN;
						Byte[] TxBuf = { lastQualifier, COMMAND_DIAGN };
						serial1.Open();
						serial1.Write(TxBuf, 0, 2);
						// Получаем только что отосланное
						int b = serial1.ReadByte();
						b = serial1.ReadByte();

						timer1.Interval = 1400;
						timer1.Enabled = true;

						//
						lastQualifier = Q_DEVINIT_PHASE5;

					} catch (Exception ex) {
						serial1.Close();
					}
					//
					return;
				}
				//
				if (lastQualifier == Q_DEVINIT_PHASE5) {
					//
					// Diagnostic result
					//
					ParseFaults();
					buttonDiagnostic.Enabled = true;
					//
					// Окончание инициализации
					buttonDeviceInit.Enabled = true;
					buttonSet00dB.Enabled = true;
					buttonCalibration.Enabled = true;
					buttonWrite.Enabled = true;
					buttonRead.Enabled = true;
					buttonFaultsReset.Enabled = true;
					checkBoxLog.Enabled = true;
					//
					progressBar.Visible = false;
					labelText.Visible = false;
					//
					fileLog.WriteLine(numUpDownSN.Value.ToString() + ";" +
										DateProd + ";" +
										NormLevel.ToString() + ";" +
										PreFireLevel.ToString() + ";" +
										FireLevel.ToString() + ";" +
										DarkLevel.ToString() + ";" +
										TimerCalibr.ToString() + ";" +
										VBAT_LoadString + ";" +
										dHV_IR_VoltageString + ";" +
										HiVoltageString + ";" +
										FaultsWord.ToString("X4")
										);

					//
					lastQualifier = 0;
					//curSN++;		// Увеличени SN
					numUpDownSN.Value++;	// = curSN;
					if (numUpDownSN.Value >= 0x10000) {
						numUpDownSN.Value = 1;
					}

					//
					return;
				}
				//


                if (lastQualifier == Q_GET_MEM) {
					Array.Copy(RxBuf, BackupMem, 64);
                    ParseRxBuf();
					buttonRead.Enabled = true;
					lastQualifier = 0;
                }
				//
                if (lastQualifier == Q_COMMAND) {
					if (lastCommand == COMMAND_RESET) {
						buttonFaultsReset.Enabled = true;
						//
						lastQualifier = 0;
						string s = serial1.ReadExisting();
					}
                    if (lastCommand == COMMAND_DIAGN) {
                        ParseFaults();
						buttonDiagnostic.Enabled = true;
						//
						lastQualifier = 0;
                    }
					if (lastCommand == COMMAND_CALIBR_10) {
						buttonCalibration.Enabled = true;
						lastQualifier = 0;
						//
						buttonRead_Click(sender, e);		// Читаем из извещателя
						//
					}
					if (lastCommand == COMMAND_CALIBR_00) {
						buttonSet00dB.Enabled = true;
						lastQualifier = 0;
						//
						buttonRead_Click(sender, e);		// Читаем из извещателя
						//
					}
                }

            }catch (Exception ex) {
                serial1.Close();
				//
				if (lastQualifier >= Q_DEVINIT_PHASE1) {
					MessageBox.Show("Сбой процесса инициализации!\r\n\r\nПодробности: " + ex.Message, "Ошибка!");
				}
				/*
				groupBox1.Enabled = true;
				groupBox6.Enabled = true;
				groupBox7.Enabled = true;
				groupBoxCommand.Enabled = true;
				buttonDeviceInit.Enabled = true;
				*/
				//
				progressBar.Visible = false;
				labelText.Visible = false;
				//
				ButtonsEnable();
				//
				lastQualifier = 0;
				//
				if (lastQualifier == Q_GET_MEM) {
					buttonRead.Enabled = true;
					lastQualifier = 0;
				}
				if (lastQualifier == Q_COMMAND) {
					if (lastCommand == COMMAND_DIAGN) {
						buttonDiagnostic.Enabled = true;
						lastQualifier = 0;
					}
					if (lastCommand == COMMAND_CALIBR_10) {
						buttonCalibration.Enabled = true;
						lastQualifier = 0;
					}
					if (lastCommand == COMMAND_CALIBR_00) {
						buttonSet00dB.Enabled = true;
						lastQualifier = 0;
					}
				}
            }
        }

		private void timer2_Tick ( object sender, EventArgs e ) {
			//timer2.Enabled = false;

			if (fLogEnabled) {
			//if (lastCommand == COMMAND_GET_DELTA) {
				if (log_item != null) {
					textBoxLog.Text += log_item;
					textBoxLog.SelectionStart = textBoxLog.Text.Length;
					textBoxLog.ScrollToCaret();
					//alternative 
					//textBoxLog.SelectionStart = textBoxLog.Text.Length - 1;
					log_item = null;
				}

				if (fLogWaitReceive) {
					fLogWaitReceive = false;
					if (serial1.IsOpen == false) {
						timer2.Enabled = false;
						lastQualifier = 0;
						lastCommand = 0;
						fLogEnabled = false;
						return;
					}
					int count = serial1.BytesToRead;
					serial1.Read(RxBuf, 0, count);
					if (count == 4) {
						int dark = RxBuf[0] + RxBuf[1] * 256;
						int level = RxBuf[2] + RxBuf[3] * 256;

						int interval = FireLevel - NormLevel;
						int d = level - NormLevel;
						if (d < 0) d = 0;
						if (d > 1024) d = 0;
						if (interval <= 0) interval = 240;

						double db = ((double)d / (double)interval) * 0.1;	//0.1dB/m - уровень FireLevel

						if (checkBoxdBm.Checked == false) {
							log_item = level.ToString() + ";" + dark.ToString() + "\r\n";
						} else {
							log_item = db.ToString("F3") + " dB/m\r\n";
						}
						//
						labeldBm.Text = db.ToString("F3") + " dB/m"; ;

					} else {
						log_item = null;
					}
					//
					timer2.Interval = (int)numericLogInterval.Value * 1000 - 500;
				} else {
					//
					lastQualifier = Q_COMMAND;
					lastCommand = COMMAND_GET_DELTA;
					Byte[] TxBuf = { lastQualifier, lastCommand };
					try {
						serial1.Write(TxBuf, 0, 2);
						//
						int b;
						b = serial1.ReadByte();
						b = serial1.ReadByte();
						fLogWaitReceive = true;
					} catch (Exception ex) {
						serial1.Close();
						timer2.Enabled = false;
						lastQualifier = 0;
						lastCommand = 0;
						fLogEnabled = false;

					}
				}
			}
			//
			if (fRSSIEnabled) {
				//if (lastCommand == COMMAND_GET_DELTA) {
				if (rssi_item != null) {
					textBoxRSSI.Text += rssi_item;
					textBoxRSSI.SelectionStart = textBoxRSSI.Text.Length;
					textBoxRSSI.ScrollToCaret();
					//alternative 
					//textBoxLog.SelectionStart = textBoxLog.Text.Length - 1;
					rssi_item = null;
				}

				if (fRSSIWaitReceive) {
					fRSSIWaitReceive = false;
					if (serial1.IsOpen == false) {
						timer2.Enabled = false;
						lastQualifier = 0;
						lastCommand = 0;
						fRSSIEnabled = false;
						return;
					}
					int count = serial1.BytesToRead;
					serial1.Read(RxBuf, 0, count);
					if (count == 2) {
						int rssi = (int)((sbyte)RxBuf[0]);
						int LQI = RxBuf[1];

						rssi_item = rssi.ToString() + ";" + "   " + LQI.ToString() + "\r\n";
						//
					} else {
						rssi_item = null;
					}
					//
					timer2.Interval = (int)numericRSSIInterval.Value - 500;
				} else {
					//
					lastQualifier = Q_COMMAND;
					lastCommand = COMMAND_GET_RSSI;
					Byte[] TxBuf = { lastQualifier, lastCommand };
					try {
						serial1.Write(TxBuf, 0, 2);
						//
						int b;
						b = serial1.ReadByte();
						b = serial1.ReadByte();
						fRSSIWaitReceive = true;
					} catch (Exception ex) {
						serial1.Close();
						timer2.Enabled = false;
						lastQualifier = 0;
						lastCommand = 0;
						fRSSIEnabled = false;

					}
				}
			}
		}


        byte[] getBytesFromString(String str, int len)
        {
            byte[] ascii = new byte[len];
            byte[] bytes = new byte[len];
            Array.Clear(bytes, 0, len);
            ascii = Encoding.ASCII.GetBytes(str);
            int count = ascii.Length;
            if (count > len)
            {
                count = len;
            }
            Array.Copy(ascii, bytes, count);
            return bytes;
        }

        byte[] getTimeFromString(String str)
        {
            byte[] bytes = new byte[2];
            Array.Clear(bytes, 0, 2);
            if ((str == null) || str.Equals(""))
            {
                return bytes;
            }
            ///int pos = str.

            string sub = str.Substring(0, 2);
            bytes[0] = Convert.ToByte(sub);
            sub = str.Substring(3, 2);
            bytes[1] = Convert.ToByte(sub);
            return bytes;
        }


        private void SendByte(byte b)
        {
            byte[] buf = new byte[1];
            buf[0] = b;
            serial1.Write(buf, 0, 1);
        }


        private void buttonDiagnostic_Click(object sender, EventArgs e) {
            try {
                len_rx = 20;
                //len_sent = 0;
                lastQualifier = Q_COMMAND;
                lastCommand = COMMAND_DIAGN;
                Byte[] TxBuf = {lastQualifier, COMMAND_DIAGN };

                serial1.Open();

				string temp = serial1.ReadExisting();

                serial1.Write(TxBuf, 0, 2);
                // Получаем только что отосланное
				int b = serial1.ReadByte();
					b = serial1.ReadByte();

                timer1.Interval = 1200;
                timer1.Enabled = true;
				buttonDiagnostic.Enabled = false;
            }catch (Exception ex) {
                serial1.Close();
            }
            

        }


		private void checkBoxLog_CheckedChanged ( object sender, EventArgs e ) {
			if (checkBoxLog.Checked) {
				fLogEnabled = true;
				serial1.ReceivedBytesThreshold = 1;
				//serial1.DataReceived += serial1_DataReceived;
				
				lastQualifier = Q_COMMAND;
				lastCommand = COMMAND_GET_DELTA;
				Byte[] TxBuf = { lastQualifier, lastCommand};

				try {
					serial1.Open();
					serial1.Write(TxBuf, 0, 2);
					//
					fLogWaitReceive = true;
					//
					timer2.Interval = 500;
					timer2.Enabled = true;
					//
					buttonDeviceInit.Enabled = false;
					buttonDiagnostic.Enabled = false;
					buttonRead.Enabled = false;
					buttonWrite.Enabled = false;
					groupBoxCommand.Enabled = false;
					//
					int b;
					b = serial1.ReadByte();
					b = serial1.ReadByte();
				} catch (Exception ex) {
					serial1.Close();
				}

			} else {
				lastQualifier = 0;
				lastCommand = 0;
				try {
					fLogEnabled = false;
					timer2.Enabled = false;
					serial1.Close();
					//serial1.DataReceived -= serial1_DataReceived;
				} catch (Exception ex) {
					serial1.Close();
				}
				//
				buttonDeviceInit.Enabled = true;
				buttonDiagnostic.Enabled = true;
				buttonRead.Enabled = true;
				buttonWrite.Enabled = true;
				groupBoxCommand.Enabled = true;
			}
		}

		private void checkBoxRSSI_CheckedChanged ( object sender, EventArgs e ) {
			if (checkBoxRSSI.Checked) {
				fRSSIEnabled = true;
				serial1.ReceivedBytesThreshold = 1;

				lastQualifier = Q_COMMAND;
				lastCommand = COMMAND_GET_RSSI;
				Byte[] TxBuf = { lastQualifier, lastCommand };

				try {
					serial1.Open();
					serial1.Write(TxBuf, 0, 2);
					//
					fRSSIWaitReceive = true;
					//
					timer2.Interval = 500;
					timer2.Enabled = true;
					//
					buttonDeviceInit.Enabled = false;
					buttonDiagnostic.Enabled = false;
					buttonRead.Enabled = false;
					buttonWrite.Enabled = false;
					groupBoxCommand.Enabled = false;
					//
					int b;
					b = serial1.ReadByte();
					b = serial1.ReadByte();
				} catch (Exception ex) {
					serial1.Close();
				}

			} else {
				lastQualifier = 0;
				lastCommand = 0;
				try {
					fRSSIEnabled = false;
					timer2.Enabled = false;
					serial1.Close();
				} catch (Exception ex) {
					serial1.Close();
				}
				//
				buttonDeviceInit.Enabled = true;
				buttonDiagnostic.Enabled = true;
				buttonRead.Enabled = true;
				buttonWrite.Enabled = true;
				groupBoxCommand.Enabled = true;
			}
		}


		private void CreateConfigMem () {

			Array.Copy(BackupMem, TxMem, 64);
			//
			// Version
			// Date production
			// Serial
			// TimerCalibr
			// Config Reg
			short conf = 0;
			if (checkBoxDrift.Checked) {
				conf |= 0x0001;
			}else{
				conf &= ~0x0001;
			}
			TxMem[16] = (byte)conf;				// Config reg[0]
			TxMem[17] = (byte)(conf >> 8);		// Config reg[1]

			try {
				// Norm Level
				UInt16 level = Convert.ToUInt16(textBoxLevelNorm.Text);
				if ((level > 0) && (level < 1023)) {
					TxMem[18] = (byte)level;
					TxMem[19] = (byte)(level >> 8);
				}

				// Prefire Level
				level = Convert.ToUInt16(textBoxLevelPrefire.Text);
				if ((level > 0) && (level < 1023)) {
					TxMem[20] = (byte)level;
					TxMem[21] = (byte)(level >> 8);
				}


				// Fire Level
				level = Convert.ToUInt16(textBoxLevelFire.Text);
				if ((level > 0) && (level < 1023)) {
					TxMem[22] = (byte)level;
					TxMem[23] = (byte)(level >> 8);
				}

				// Fire Hister
				level = Convert.ToUInt16(textBoxFireHist.Text);
				if ((level >= 0) && (level < 200)) {
					TxMem[26] = (byte)level;
					TxMem[27] = (byte)(level >> 8);
				}

				// Drift Level
				level = Convert.ToUInt16(textBoxLevelDrift.Text);
				if ((level >= 0) && (level < 1023)) {
					TxMem[28] = (byte)level;
					TxMem[29] = (byte)(level >> 8);
				}

				// Chamber Lo
				level = Convert.ToUInt16(textBoxChamberLo.Text);
				if ((level >= 0) && (level < 512)) {
					TxMem[30] = (byte)level;
					TxMem[31] = (byte)(level >> 8);
				}

				// Chamber Hi
				level = Convert.ToUInt16(textBoxChamberHi.Text);
				if ((level >= 0) && (level < 512)) {
					TxMem[32] = (byte)level;
					TxMem[33] = (byte)(level >> 8);
				}

				NumberFormatInfo provider = new NumberFormatInfo();
				provider.NumberDecimalSeparator = ".";
				provider.NumberGroupSeparator = ",";
				provider.NumberGroupSizes = new int[] { 3 };

				// BAT Level
				double dd = Convert.ToDouble(textBoxLevelBAT.Text, provider);
				dd *= 100; 
				level = (UInt16)Math.Round(dd);

				if ((level >= 200) || (level <= 350)) {
					TxMem[34] = (byte)level;
					TxMem[35] = (byte)(level >> 8);
				}
				//
				//CRC
				UInt16 cs = getCRCTxMem();
				TxMem[38] = (byte)cs;
				TxMem[39] = (byte)(cs >> 8);

				textBoxCRC.Text = "0x" + cs.ToString("X4");


			} catch (Exception ex) {
				MessageBox.Show("Неверное значение одного из параметров.", "Ошибка!");
			}

		}


		private UInt16 getCRCTxMem () {
			//
			//CRC
			UInt16 word = 0;
			UInt16 cs = 0;
			for (int i = 0; i < 38 / 2; i++) {
				word = (UInt16)(TxMem[2 * i] + TxMem[2 * i + 1] * 256);
				cs ^= word;
			}
			return cs;
			//
			//BackupMem[30] = (byte)cs;
			//BackupMem[31] = (byte)(cs >> 8);

			//textBoxCRC.Text = "0x" + cs.ToString("X4");
		}


		private void CreateCRCMem () {
			//
			//CRC
			UInt16 word = 0;
			UInt16 cs = 0;
			for (int i = 0; i < 38 / 2; i++) {
				word = (UInt16)(BackupMem[2 * i] + BackupMem[2 * i + 1] * 256);
				cs ^= word;
			}
			
			BackupMem[38] = (byte)cs;
			BackupMem[39] = (byte)(cs >> 8);

			textBoxCRC.Text = "0x" + cs.ToString("X4");
		}


		private void FileWriteInfo () {
			fileWrite.WriteLine(textBoxSerial.Text + ";" +
								textBoxDateProd.Text + ";" +
								textBoxLevelNorm.Text + ";" +
								textBoxLevelFire.Text + ";" +
								textBoxLevelPrefire.Text + ";" +
								textBoxLevelDrift.Text + ";" +
								textBoxCalibrTimer.Text + ";" +
								textBoxLevelBAT.Text
								);
		}

					//

		private void buttonWrite_Click ( object sender, EventArgs e ) {

			CreateConfigMem ();

			try {
                lastQualifier = Q_SET_MEM_ALL;
                Byte[] TxBuf = {lastQualifier, 0 };		//  0 offset

                serial1.Open();

                serial1.Write(TxBuf, 0, 2);
				serial1.Write(TxMem, 0, 40);
                //
				int b;
				for (int i = 0; i < (40 + 2); i++) {
					b = serial1.ReadByte();
				}

				serial1.Close();
				buttonWrite.Enabled = false;
                //timer1.Interval = 400;
                //timer1.Enabled = true;
				FileWriteInfo();

            }catch (Exception ex) {
                serial1.Close();
            }
		}

		private void textBoxLevelNorm_TextChanged ( object sender, EventArgs e ) {
			CreateCRCMem();
			buttonWrite.Enabled = true;
		}

		private void toolStripButton1_Click ( object sender, EventArgs e ) {
			Array.Copy(BackupMem, RxBuf, 64);
			ParseRxBuf();

		}

		private void textBoxLevelNorm_TextChanged_1 ( object sender, EventArgs e ) {
			buttonWrite.Enabled = true;
		}

		private void buttonClearLog_Click ( object sender, EventArgs e ) {
			textBoxLog.Clear();
		}

		private void buttonClearRSSI_Click ( object sender, EventArgs e ) {
			textBoxRSSI.Clear();
		}


		private void buttonCalibration_Click ( object sender, EventArgs e ) {
			try {
				len_rx = 0;
				lastQualifier = Q_COMMAND;
				lastCommand = COMMAND_CALIBR_10;
				Byte[] TxBuf = { lastQualifier, lastCommand};

				serial1.Open();
				int len = 2;
				serial1.Write(TxBuf, 0, len);
				// Получаем только что отосланное
				int b;
				for (int i = 0; i < len; i++) {
					b = serial1.ReadByte();
				}
				timer1.Interval = 1200;
				timer1.Enabled = true;
				buttonCalibration.Enabled = false;

			} catch (Exception ex) {
				serial1.Close();
			}
		}

		private void buttonSet00dB_Click ( object sender, EventArgs e ) {
			try {
				len_rx = 0;
				lastQualifier = Q_COMMAND;
				lastCommand = COMMAND_CALIBR_00;
				Byte[] TxBuf = { lastQualifier, lastCommand };

				serial1.Open();
				int len = 2;
				serial1.Write(TxBuf, 0, len);
				// Получаем только что отосланное
				int b;
				for (int i = 0; i < len; i++) {
					b = serial1.ReadByte();
				}
				timer1.Interval = 2400;
				timer1.Enabled = true;
				buttonSet00dB.Enabled = false;

			} catch (Exception ex) {
				serial1.Close();
			}

		}

		private void buttonFaultsReset_Click ( object sender, EventArgs e ) {
			try {
				len_rx = 0;
				lastQualifier = Q_COMMAND;
				lastCommand = COMMAND_RESET;
				Byte[] TxBuf = { lastQualifier, lastCommand };

				serial1.Open();
				int len = 2;
				serial1.Write(TxBuf, 0, len);
				// Получаем только что отосланное
				int b;
				for (int i = 0; i < len; i++) {
					b = serial1.ReadByte();
				}
				timer1.Interval = 200;
				timer1.Enabled = true;
				buttonFaultsReset.Enabled = false;

			} catch (Exception ex) {
				serial1.Close();
			}

		}

		private void ButtonsEnable () {
			buttonDeviceInit.Enabled = true;
			buttonDiagnostic.Enabled = true;
			buttonWrite.Enabled = true;
			buttonRead.Enabled = true;
			buttonSet00dB.Enabled = true;
			buttonCalibration.Enabled = true;
			buttonFaultsReset.Enabled = true;
			checkBoxLog.Enabled = true;
		}


		private void ButtonsDisable () {
			buttonDeviceInit.Enabled = false;
			buttonDiagnostic.Enabled = false;
			buttonSet00dB.Enabled = false;
			buttonCalibration.Enabled = false;
			buttonWrite.Enabled = false;
			buttonRead.Enabled = false;
			buttonFaultsReset.Enabled = false;
			checkBoxLog.Enabled = false;
		}


		private void buttonDeviceInit_Click ( object sender, EventArgs e ) {
			//serial1.ReceivedBytesThreshold = 1;
			try {
				
				progressBar.Visible = true;
				labelText.Visible = true;

				ButtonsDisable();

				//
				labelText.Text = "Калибровка таймера, фона и установка начальных значений параметров";
				progressBar.Value = 10;
				//

				len_rx = 0;
				lastQualifier = Q_COMMAND;
				lastCommand = COMMAND_CALIBR_00;
				Byte[] TxBuf = { lastQualifier, lastCommand };

				serial1.Open();
				int len = 2;
				serial1.Write(TxBuf, 0, len);
				// Получаем только что отосланное
				int b;
				for (int i = 0; i < len; i++) {
					b = serial1.ReadByte();
				}
				timer1.Interval = 2400;
				timer1.Enabled = true;
				lastQualifier = Q_DEVINIT_PHASE1;

			} catch (Exception ex) {
				serial1.Close();
				/*
				groupBox1.Enabled = true;
				groupBox6.Enabled = true;
				groupBox7.Enabled = true;
				groupBoxCommand.Enabled = true;
				buttonDeviceInit.Enabled = true;
				*/
				//
				progressBar.Visible = false;
				labelText.Visible = false;
			}
		}

		private void textBoxLevelFire_TextChanged ( object sender, EventArgs e ) {
			buttonWrite.Enabled = true;
		}

		private void textBoxLevelFire_KeyPress ( object sender, KeyPressEventArgs e ) {

		}

		private void OtherLevelsCalculate() {
			// Fire Level
			int fire_level = Convert.ToUInt16(textBoxLevelFire.Text);
			int norm_level = Convert.ToUInt16(textBoxLevelNorm.Text);
			if ((fire_level > 100) && (fire_level < 700)) {
				int delta = fire_level - norm_level;
				if (delta >= 50) {
					if (checkBoxFireLevel.Checked) {
						textBoxLevelPrefire.Text = (fire_level - delta / 4).ToString();
						textBoxLevelDrift.Text = (norm_level + delta / 2).ToString();
					}
				} else {
					fire_level = BackupMem[22] + BackupMem[23] * 256;
					if (fire_level != 0xFFFF) textBoxLevelFire.Text = fire_level.ToString(); else textBoxLevelFire.Text = "----";
				}
			} else {
				fire_level = BackupMem[22] + BackupMem[23] * 256;
				if (fire_level != 0xFFFF) textBoxLevelFire.Text = fire_level.ToString(); else textBoxLevelFire.Text = "----";
			}
			FireLevel = fire_level;
				
		}
	

		private void textBoxLevelFire_KeyDown ( object sender, KeyEventArgs e ) {
			if (e.KeyCode == Keys.Enter) {
				OtherLevelsCalculate();
			}
		}

		private void textBoxCurDB_KeyDown ( object sender, KeyEventArgs e ) {
			if (e.KeyCode == Keys.Enter) {
				double db = Convert.ToDouble(textBoxCurDB.Text);
				double db_need = Convert.ToDouble(textBoxNewFireDB.Text);
				double koeff = db_need / db;
				double fireDouble = Convert.ToDouble(textBoxLevelFire.Text);
				double normDouble = Convert.ToDouble(textBoxLevelNorm.Text);
				double delta = fireDouble - normDouble;
				double newFireDouble = normDouble + delta * koeff;

				textBoxNewFireLevel.Text = ((int)newFireDouble).ToString();
			}
		}

		private void buttonChange_Click ( object sender, EventArgs e ) {
			textBoxLevelFire.Text = textBoxNewFireLevel.Text;
			OtherLevelsCalculate();
		}

		private void buttonSetNewBATLevel_Click ( object sender, EventArgs e ) {
			textBoxLevelBAT.Text = textBoxLevelBATNew.Text;
		}

	bool bGraphEnable = false;
	Graphics g1, g2;
	Byte[] g_buf = new byte[512];
	int g_samples = 0;


		private void DrawGraph ( Graphics g ) {
			Pen my_pen = new Pen(Color.Green, 2);
			//my_pen.PenType = 
			g.Clear(Color.LightGray);
			float x_min = 0, x_max = 0, y_min = 0, y_max = 0;
			float xstep, ystep;
			float x1, y1, x2, y2;

			xstep = (float)panelGraph1.Width / (g_samples / 2);
			ystep = (float)panelGraph1.Height / 1024;
			x1 = 0;
			y1 = (1024 - (g_buf[2] + g_buf[3] * 256)) * ystep;
			if (g_samples == 0) g_samples = 95;

			for (int i = 0; i < g_samples; i += 2) {
				x2 = x1 + xstep;
				y2 = (1024 - (g_buf[i] + g_buf[i + 1] * 256)) * ystep;
				//
				g.DrawLine(my_pen, x1, y1, x2, y2);
				//
				g.Flush();
				//
				x1 = x2;
				y1 = y2;
			}
		}


		private void buttonViewGraph_Click ( object sender, EventArgs e ) {
			if (groupGraph.Visible) {
				bGraphEnable = false;
				groupGraph.Visible = false;

				timer3.Enabled = false;

				if (serial1.IsOpen) serial1.Close();


			} else {
				bGraphEnable = true;
				groupGraph.Visible = true;
				//
				g1 = panelGraph1.CreateGraphics();
				g2 = panelGraph2.CreateGraphics();
				//
				len_rx = 0;
				lastQualifier = Q_GET_GRAPH;
				Byte[] TxBuf = {lastQualifier};

				if (serial1.IsOpen) serial1.Close();
				serial1.Open();
				serial1.Write(TxBuf, 0, 1);
				// Получаем только что отосланное
				int b;
				b = serial1.ReadByte();

				timer3.Interval = 1100;
				timer3.Enabled = true;

				//serial1.Write(TxBuf, 0, 1);
				// Получаем только что отосланное
				//b = serial1.ReadByte();

				//g_buf[2] = 100; g_buf[3] = 0;
				//g_buf[4] = 200; g_buf[5] = 0;
				//g_buf[6] = 100; g_buf[7] = 0;
				//DrawGraph();
			}

		}



		private void timer3_Tick ( object sender, EventArgs e ) {

			timer3.Enabled = false;
			//
			//
			byte b1, b2;
			int count;
			int delta;

			try {

				count = serial1.BytesToRead;

				//labelPulsesMagnitude.Text = count.ToString();

				while (count > 0) {
					b1 = (byte)serial1.ReadByte();
					if ((b1 == Q_SEND_GRAPH1) || (b1 == Q_SEND_GRAPH2)) {
						b2 = (byte)serial1.ReadByte();
						if (b1 == Q_SEND_GRAPH1) {
							g1_begin = true;
							g2_begin = false;
						} else {
							g1_begin = false;
							g2_begin = true;
						}
						g_samples = b2;
						//
						for (int i = 0; i < (int)g_samples; i++) {
							b1 = (byte)serial1.ReadByte();
							g_buf[i] = b1;
						}
						//
						DrawGraph(g1);
						break;
					}
					count--;
				}
				//
				//
				b1 = (byte)serial1.ReadByte();
				if ((b1 == Q_SEND_GRAPH1) || (b1 == Q_SEND_GRAPH2)) {
					b2 = (byte)serial1.ReadByte();
					if (b1 == Q_SEND_GRAPH1) {
						g1_begin = true;
						g2_begin = false;
					} else {
						g1_begin = false;
						g2_begin = true;
					}
					g_samples = b2;
					//
					for (int i = 0; i < (int)g_samples; i++) {
						b1 = (byte)serial1.ReadByte();
						g_buf[i] = b1;
					}
					//
					DrawGraph(g2);
				}
				//
				//

				b1 = (byte)serial1.ReadByte();
				b2 = (byte)serial1.ReadByte();
				delta = b1 + b2 * 256;

				//labelPulsesMagnitude.Text = "Уровень сигнала = " + delta.ToString() + "инкрем." ;
				//
				textBoxLevel.Text = delta.ToString();

				lastQualifier = Q_GET_GRAPH;
				Byte[] TxBuf = { lastQualifier };

				serial1.Write(TxBuf, 0, 1);
				// Получаем только что отосланное
				int b = serial1.ReadByte();

				timer3.Interval = 1100;
				timer3.Enabled = true;

			} catch (Exception ex) {
				serial1.Close();

				serial1.Open();

				lastQualifier = Q_GET_GRAPH;
				Byte[] TxBuf = { lastQualifier };
label_prev:
				try {
					serial1.Write(TxBuf, 0, 1);
					// Получаем только что отосланное
					int b = serial1.ReadByte();
				} catch (Exception exx) {
					goto label_prev;
				}

				timer3.Interval = 1100;
				timer3.Enabled = true;
			}

			return;
		}
    }



}
