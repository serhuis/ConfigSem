namespace Q_Config
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.portsComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serial1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxDrift = new System.Windows.Forms.CheckBox();
            this.textBoxChamberLo = new System.Windows.Forms.TextBox();
            this.textBoxChamberHi = new System.Windows.Forms.TextBox();
            this.textBoxLevelFire = new System.Windows.Forms.TextBox();
            this.textBoxCRC = new System.Windows.Forms.TextBox();
            this.textBoxLevelDrift = new System.Windows.Forms.TextBox();
            this.textBoxLevelPrefire = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLevelBAT = new System.Windows.Forms.TextBox();
            this.textBoxFireHist = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxLevelNorm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCalibrTimer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDateProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVersion = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.dataGridProp = new System.Windows.Forms.DataGridView();
            this.ColNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRbat = new System.Windows.Forms.Label();
            this.textBoxVCC_NO = new System.Windows.Forms.TextBox();
            this.textBoxVCC = new System.Windows.Forms.TextBox();
            this.textBoxDHV = new System.Windows.Forms.TextBox();
            this.textBoxDark = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.textBoxLHV = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxDriftFactor = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.textBoxHV = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panelFault = new System.Windows.Forms.Panel();
            this.checkBoxFaultIRLed = new System.Windows.Forms.CheckBox();
            this.checkBoxFaultSWReset = new System.Windows.Forms.CheckBox();
            this.checkBoxFaultTimer = new System.Windows.Forms.CheckBox();
            this.checkBoxFaultConfig = new System.Windows.Forms.CheckBox();
            this.checkBoxFaultLeakage = new System.Windows.Forms.CheckBox();
            this.checkBoxFaultSystem = new System.Windows.Forms.CheckBox();
            this.checkBoxFaultAMP = new System.Windows.Forms.CheckBox();
            this.checkBoxFaultChamber = new System.Windows.Forms.CheckBox();
            this.checkBoxFaultCAP = new System.Windows.Forms.CheckBox();
            this.checkBoxFaultDrift = new System.Windows.Forms.CheckBox();
            this.checkBoxFaultBOOST = new System.Windows.Forms.CheckBox();
            this.checkBoxFaultBAT = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.buttonDiagnostic = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.buttonFaultsReset = new System.Windows.Forms.Button();
            this.groupBoxCommand = new System.Windows.Forms.GroupBox();
            this.buttonSet00dB = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.buttonCalibration = new System.Windows.Forms.Button();
            this.buttonDeviceInit = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelText = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.numUpDownSN = new System.Windows.Forms.NumericUpDown();
            this.numericLogInterval = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.checkBoxLog = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labeldBm = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.checkBoxdBm = new System.Windows.Forms.CheckBox();
            this.checkBoxFireLevel = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBoxNewFireDB = new System.Windows.Forms.TextBox();
            this.textBoxNewFireLevel = new System.Windows.Forms.TextBox();
            this.textBoxCurDB = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.textBoxLevelBATNew = new System.Windows.Forms.TextBox();
            this.buttonSetNewBATLevel = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.buttonClearRSSI = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label45 = new System.Windows.Forms.Label();
            this.textBoxRSSI = new System.Windows.Forms.TextBox();
            this.numericRSSIInterval = new System.Windows.Forms.NumericUpDown();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxRSSI = new System.Windows.Forms.CheckBox();
            this.buttonViewGraph = new System.Windows.Forms.Button();
            this.groupGraph = new System.Windows.Forms.GroupBox();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.labelPulsesMagnitude = new System.Windows.Forms.Label();
            this.panelGraph2 = new System.Windows.Forms.Panel();
            this.panelGraph1 = new System.Windows.Forms.Panel();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProp)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBoxCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLogInterval)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRSSIInterval)).BeginInit();
            this.groupGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.portsComboBox,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1266, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabel1.Text = "COM:";
            // 
            // portsComboBox
            // 
            this.portsComboBox.Name = "portsComboBox";
            this.portsComboBox.Size = new System.Drawing.Size(75, 25);
            this.portsComboBox.SelectedIndexChanged += new System.EventHandler(this.portsComboBox_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Undo";
            this.toolStripButton1.ToolTipText = "Вернуть предыдущее значение";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.detectorToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1266, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // detectorToolStripMenuItem
            // 
            this.detectorToolStripMenuItem.Name = "detectorToolStripMenuItem";
            this.detectorToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.detectorToolStripMenuItem.Text = "Detector";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // serial1
            // 
            this.serial1.StopBits = System.IO.Ports.StopBits.Two;
            this.serial1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serial1_ErrorReceived);
            this.serial1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serial1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.buttonWrite);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonRead);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(9, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 522);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Конфигурация";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxDrift);
            this.groupBox3.Controls.Add(this.textBoxChamberLo);
            this.groupBox3.Controls.Add(this.textBoxChamberHi);
            this.groupBox3.Controls.Add(this.textBoxLevelFire);
            this.groupBox3.Controls.Add(this.textBoxCRC);
            this.groupBox3.Controls.Add(this.textBoxLevelDrift);
            this.groupBox3.Controls.Add(this.textBoxLevelPrefire);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxLevelBAT);
            this.groupBox3.Controls.Add(this.textBoxFireHist);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxLevelNorm);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxCalibrTimer);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(6, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 316);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры";
            // 
            // checkBoxDrift
            // 
            this.checkBoxDrift.AutoSize = true;
            this.checkBoxDrift.Location = new System.Drawing.Point(245, 48);
            this.checkBoxDrift.Name = "checkBoxDrift";
            this.checkBoxDrift.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDrift.TabIndex = 7;
            this.checkBoxDrift.UseVisualStyleBackColor = true;
            this.checkBoxDrift.CheckedChanged += new System.EventHandler(this.textBoxLevelNorm_TextChanged);
            // 
            // textBoxChamberLo
            // 
            this.textBoxChamberLo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChamberLo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxChamberLo.Location = new System.Drawing.Point(224, 205);
            this.textBoxChamberLo.Name = "textBoxChamberLo";
            this.textBoxChamberLo.Size = new System.Drawing.Size(57, 22);
            this.textBoxChamberLo.TabIndex = 11;
            this.textBoxChamberLo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxChamberLo.TextChanged += new System.EventHandler(this.textBoxLevelNorm_TextChanged_1);
            // 
            // textBoxChamberHi
            // 
            this.textBoxChamberHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChamberHi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxChamberHi.Location = new System.Drawing.Point(224, 232);
            this.textBoxChamberHi.Name = "textBoxChamberHi";
            this.textBoxChamberHi.Size = new System.Drawing.Size(57, 22);
            this.textBoxChamberHi.TabIndex = 12;
            this.textBoxChamberHi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxChamberHi.TextChanged += new System.EventHandler(this.textBoxLevelNorm_TextChanged_1);
            // 
            // textBoxLevelFire
            // 
            this.textBoxLevelFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLevelFire.ForeColor = System.Drawing.Color.DarkRed;
            this.textBoxLevelFire.Location = new System.Drawing.Point(224, 124);
            this.textBoxLevelFire.Name = "textBoxLevelFire";
            this.textBoxLevelFire.Size = new System.Drawing.Size(57, 22);
            this.textBoxLevelFire.TabIndex = 5;
            this.textBoxLevelFire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLevelFire.TextChanged += new System.EventHandler(this.textBoxLevelFire_TextChanged);
            this.textBoxLevelFire.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLevelFire_KeyDown);
            // 
            // textBoxCRC
            // 
            this.textBoxCRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCRC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxCRC.Location = new System.Drawing.Point(224, 286);
            this.textBoxCRC.Name = "textBoxCRC";
            this.textBoxCRC.ReadOnly = true;
            this.textBoxCRC.Size = new System.Drawing.Size(57, 22);
            this.textBoxCRC.TabIndex = 6;
            this.textBoxCRC.TabStop = false;
            this.textBoxCRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLevelDrift
            // 
            this.textBoxLevelDrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLevelDrift.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxLevelDrift.Location = new System.Drawing.Point(224, 178);
            this.textBoxLevelDrift.Name = "textBoxLevelDrift";
            this.textBoxLevelDrift.Size = new System.Drawing.Size(57, 22);
            this.textBoxLevelDrift.TabIndex = 10;
            this.textBoxLevelDrift.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLevelDrift.TextChanged += new System.EventHandler(this.textBoxLevelNorm_TextChanged_1);
            // 
            // textBoxLevelPrefire
            // 
            this.textBoxLevelPrefire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLevelPrefire.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxLevelPrefire.Location = new System.Drawing.Point(224, 97);
            this.textBoxLevelPrefire.Name = "textBoxLevelPrefire";
            this.textBoxLevelPrefire.Size = new System.Drawing.Size(57, 22);
            this.textBoxLevelPrefire.TabIndex = 7;
            this.textBoxLevelPrefire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLevelPrefire.TextChanged += new System.EventHandler(this.textBoxLevelNorm_TextChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(10, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Нижн. порог, инкр.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(10, 289);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 15);
            this.label14.TabIndex = 5;
            this.label14.Text = "Контрольная сумма памяти";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(10, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Предельн. уровень компенс., инкр.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(10, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 15);
            this.label13.TabIndex = 5;
            this.label13.Text = "Верхн. порог, инкр.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(10, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Порог ПОЖАРА (0,10dB/m)";
            // 
            // textBoxLevelBAT
            // 
            this.textBoxLevelBAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLevelBAT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxLevelBAT.Location = new System.Drawing.Point(224, 259);
            this.textBoxLevelBAT.Name = "textBoxLevelBAT";
            this.textBoxLevelBAT.Size = new System.Drawing.Size(57, 22);
            this.textBoxLevelBAT.TabIndex = 13;
            this.textBoxLevelBAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLevelBAT.TextChanged += new System.EventHandler(this.textBoxLevelNorm_TextChanged_1);
            // 
            // textBoxFireHist
            // 
            this.textBoxFireHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFireHist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxFireHist.Location = new System.Drawing.Point(224, 151);
            this.textBoxFireHist.Name = "textBoxFireHist";
            this.textBoxFireHist.Size = new System.Drawing.Size(57, 22);
            this.textBoxFireHist.TabIndex = 9;
            this.textBoxFireHist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFireHist.TextChanged += new System.EventHandler(this.textBoxLevelNorm_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(10, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Уровень предпожара, инкр.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(10, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Порог разряда, В";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(10, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Гистерезис, инкр.";
            // 
            // textBoxLevelNorm
            // 
            this.textBoxLevelNorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLevelNorm.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBoxLevelNorm.Location = new System.Drawing.Point(224, 70);
            this.textBoxLevelNorm.Name = "textBoxLevelNorm";
            this.textBoxLevelNorm.Size = new System.Drawing.Size(57, 22);
            this.textBoxLevelNorm.TabIndex = 6;
            this.textBoxLevelNorm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLevelNorm.TextChanged += new System.EventHandler(this.textBoxLevelNorm_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(10, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Уровень сигнала нормы, инкр.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(10, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Компенсация дрейфа";
            // 
            // textBoxCalibrTimer
            // 
            this.textBoxCalibrTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCalibrTimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxCalibrTimer.Location = new System.Drawing.Point(224, 18);
            this.textBoxCalibrTimer.Name = "textBoxCalibrTimer";
            this.textBoxCalibrTimer.ReadOnly = true;
            this.textBoxCalibrTimer.Size = new System.Drawing.Size(57, 22);
            this.textBoxCalibrTimer.TabIndex = 6;
            this.textBoxCalibrTimer.TabStop = false;
            this.textBoxCalibrTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(10, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Калибров. значение LP таймера";
            // 
            // buttonWrite
            // 
            this.buttonWrite.Enabled = false;
            this.buttonWrite.Location = new System.Drawing.Point(203, 484);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(84, 27);
            this.buttonWrite.TabIndex = 5;
            this.buttonWrite.Text = "Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxAbout);
            this.groupBox2.Controls.Add(this.textBoxSerial);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxDateProd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxVersion);
            this.groupBox2.Controls.Add(this.label48);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 127);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация об устройстве";
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAbout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxAbout.Location = new System.Drawing.Point(85, 18);
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.ReadOnly = true;
            this.textBoxAbout.Size = new System.Drawing.Size(196, 21);
            this.textBoxAbout.TabIndex = 7;
            this.textBoxAbout.TabStop = false;
            this.textBoxAbout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSerial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxSerial.Location = new System.Drawing.Point(215, 97);
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.ReadOnly = true;
            this.textBoxSerial.Size = new System.Drawing.Size(66, 22);
            this.textBoxSerial.TabIndex = 6;
            this.textBoxSerial.TabStop = false;
            this.textBoxSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Серийный номер";
            // 
            // textBoxDateProd
            // 
            this.textBoxDateProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDateProd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxDateProd.Location = new System.Drawing.Point(215, 71);
            this.textBoxDateProd.Name = "textBoxDateProd";
            this.textBoxDateProd.ReadOnly = true;
            this.textBoxDateProd.Size = new System.Drawing.Size(66, 22);
            this.textBoxDateProd.TabIndex = 6;
            this.textBoxDateProd.TabStop = false;
            this.textBoxDateProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата производства";
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVersion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxVersion.Location = new System.Drawing.Point(215, 45);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.ReadOnly = true;
            this.textBoxVersion.Size = new System.Drawing.Size(66, 22);
            this.textBoxVersion.TabIndex = 6;
            this.textBoxVersion.TabStop = false;
            this.textBoxVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label48.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label48.Location = new System.Drawing.Point(10, 20);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(64, 15);
            this.label48.TabIndex = 5;
            this.label48.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Версия";
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(91, 484);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(84, 27);
            this.buttonRead.TabIndex = 5;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // dataGridProp
            // 
            this.dataGridProp.AllowUserToAddRows = false;
            this.dataGridProp.AllowUserToDeleteRows = false;
            this.dataGridProp.AllowUserToResizeColumns = false;
            this.dataGridProp.AllowUserToResizeRows = false;
            this.dataGridProp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridProp.ColumnHeadersHeight = 24;
            this.dataGridProp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridProp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNumber,
            this.PropName,
            this.PropValue});
            this.dataGridProp.EnableHeadersVisualStyles = false;
            this.dataGridProp.Location = new System.Drawing.Point(622, 606);
            this.dataGridProp.MultiSelect = false;
            this.dataGridProp.Name = "dataGridProp";
            this.dataGridProp.RowHeadersVisible = false;
            this.dataGridProp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridProp.RowTemplate.Height = 24;
            this.dataGridProp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridProp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridProp.ShowCellErrors = false;
            this.dataGridProp.ShowEditingIcon = false;
            this.dataGridProp.ShowRowErrors = false;
            this.dataGridProp.Size = new System.Drawing.Size(353, 75);
            this.dataGridProp.TabIndex = 4;
            this.dataGridProp.Visible = false;
            // 
            // ColNumber
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColNumber.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColNumber.Frozen = true;
            this.ColNumber.HeaderText = "№";
            this.ColNumber.Name = "ColNumber";
            this.ColNumber.ReadOnly = true;
            this.ColNumber.Width = 25;
            // 
            // PropName
            // 
            this.PropName.Frozen = true;
            this.PropName.HeaderText = "                 Наименование";
            this.PropName.Name = "PropName";
            this.PropName.ReadOnly = true;
            this.PropName.Width = 250;
            // 
            // PropValue
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.PropValue.DefaultCellStyle = dataGridViewCellStyle2;
            this.PropValue.HeaderText = "Значение";
            this.PropValue.Name = "PropValue";
            this.PropValue.Width = 77;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Controls.Add(this.buttonDiagnostic);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox6.Location = new System.Drawing.Point(325, 58);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(524, 380);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Диагностика";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Controls.Add(this.textBoxVCC_NO);
            this.groupBox5.Controls.Add(this.textBoxVCC);
            this.groupBox5.Controls.Add(this.textBoxDHV);
            this.groupBox5.Controls.Add(this.textBoxDark);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.textBoxTemperature);
            this.groupBox5.Controls.Add(this.textBoxLHV);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.textBoxDriftFactor);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.textBoxHV);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.textBoxDelta);
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox5.Location = new System.Drawing.Point(244, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 350);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Текущие значения переменных";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelRbat);
            this.panel1.Location = new System.Drawing.Point(6, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 25);
            this.panel1.TabIndex = 7;
            // 
            // labelRbat
            // 
            this.labelRbat.AutoSize = true;
            this.labelRbat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRbat.ForeColor = System.Drawing.Color.Navy;
            this.labelRbat.Location = new System.Drawing.Point(3, 2);
            this.labelRbat.Name = "labelRbat";
            this.labelRbat.Size = new System.Drawing.Size(0, 18);
            this.labelRbat.TabIndex = 5;
            // 
            // textBoxVCC_NO
            // 
            this.textBoxVCC_NO.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxVCC_NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVCC_NO.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxVCC_NO.Location = new System.Drawing.Point(212, 114);
            this.textBoxVCC_NO.Name = "textBoxVCC_NO";
            this.textBoxVCC_NO.ReadOnly = true;
            this.textBoxVCC_NO.Size = new System.Drawing.Size(51, 22);
            this.textBoxVCC_NO.TabIndex = 6;
            // 
            // textBoxVCC
            // 
            this.textBoxVCC.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxVCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVCC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxVCC.Location = new System.Drawing.Point(212, 142);
            this.textBoxVCC.Name = "textBoxVCC";
            this.textBoxVCC.ReadOnly = true;
            this.textBoxVCC.Size = new System.Drawing.Size(51, 22);
            this.textBoxVCC.TabIndex = 6;
            // 
            // textBoxDHV
            // 
            this.textBoxDHV.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxDHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDHV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxDHV.Location = new System.Drawing.Point(212, 199);
            this.textBoxDHV.Name = "textBoxDHV";
            this.textBoxDHV.ReadOnly = true;
            this.textBoxDHV.Size = new System.Drawing.Size(51, 22);
            this.textBoxDHV.TabIndex = 6;
            // 
            // textBoxDark
            // 
            this.textBoxDark.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxDark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDark.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxDark.Location = new System.Drawing.Point(212, 58);
            this.textBoxDark.Name = "textBoxDark";
            this.textBoxDark.ReadOnly = true;
            this.textBoxDark.Size = new System.Drawing.Size(51, 22);
            this.textBoxDark.TabIndex = 6;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label30.Location = new System.Drawing.Point(8, 144);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(204, 15);
            this.label30.TabIndex = 5;
            this.label30.Text = "Напряжение ВАТ под нагрузкой, В";
            // 
            // textBoxTemperature
            // 
            this.textBoxTemperature.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTemperature.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxTemperature.Location = new System.Drawing.Point(212, 296);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.ReadOnly = true;
            this.textBoxTemperature.Size = new System.Drawing.Size(51, 22);
            this.textBoxTemperature.TabIndex = 6;
            // 
            // textBoxLHV
            // 
            this.textBoxLHV.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxLHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLHV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxLHV.Location = new System.Drawing.Point(212, 227);
            this.textBoxLHV.Name = "textBoxLHV";
            this.textBoxLHV.ReadOnly = true;
            this.textBoxLHV.Size = new System.Drawing.Size(51, 22);
            this.textBoxLHV.TabIndex = 6;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label27.Location = new System.Drawing.Point(8, 116);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(120, 15);
            this.label27.TabIndex = 5;
            this.label27.Text = "Напряжение ВАТ, В";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label29.Location = new System.Drawing.Point(8, 202);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(200, 15);
            this.label29.TabIndex = 5;
            this.label29.Text = "Δ HV при разряде через IR LED, В";
            // 
            // textBoxDriftFactor
            // 
            this.textBoxDriftFactor.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxDriftFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDriftFactor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxDriftFactor.Location = new System.Drawing.Point(212, 86);
            this.textBoxDriftFactor.Name = "textBoxDriftFactor";
            this.textBoxDriftFactor.ReadOnly = true;
            this.textBoxDriftFactor.Size = new System.Drawing.Size(51, 22);
            this.textBoxDriftFactor.TabIndex = 6;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label31.Location = new System.Drawing.Point(8, 299);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(166, 15);
            this.label31.TabIndex = 5;
            this.label31.Text = "Температура кристалла, ºС";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label28.Location = new System.Drawing.Point(8, 230);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(186, 15);
            this.label28.TabIndex = 5;
            this.label28.Text = "Δ HV саморазряда (t=500ms), В";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label33.Location = new System.Drawing.Point(8, 61);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(195, 15);
            this.label33.TabIndex = 5;
            this.label33.Text = "Уровень \'0\' на вых. усилителя, В";
            // 
            // textBoxHV
            // 
            this.textBoxHV.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxHV.Location = new System.Drawing.Point(212, 170);
            this.textBoxHV.Name = "textBoxHV";
            this.textBoxHV.ReadOnly = true;
            this.textBoxHV.Size = new System.Drawing.Size(51, 22);
            this.textBoxHV.TabIndex = 6;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label25.Location = new System.Drawing.Point(8, 89);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(134, 15);
            this.label25.TabIndex = 5;
            this.label25.Text = "Фактор дрейфа, инкр";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label26.Location = new System.Drawing.Point(8, 173);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(114, 15);
            this.label26.TabIndex = 5;
            this.label26.Text = "Напряжение HV, В";
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDelta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxDelta.Location = new System.Drawing.Point(212, 30);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.ReadOnly = true;
            this.textBoxDelta.Size = new System.Drawing.Size(51, 22);
            this.textBoxDelta.TabIndex = 6;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label35.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label35.Location = new System.Drawing.Point(8, 33);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(142, 15);
            this.label35.TabIndex = 5;
            this.label35.Text = "Уровень сигнала, инкр.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panelFault);
            this.groupBox4.Controls.Add(this.checkBoxFaultIRLed);
            this.groupBox4.Controls.Add(this.checkBoxFaultSWReset);
            this.groupBox4.Controls.Add(this.checkBoxFaultTimer);
            this.groupBox4.Controls.Add(this.checkBoxFaultConfig);
            this.groupBox4.Controls.Add(this.checkBoxFaultLeakage);
            this.groupBox4.Controls.Add(this.checkBoxFaultSystem);
            this.groupBox4.Controls.Add(this.checkBoxFaultAMP);
            this.groupBox4.Controls.Add(this.checkBoxFaultChamber);
            this.groupBox4.Controls.Add(this.checkBoxFaultCAP);
            this.groupBox4.Controls.Add(this.checkBoxFaultDrift);
            this.groupBox4.Controls.Add(this.checkBoxFaultBOOST);
            this.groupBox4.Controls.Add(this.checkBoxFaultBAT);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(6, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(234, 314);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Неисправности";
            // 
            // panelFault
            // 
            this.panelFault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelFault.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFault.Location = new System.Drawing.Point(30, 20);
            this.panelFault.Name = "panelFault";
            this.panelFault.Size = new System.Drawing.Size(173, 8);
            this.panelFault.TabIndex = 8;
            // 
            // checkBoxFaultIRLed
            // 
            this.checkBoxFaultIRLed.AutoCheck = false;
            this.checkBoxFaultIRLed.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxFaultIRLed.Location = new System.Drawing.Point(212, 223);
            this.checkBoxFaultIRLed.Name = "checkBoxFaultIRLed";
            this.checkBoxFaultIRLed.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFaultIRLed.TabIndex = 7;
            this.checkBoxFaultIRLed.UseVisualStyleBackColor = true;
            // 
            // checkBoxFaultSWReset
            // 
            this.checkBoxFaultSWReset.AutoCheck = false;
            this.checkBoxFaultSWReset.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxFaultSWReset.Location = new System.Drawing.Point(212, 291);
            this.checkBoxFaultSWReset.Name = "checkBoxFaultSWReset";
            this.checkBoxFaultSWReset.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFaultSWReset.TabIndex = 7;
            this.checkBoxFaultSWReset.UseVisualStyleBackColor = true;
            // 
            // checkBoxFaultTimer
            // 
            this.checkBoxFaultTimer.AutoCheck = false;
            this.checkBoxFaultTimer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxFaultTimer.Location = new System.Drawing.Point(212, 269);
            this.checkBoxFaultTimer.Name = "checkBoxFaultTimer";
            this.checkBoxFaultTimer.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFaultTimer.TabIndex = 7;
            this.checkBoxFaultTimer.UseVisualStyleBackColor = true;
            // 
            // checkBoxFaultConfig
            // 
            this.checkBoxFaultConfig.AutoCheck = false;
            this.checkBoxFaultConfig.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxFaultConfig.Location = new System.Drawing.Point(212, 246);
            this.checkBoxFaultConfig.Name = "checkBoxFaultConfig";
            this.checkBoxFaultConfig.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFaultConfig.TabIndex = 7;
            this.checkBoxFaultConfig.UseVisualStyleBackColor = true;
            // 
            // checkBoxFaultLeakage
            // 
            this.checkBoxFaultLeakage.AutoCheck = false;
            this.checkBoxFaultLeakage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxFaultLeakage.Location = new System.Drawing.Point(212, 200);
            this.checkBoxFaultLeakage.Name = "checkBoxFaultLeakage";
            this.checkBoxFaultLeakage.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFaultLeakage.TabIndex = 7;
            this.checkBoxFaultLeakage.UseVisualStyleBackColor = true;
            // 
            // checkBoxFaultSystem
            // 
            this.checkBoxFaultSystem.AutoCheck = false;
            this.checkBoxFaultSystem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxFaultSystem.Location = new System.Drawing.Point(212, 108);
            this.checkBoxFaultSystem.Name = "checkBoxFaultSystem";
            this.checkBoxFaultSystem.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFaultSystem.TabIndex = 7;
            this.checkBoxFaultSystem.UseVisualStyleBackColor = true;
            // 
            // checkBoxFaultAMP
            // 
            this.checkBoxFaultAMP.AutoCheck = false;
            this.checkBoxFaultAMP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxFaultAMP.Location = new System.Drawing.Point(212, 154);
            this.checkBoxFaultAMP.Name = "checkBoxFaultAMP";
            this.checkBoxFaultAMP.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFaultAMP.TabIndex = 7;
            this.checkBoxFaultAMP.UseVisualStyleBackColor = true;
            // 
            // checkBoxFaultChamber
            // 
            this.checkBoxFaultChamber.AutoCheck = false;
            this.checkBoxFaultChamber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxFaultChamber.Location = new System.Drawing.Point(212, 60);
            this.checkBoxFaultChamber.Name = "checkBoxFaultChamber";
            this.checkBoxFaultChamber.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFaultChamber.TabIndex = 7;
            this.checkBoxFaultChamber.UseVisualStyleBackColor = true;
            // 
            // checkBoxFaultCAP
            // 
            this.checkBoxFaultCAP.AutoCheck = false;
            this.checkBoxFaultCAP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxFaultCAP.Location = new System.Drawing.Point(212, 177);
            this.checkBoxFaultCAP.Name = "checkBoxFaultCAP";
            this.checkBoxFaultCAP.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFaultCAP.TabIndex = 7;
            this.checkBoxFaultCAP.UseVisualStyleBackColor = true;
            // 
            // checkBoxFaultDrift
            // 
            this.checkBoxFaultDrift.AutoCheck = false;
            this.checkBoxFaultDrift.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxFaultDrift.Location = new System.Drawing.Point(212, 84);
            this.checkBoxFaultDrift.Name = "checkBoxFaultDrift";
            this.checkBoxFaultDrift.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFaultDrift.TabIndex = 7;
            this.checkBoxFaultDrift.UseVisualStyleBackColor = true;
            // 
            // checkBoxFaultBOOST
            // 
            this.checkBoxFaultBOOST.AutoCheck = false;
            this.checkBoxFaultBOOST.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxFaultBOOST.Location = new System.Drawing.Point(212, 130);
            this.checkBoxFaultBOOST.Name = "checkBoxFaultBOOST";
            this.checkBoxFaultBOOST.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFaultBOOST.TabIndex = 7;
            this.checkBoxFaultBOOST.UseVisualStyleBackColor = true;
            // 
            // checkBoxFaultBAT
            // 
            this.checkBoxFaultBAT.AutoCheck = false;
            this.checkBoxFaultBAT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxFaultBAT.Location = new System.Drawing.Point(212, 36);
            this.checkBoxFaultBAT.Name = "checkBoxFaultBAT";
            this.checkBoxFaultBAT.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFaultBAT.TabIndex = 7;
            this.checkBoxFaultBAT.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label23.Location = new System.Drawing.Point(6, 221);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(137, 15);
            this.label23.TabIndex = 5;
            this.label23.Text = "Неисправность IR Led";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label34.Location = new System.Drawing.Point(6, 289);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(175, 15);
            this.label34.TabIndex = 5;
            this.label34.Text = "Был выполнен сброс по WDT";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label32.Location = new System.Drawing.Point(6, 267);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(195, 15);
            this.label32.TabIndex = 5;
            this.label32.Text = "Ошибка калибровки LP таймера";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(6, 244);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(191, 15);
            this.label22.TabIndex = 5;
            this.label22.Text = "Ошибка в конфигурации(+ CRC)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(6, 198);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(168, 15);
            this.label21.TabIndex = 5;
            this.label21.Text = "Повышенный ток утечек HV";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(6, 106);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 15);
            this.label17.TabIndex = 5;
            this.label17.Text = "Системная ошибка";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(6, 175);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(202, 15);
            this.label20.TabIndex = 5;
            this.label20.Text = "Неисправность эл. конденсатора";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(6, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(195, 15);
            this.label16.TabIndex = 5;
            this.label16.Text = "Превышение уровня компенсац.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(6, 152);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(161, 15);
            this.label19.TabIndex = 5;
            this.label19.Text = "Неисправность усилителя";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(6, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 15);
            this.label18.TabIndex = 5;
            this.label18.Text = "Неисправность BOOST";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(6, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 15);
            this.label15.TabIndex = 5;
            this.label15.Text = "Неисправность камеры";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label24.Location = new System.Drawing.Point(6, 34);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(123, 15);
            this.label24.TabIndex = 5;
            this.label24.Text = "Неисправность BAT";
            // 
            // buttonDiagnostic
            // 
            this.buttonDiagnostic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDiagnostic.Location = new System.Drawing.Point(20, 340);
            this.buttonDiagnostic.Name = "buttonDiagnostic";
            this.buttonDiagnostic.Size = new System.Drawing.Size(205, 30);
            this.buttonDiagnostic.TabIndex = 7;
            this.buttonDiagnostic.Text = "Диагностика";
            this.buttonDiagnostic.UseVisualStyleBackColor = true;
            this.buttonDiagnostic.Click += new System.EventHandler(this.buttonDiagnostic_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.buttonClearLog);
            this.groupBox7.Controls.Add(this.textBoxLog);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox7.Location = new System.Drawing.Point(861, 58);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(114, 522);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Журнал ОП";
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.Location = new System.Drawing.Point(6, 493);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(71, 23);
            this.buttonClearLog.TabIndex = 2;
            this.buttonClearLog.Text = "Clear";
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.buttonClearLog_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLog.Location = new System.Drawing.Point(6, 20);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(102, 467);
            this.textBoxLog.TabIndex = 1;
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // buttonFaultsReset
            // 
            this.buttonFaultsReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFaultsReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonFaultsReset.Location = new System.Drawing.Point(15, 20);
            this.buttonFaultsReset.Name = "buttonFaultsReset";
            this.buttonFaultsReset.Size = new System.Drawing.Size(210, 30);
            this.buttonFaultsReset.TabIndex = 7;
            this.buttonFaultsReset.Text = "HW Reset";
            this.buttonFaultsReset.UseVisualStyleBackColor = true;
            this.buttonFaultsReset.Click += new System.EventHandler(this.buttonFaultsReset_Click);
            // 
            // groupBoxCommand
            // 
            this.groupBoxCommand.Controls.Add(this.buttonSet00dB);
            this.groupBoxCommand.Controls.Add(this.label37);
            this.groupBoxCommand.Controls.Add(this.buttonCalibration);
            this.groupBoxCommand.Controls.Add(this.buttonFaultsReset);
            this.groupBoxCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCommand.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxCommand.Location = new System.Drawing.Point(325, 444);
            this.groupBoxCommand.Name = "groupBoxCommand";
            this.groupBoxCommand.Size = new System.Drawing.Size(240, 138);
            this.groupBoxCommand.TabIndex = 6;
            this.groupBoxCommand.TabStop = false;
            this.groupBoxCommand.Text = "Команды";
            // 
            // buttonSet00dB
            // 
            this.buttonSet00dB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSet00dB.Location = new System.Drawing.Point(15, 59);
            this.buttonSet00dB.Name = "buttonSet00dB";
            this.buttonSet00dB.Size = new System.Drawing.Size(210, 30);
            this.buttonSet00dB.TabIndex = 7;
            this.buttonSet00dB.Text = "Запомнить фон (0 dB/m)";
            this.buttonSet00dB.UseVisualStyleBackColor = true;
            this.buttonSet00dB.Click += new System.EventHandler(this.buttonSet00dB_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label37.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label37.Location = new System.Drawing.Point(457, 72);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(53, 17);
            this.label37.TabIndex = 8;
            this.label37.Text = "00001";
            this.label37.Visible = false;
            // 
            // buttonCalibration
            // 
            this.buttonCalibration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCalibration.Location = new System.Drawing.Point(15, 97);
            this.buttonCalibration.Name = "buttonCalibration";
            this.buttonCalibration.Size = new System.Drawing.Size(210, 30);
            this.buttonCalibration.TabIndex = 7;
            this.buttonCalibration.Text = "Калибровка (0.10 dB/m)";
            this.buttonCalibration.UseVisualStyleBackColor = true;
            this.buttonCalibration.Click += new System.EventHandler(this.buttonCalibration_Click);
            // 
            // buttonDeviceInit
            // 
            this.buttonDeviceInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeviceInit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonDeviceInit.Location = new System.Drawing.Point(361, 22);
            this.buttonDeviceInit.Name = "buttonDeviceInit";
            this.buttonDeviceInit.Size = new System.Drawing.Size(110, 27);
            this.buttonDeviceInit.TabIndex = 5;
            this.buttonDeviceInit.Text = "Device Init...";
            this.buttonDeviceInit.UseVisualStyleBackColor = true;
            this.buttonDeviceInit.Click += new System.EventHandler(this.buttonDeviceInit_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(480, 25);
            this.progressBar.MarqueeAnimationSpeed = 50;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 20);
            this.progressBar.TabIndex = 7;
            this.progressBar.Visible = false;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelText.Location = new System.Drawing.Point(588, 27);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(56, 15);
            this.labelText.TabIndex = 8;
            this.labelText.Text = " - - - - - - -";
            this.labelText.Visible = false;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label36.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label36.Location = new System.Drawing.Point(178, 28);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(106, 15);
            this.label36.TabIndex = 8;
            this.label36.Text = "Серийный номер";
            // 
            // numUpDownSN
            // 
            this.numUpDownSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDownSN.ForeColor = System.Drawing.Color.RoyalBlue;
            this.numUpDownSN.Location = new System.Drawing.Point(281, 26);
            this.numUpDownSN.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numUpDownSN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownSN.Name = "numUpDownSN";
            this.numUpDownSN.Size = new System.Drawing.Size(71, 21);
            this.numUpDownSN.TabIndex = 9;
            this.numUpDownSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDownSN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericLogInterval
            // 
            this.numericLogInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericLogInterval.ForeColor = System.Drawing.Color.RoyalBlue;
            this.numericLogInterval.Location = new System.Drawing.Point(102, 67);
            this.numericLogInterval.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericLogInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericLogInterval.Name = "numericLogInterval";
            this.numericLogInterval.Size = new System.Drawing.Size(38, 21);
            this.numericLogInterval.TabIndex = 12;
            this.numericLogInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericLogInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label38.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label38.Location = new System.Drawing.Point(6, 69);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(90, 15);
            this.label38.TabIndex = 11;
            this.label38.Text = "Интервал, сек";
            // 
            // checkBoxLog
            // 
            this.checkBoxLog.AutoSize = true;
            this.checkBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxLog.Location = new System.Drawing.Point(9, 32);
            this.checkBoxLog.Name = "checkBoxLog";
            this.checkBoxLog.Size = new System.Drawing.Size(83, 17);
            this.checkBoxLog.TabIndex = 10;
            this.checkBoxLog.Text = "Включить";
            this.checkBoxLog.UseVisualStyleBackColor = true;
            this.checkBoxLog.CheckedChanged += new System.EventHandler(this.checkBoxLog_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.panel2);
            this.groupBox8.Controls.Add(this.numericLogInterval);
            this.groupBox8.Controls.Add(this.label39);
            this.groupBox8.Controls.Add(this.label38);
            this.groupBox8.Controls.Add(this.checkBoxdBm);
            this.groupBox8.Controls.Add(this.checkBoxLog);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox8.Location = new System.Drawing.Point(571, 444);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(278, 138);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Измеритель оптической плотности";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labeldBm);
            this.panel2.Location = new System.Drawing.Point(156, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 27);
            this.panel2.TabIndex = 13;
            // 
            // labeldBm
            // 
            this.labeldBm.AutoSize = true;
            this.labeldBm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeldBm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labeldBm.Location = new System.Drawing.Point(6, 4);
            this.labeldBm.Name = "labeldBm";
            this.labeldBm.Size = new System.Drawing.Size(90, 17);
            this.labeldBm.TabIndex = 11;
            this.labeldBm.Text = "0.001 dB/m";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label39.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label39.Location = new System.Drawing.Point(457, 72);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(53, 17);
            this.label39.TabIndex = 8;
            this.label39.Text = "00001";
            this.label39.Visible = false;
            // 
            // checkBoxdBm
            // 
            this.checkBoxdBm.AutoSize = true;
            this.checkBoxdBm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxdBm.Location = new System.Drawing.Point(9, 92);
            this.checkBoxdBm.Name = "checkBoxdBm";
            this.checkBoxdBm.Size = new System.Drawing.Size(116, 17);
            this.checkBoxdBm.TabIndex = 10;
            this.checkBoxdBm.Text = "выводить в  dB/m";
            this.checkBoxdBm.UseVisualStyleBackColor = true;
            // 
            // checkBoxFireLevel
            // 
            this.checkBoxFireLevel.AutoSize = true;
            this.checkBoxFireLevel.Checked = true;
            this.checkBoxFireLevel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFireLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxFireLevel.Location = new System.Drawing.Point(15, 586);
            this.checkBoxFireLevel.Name = "checkBoxFireLevel";
            this.checkBoxFireLevel.Size = new System.Drawing.Size(341, 17);
            this.checkBoxFireLevel.TabIndex = 10;
            this.checkBoxFireLevel.Text = "При изменении порога Пожара пересчитывать другие пороги";
            this.checkBoxFireLevel.UseVisualStyleBackColor = true;
            this.checkBoxFireLevel.CheckedChanged += new System.EventHandler(this.checkBoxLog_CheckedChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.buttonChange);
            this.groupBox9.Controls.Add(this.textBoxNewFireDB);
            this.groupBox9.Controls.Add(this.textBoxNewFireLevel);
            this.groupBox9.Controls.Add(this.textBoxCurDB);
            this.groupBox9.Controls.Add(this.label41);
            this.groupBox9.Controls.Add(this.label44);
            this.groupBox9.Controls.Add(this.label43);
            this.groupBox9.Controls.Add(this.label42);
            this.groupBox9.Controls.Add(this.label40);
            this.groupBox9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox9.Location = new System.Drawing.Point(9, 609);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(555, 72);
            this.groupBox9.TabIndex = 11;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Пересчет и корректировка текущих порогов";
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChange.Location = new System.Drawing.Point(259, 41);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(84, 27);
            this.buttonChange.TabIndex = 7;
            this.buttonChange.Text = "Перенести";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBoxNewFireDB
            // 
            this.textBoxNewFireDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewFireDB.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBoxNewFireDB.Location = new System.Drawing.Point(434, 43);
            this.textBoxNewFireDB.Name = "textBoxNewFireDB";
            this.textBoxNewFireDB.Size = new System.Drawing.Size(56, 22);
            this.textBoxNewFireDB.TabIndex = 13;
            this.textBoxNewFireDB.Text = "105";
            this.textBoxNewFireDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNewFireLevel
            // 
            this.textBoxNewFireLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewFireLevel.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBoxNewFireLevel.Location = new System.Drawing.Point(187, 44);
            this.textBoxNewFireLevel.Name = "textBoxNewFireLevel";
            this.textBoxNewFireLevel.Size = new System.Drawing.Size(57, 22);
            this.textBoxNewFireLevel.TabIndex = 14;
            this.textBoxNewFireLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCurDB
            // 
            this.textBoxCurDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCurDB.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBoxCurDB.Location = new System.Drawing.Point(27, 43);
            this.textBoxCurDB.Name = "textBoxCurDB";
            this.textBoxCurDB.Size = new System.Drawing.Size(57, 22);
            this.textBoxCurDB.TabIndex = 15;
            this.textBoxCurDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCurDB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCurDB_KeyDown);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label41.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label41.Location = new System.Drawing.Point(87, 46);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(45, 15);
            this.label41.TabIndex = 8;
            this.label41.Text = "х10e-3";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label44.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label44.Location = new System.Drawing.Point(181, 22);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(176, 15);
            this.label44.TabIndex = 9;
            this.label44.Text = "Новый порог Пожара, икрем.";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label43.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label43.Location = new System.Drawing.Point(6, 22);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(156, 15);
            this.label43.TabIndex = 10;
            this.label43.Text = "Измеренная чувств. dB/m";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label42.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label42.Location = new System.Drawing.Point(390, 22);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(163, 15);
            this.label42.TabIndex = 11;
            this.label42.Text = "Необходимая чувств. dB/m";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label40.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label40.Location = new System.Drawing.Point(494, 46);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(45, 15);
            this.label40.TabIndex = 12;
            this.label40.Text = "х10e-3";
            // 
            // textBoxLevelBATNew
            // 
            this.textBoxLevelBATNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLevelBATNew.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBoxLevelBATNew.Location = new System.Drawing.Point(379, 588);
            this.textBoxLevelBATNew.Name = "textBoxLevelBATNew";
            this.textBoxLevelBATNew.Size = new System.Drawing.Size(50, 22);
            this.textBoxLevelBATNew.TabIndex = 14;
            this.textBoxLevelBATNew.Text = "2.28";
            this.textBoxLevelBATNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSetNewBATLevel
            // 
            this.buttonSetNewBATLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetNewBATLevel.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonSetNewBATLevel.Location = new System.Drawing.Point(435, 586);
            this.buttonSetNewBATLevel.Name = "buttonSetNewBATLevel";
            this.buttonSetNewBATLevel.Size = new System.Drawing.Size(131, 27);
            this.buttonSetNewBATLevel.TabIndex = 7;
            this.buttonSetNewBATLevel.Text = "Set New BATLevel";
            this.buttonSetNewBATLevel.UseVisualStyleBackColor = true;
            this.buttonSetNewBATLevel.Click += new System.EventHandler(this.buttonSetNewBATLevel_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.buttonClearRSSI);
            this.groupBox10.Controls.Add(this.panel3);
            this.groupBox10.Controls.Add(this.textBoxRSSI);
            this.groupBox10.Controls.Add(this.numericRSSIInterval);
            this.groupBox10.Controls.Add(this.label46);
            this.groupBox10.Controls.Add(this.label47);
            this.groupBox10.Controls.Add(this.checkBox1);
            this.groupBox10.Controls.Add(this.checkBoxRSSI);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox10.Location = new System.Drawing.Point(981, 58);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(270, 522);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Радиоканал";
            // 
            // buttonClearRSSI
            // 
            this.buttonClearRSSI.Location = new System.Drawing.Point(9, 493);
            this.buttonClearRSSI.Name = "buttonClearRSSI";
            this.buttonClearRSSI.Size = new System.Drawing.Size(71, 23);
            this.buttonClearRSSI.TabIndex = 2;
            this.buttonClearRSSI.Text = "Clear";
            this.buttonClearRSSI.UseVisualStyleBackColor = true;
            this.buttonClearRSSI.Click += new System.EventHandler(this.buttonClearRSSI_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label45);
            this.panel3.Location = new System.Drawing.Point(156, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(105, 27);
            this.panel3.TabIndex = 13;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label45.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label45.Location = new System.Drawing.Point(6, 4);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(90, 17);
            this.label45.TabIndex = 11;
            this.label45.Text = "0.001 dB/m";
            // 
            // textBoxRSSI
            // 
            this.textBoxRSSI.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxRSSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRSSI.Location = new System.Drawing.Point(9, 115);
            this.textBoxRSSI.Multiline = true;
            this.textBoxRSSI.Name = "textBoxRSSI";
            this.textBoxRSSI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRSSI.Size = new System.Drawing.Size(102, 372);
            this.textBoxRSSI.TabIndex = 1;
            // 
            // numericRSSIInterval
            // 
            this.numericRSSIInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericRSSIInterval.ForeColor = System.Drawing.Color.RoyalBlue;
            this.numericRSSIInterval.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericRSSIInterval.Location = new System.Drawing.Point(93, 67);
            this.numericRSSIInterval.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericRSSIInterval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericRSSIInterval.Name = "numericRSSIInterval";
            this.numericRSSIInterval.Size = new System.Drawing.Size(52, 21);
            this.numericRSSIInterval.TabIndex = 12;
            this.numericRSSIInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericRSSIInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label46.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label46.Location = new System.Drawing.Point(457, 72);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(53, 17);
            this.label46.TabIndex = 8;
            this.label46.Text = "00001";
            this.label46.Visible = false;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label47.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label47.Location = new System.Drawing.Point(6, 69);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(88, 15);
            this.label47.TabIndex = 11;
            this.label47.Text = "Интервал, ms";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(9, 92);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "выводить в  dB/m";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBoxRSSI
            // 
            this.checkBoxRSSI.AutoSize = true;
            this.checkBoxRSSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRSSI.Location = new System.Drawing.Point(9, 32);
            this.checkBoxRSSI.Name = "checkBoxRSSI";
            this.checkBoxRSSI.Size = new System.Drawing.Size(83, 17);
            this.checkBoxRSSI.TabIndex = 10;
            this.checkBoxRSSI.Text = "Включить";
            this.checkBoxRSSI.UseVisualStyleBackColor = true;
            this.checkBoxRSSI.CheckedChanged += new System.EventHandler(this.checkBoxRSSI_CheckedChanged);
            // 
            // buttonViewGraph
            // 
            this.buttonViewGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonViewGraph.Location = new System.Drawing.Point(1179, 658);
            this.buttonViewGraph.Name = "buttonViewGraph";
            this.buttonViewGraph.Size = new System.Drawing.Size(75, 23);
            this.buttonViewGraph.TabIndex = 15;
            this.buttonViewGraph.Text = "Graph";
            this.buttonViewGraph.UseVisualStyleBackColor = true;
            this.buttonViewGraph.Click += new System.EventHandler(this.buttonViewGraph_Click);
            // 
            // groupGraph
            // 
            this.groupGraph.Controls.Add(this.textBoxLevel);
            this.groupGraph.Controls.Add(this.labelPulsesMagnitude);
            this.groupGraph.Controls.Add(this.panelGraph2);
            this.groupGraph.Controls.Add(this.panelGraph1);
            this.groupGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupGraph.Location = new System.Drawing.Point(697, 31);
            this.groupGraph.Name = "groupGraph";
            this.groupGraph.Size = new System.Drawing.Size(686, 522);
            this.groupGraph.TabIndex = 16;
            this.groupGraph.TabStop = false;
            this.groupGraph.Text = "Graph of pulses";
            this.groupGraph.Visible = false;
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLevel.Location = new System.Drawing.Point(158, 575);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(63, 26);
            this.textBoxLevel.TabIndex = 20;
            // 
            // labelPulsesMagnitude
            // 
            this.labelPulsesMagnitude.AutoSize = true;
            this.labelPulsesMagnitude.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPulsesMagnitude.Location = new System.Drawing.Point(19, 579);
            this.labelPulsesMagnitude.Name = "labelPulsesMagnitude";
            this.labelPulsesMagnitude.Size = new System.Drawing.Size(129, 16);
            this.labelPulsesMagnitude.TabIndex = 19;
            this.labelPulsesMagnitude.Text = "Уровень сигнала";
            // 
            // panelGraph2
            // 
            this.panelGraph2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGraph2.Location = new System.Drawing.Point(13, 282);
            this.panelGraph2.Name = "panelGraph2";
            this.panelGraph2.Size = new System.Drawing.Size(640, 256);
            this.panelGraph2.TabIndex = 18;
            // 
            // panelGraph1
            // 
            this.panelGraph1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGraph1.Location = new System.Drawing.Point(13, 19);
            this.panelGraph1.Name = "panelGraph1";
            this.panelGraph1.Size = new System.Drawing.Size(640, 256);
            this.panelGraph1.TabIndex = 17;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 693);
            this.Controls.Add(this.groupGraph);
            this.Controls.Add(this.buttonViewGraph);
            this.Controls.Add(this.buttonSetNewBATLevel);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.textBoxLevelBATNew);
            this.Controls.Add(this.numUpDownSN);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.checkBoxFireLevel);
            this.Controls.Add(this.dataGridProp);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.buttonDeviceInit);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBoxCommand);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arton-DL1_Config (version 0.01)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProp)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBoxCommand.ResumeLayout(false);
            this.groupBoxCommand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLogInterval)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRSSIInterval)).EndInit();
            this.groupGraph.ResumeLayout(false);
            this.groupGraph.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox portsComboBox;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.IO.Ports.SerialPort serial1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxVersion;
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDateProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxDrift;
        private System.Windows.Forms.TextBox textBoxLevelNorm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCalibrTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLevelPrefire;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLevelFire;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxChamberLo;
        private System.Windows.Forms.TextBox textBoxChamberHi;
        private System.Windows.Forms.TextBox textBoxCRC;
        private System.Windows.Forms.TextBox textBoxLevelDrift;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxLevelBAT;
        private System.Windows.Forms.TextBox textBoxFireHist;
        private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxVCC_NO;
        private System.Windows.Forms.TextBox textBoxVCC;
        private System.Windows.Forms.TextBox textBoxDHV;
        private System.Windows.Forms.TextBox textBoxDark;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBoxLHV;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBoxDriftFactor;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBoxHV;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxDelta;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxFaultIRLed;
        private System.Windows.Forms.CheckBox checkBoxFaultConfig;
        private System.Windows.Forms.CheckBox checkBoxFaultLeakage;
        private System.Windows.Forms.CheckBox checkBoxFaultSystem;
        private System.Windows.Forms.CheckBox checkBoxFaultAMP;
        private System.Windows.Forms.CheckBox checkBoxFaultChamber;
        private System.Windows.Forms.CheckBox checkBoxFaultCAP;
        private System.Windows.Forms.CheckBox checkBoxFaultDrift;
        private System.Windows.Forms.CheckBox checkBoxFaultBOOST;
        private System.Windows.Forms.CheckBox checkBoxFaultBAT;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button buttonDiagnostic;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.TextBox textBoxLog;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Button buttonClearLog;
		private System.Windows.Forms.Panel panelFault;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelRbat;
		private System.Windows.Forms.Button buttonFaultsReset;
		private System.Windows.Forms.GroupBox groupBoxCommand;
		private System.Windows.Forms.Button buttonCalibration;
		private System.Windows.Forms.TextBox textBoxTemperature;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Button buttonSet00dB;
		private System.Windows.Forms.CheckBox checkBoxFaultSWReset;
		private System.Windows.Forms.CheckBox checkBoxFaultTimer;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Button buttonDeviceInit;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Label labelText;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.NumericUpDown numUpDownSN;
		private System.Windows.Forms.NumericUpDown numericLogInterval;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.CheckBox checkBoxLog;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.CheckBox checkBoxdBm;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label labeldBm;
		private System.Windows.Forms.CheckBox checkBoxFireLevel;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.Button buttonChange;
		private System.Windows.Forms.TextBox textBoxNewFireDB;
		private System.Windows.Forms.TextBox textBoxNewFireLevel;
		private System.Windows.Forms.TextBox textBoxCurDB;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.TextBox textBoxLevelBATNew;
		private System.Windows.Forms.Button buttonSetNewBATLevel;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.TextBox textBoxRSSI;
		private System.Windows.Forms.NumericUpDown numericRSSIInterval;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBoxRSSI;
		private System.Windows.Forms.Button buttonClearRSSI;
		private System.Windows.Forms.TextBox textBoxAbout;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.Button buttonViewGraph;
		private System.Windows.Forms.GroupBox groupGraph;
		private System.Windows.Forms.Panel panelGraph2;
		private System.Windows.Forms.Panel panelGraph1;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.Label labelPulsesMagnitude;
		private System.Windows.Forms.TextBox textBoxLevel;
    }
}

