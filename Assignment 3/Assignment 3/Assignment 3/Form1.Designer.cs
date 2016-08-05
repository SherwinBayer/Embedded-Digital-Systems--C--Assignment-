namespace Assignment_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.appTabs = new System.Windows.Forms.TabControl();
            this.setupTab = new System.Windows.Forms.TabPage();
            this.connectLabel = new System.Windows.Forms.Label();
            this.setupLEDBulb = new Bulb.LedBulb();
            this.connectBtn = new System.Windows.Forms.Button();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.comPortComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.digitalIOTab = new System.Windows.Forms.TabPage();
            this.sevenSegment1 = new DmitryBrant.CustomControls.SevenSegment();
            this.sevenSegment2 = new DmitryBrant.CustomControls.SevenSegment();
            this.portcCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pina7LedBulb = new Bulb.LedBulb();
            this.pina6LedBulb = new Bulb.LedBulb();
            this.pina5LedBulb = new Bulb.LedBulb();
            this.pina4LedBulb = new Bulb.LedBulb();
            this.pina3LedBulb = new Bulb.LedBulb();
            this.pina2LedBulb = new Bulb.LedBulb();
            this.pina1LedBulb = new Bulb.LedBulb();
            this.pina0LedBulb = new Bulb.LedBulb();
            this.potsTab = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.potGauge2 = new AquaControls.AquaGauge();
            this.potGauge1 = new AquaControls.AquaGauge();
            this.lightTab = new System.Windows.Forms.TabPage();
            this.lampBrightnessTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lampBrightnessScrollBar = new System.Windows.Forms.VScrollBar();
            this.lightGauge = new AquaControls.AquaGauge();
            this.tempControlTab = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tempChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.motorSpeedTextBox = new System.Windows.Forms.TextBox();
            this.actualTempTextBox = new System.Windows.Forms.TextBox();
            this.kInumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kPnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tempControlnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.appTimer = new System.Windows.Forms.Timer(this.components);
            this.appTabs.SuspendLayout();
            this.setupTab.SuspendLayout();
            this.digitalIOTab.SuspendLayout();
            this.potsTab.SuspendLayout();
            this.lightTab.SuspendLayout();
            this.tempControlTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kInumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kPnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempControlnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // appTabs
            // 
            this.appTabs.Controls.Add(this.setupTab);
            this.appTabs.Controls.Add(this.digitalIOTab);
            this.appTabs.Controls.Add(this.potsTab);
            this.appTabs.Controls.Add(this.lightTab);
            this.appTabs.Controls.Add(this.tempControlTab);
            this.appTabs.Location = new System.Drawing.Point(-1, -1);
            this.appTabs.Name = "appTabs";
            this.appTabs.SelectedIndex = 0;
            this.appTabs.Size = new System.Drawing.Size(683, 322);
            this.appTabs.TabIndex = 0;
            this.appTabs.SelectedIndexChanged += new System.EventHandler(this.appTabs_SelectedIndexChanged);
            // 
            // setupTab
            // 
            this.setupTab.Controls.Add(this.connectLabel);
            this.setupTab.Controls.Add(this.setupLEDBulb);
            this.setupTab.Controls.Add(this.connectBtn);
            this.setupTab.Controls.Add(this.baudRateComboBox);
            this.setupTab.Controls.Add(this.comPortComboBox);
            this.setupTab.Controls.Add(this.label2);
            this.setupTab.Controls.Add(this.label1);
            this.setupTab.Location = new System.Drawing.Point(4, 22);
            this.setupTab.Name = "setupTab";
            this.setupTab.Padding = new System.Windows.Forms.Padding(3);
            this.setupTab.Size = new System.Drawing.Size(675, 296);
            this.setupTab.TabIndex = 0;
            this.setupTab.Text = "Setup";
            this.setupTab.UseVisualStyleBackColor = true;
            // 
            // connectLabel
            // 
            this.connectLabel.AutoSize = true;
            this.connectLabel.Location = new System.Drawing.Point(304, 239);
            this.connectLabel.Name = "connectLabel";
            this.connectLabel.Size = new System.Drawing.Size(59, 13);
            this.connectLabel.TabIndex = 6;
            this.connectLabel.Text = "Connected";
            this.connectLabel.Visible = false;
            // 
            // setupLEDBulb
            // 
            this.setupLEDBulb.Location = new System.Drawing.Point(422, 184);
            this.setupLEDBulb.Name = "setupLEDBulb";
            this.setupLEDBulb.On = false;
            this.setupLEDBulb.Size = new System.Drawing.Size(24, 23);
            this.setupLEDBulb.TabIndex = 5;
            this.setupLEDBulb.Text = "ledBulb1";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(297, 184);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 4;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baudRateComboBox.Location = new System.Drawing.Point(297, 128);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.baudRateComboBox.TabIndex = 3;
            this.baudRateComboBox.Text = "38400";
            // 
            // comPortComboBox
            // 
            this.comPortComboBox.FormattingEnabled = true;
            this.comPortComboBox.Location = new System.Drawing.Point(297, 88);
            this.comPortComboBox.Name = "comPortComboBox";
            this.comPortComboBox.Size = new System.Drawing.Size(121, 21);
            this.comPortComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port";
            // 
            // digitalIOTab
            // 
            this.digitalIOTab.Controls.Add(this.sevenSegment1);
            this.digitalIOTab.Controls.Add(this.sevenSegment2);
            this.digitalIOTab.Controls.Add(this.portcCheckedListBox);
            this.digitalIOTab.Controls.Add(this.label12);
            this.digitalIOTab.Controls.Add(this.label11);
            this.digitalIOTab.Controls.Add(this.label10);
            this.digitalIOTab.Controls.Add(this.label9);
            this.digitalIOTab.Controls.Add(this.label8);
            this.digitalIOTab.Controls.Add(this.label7);
            this.digitalIOTab.Controls.Add(this.label6);
            this.digitalIOTab.Controls.Add(this.label5);
            this.digitalIOTab.Controls.Add(this.label4);
            this.digitalIOTab.Controls.Add(this.label3);
            this.digitalIOTab.Controls.Add(this.pina7LedBulb);
            this.digitalIOTab.Controls.Add(this.pina6LedBulb);
            this.digitalIOTab.Controls.Add(this.pina5LedBulb);
            this.digitalIOTab.Controls.Add(this.pina4LedBulb);
            this.digitalIOTab.Controls.Add(this.pina3LedBulb);
            this.digitalIOTab.Controls.Add(this.pina2LedBulb);
            this.digitalIOTab.Controls.Add(this.pina1LedBulb);
            this.digitalIOTab.Controls.Add(this.pina0LedBulb);
            this.digitalIOTab.Location = new System.Drawing.Point(4, 22);
            this.digitalIOTab.Name = "digitalIOTab";
            this.digitalIOTab.Padding = new System.Windows.Forms.Padding(3);
            this.digitalIOTab.Size = new System.Drawing.Size(675, 296);
            this.digitalIOTab.TabIndex = 1;
            this.digitalIOTab.Text = "Digital I/O";
            this.digitalIOTab.UseVisualStyleBackColor = true;
            // 
            // sevenSegment1
            // 
            this.sevenSegment1.ColorBackground = System.Drawing.Color.DarkGray;
            this.sevenSegment1.ColorDark = System.Drawing.Color.DimGray;
            this.sevenSegment1.ColorLight = System.Drawing.Color.Red;
            this.sevenSegment1.CustomPattern = 119;
            this.sevenSegment1.DecimalOn = false;
            this.sevenSegment1.DecimalShow = true;
            this.sevenSegment1.ElementWidth = 10;
            this.sevenSegment1.ItalicFactor = 0F;
            this.sevenSegment1.Location = new System.Drawing.Point(533, 49);
            this.sevenSegment1.Name = "sevenSegment1";
            this.sevenSegment1.Padding = new System.Windows.Forms.Padding(4);
            this.sevenSegment1.Size = new System.Drawing.Size(45, 71);
            this.sevenSegment1.TabIndex = 20;
            this.sevenSegment1.TabStop = false;
            this.sevenSegment1.Value = "0";
            // 
            // sevenSegment2
            // 
            this.sevenSegment2.ColorBackground = System.Drawing.Color.DarkGray;
            this.sevenSegment2.ColorDark = System.Drawing.Color.DimGray;
            this.sevenSegment2.ColorLight = System.Drawing.Color.Red;
            this.sevenSegment2.Cursor = System.Windows.Forms.Cursors.Default;
            this.sevenSegment2.CustomPattern = 119;
            this.sevenSegment2.DecimalOn = false;
            this.sevenSegment2.DecimalShow = true;
            this.sevenSegment2.ElementWidth = 10;
            this.sevenSegment2.ItalicFactor = 0F;
            this.sevenSegment2.Location = new System.Drawing.Point(482, 49);
            this.sevenSegment2.Name = "sevenSegment2";
            this.sevenSegment2.Padding = new System.Windows.Forms.Padding(4);
            this.sevenSegment2.Size = new System.Drawing.Size(45, 71);
            this.sevenSegment2.TabIndex = 19;
            this.sevenSegment2.TabStop = false;
            this.sevenSegment2.Value = "0";
            // 
            // portcCheckedListBox
            // 
            this.portcCheckedListBox.CheckOnClick = true;
            this.portcCheckedListBox.FormattingEnabled = true;
            this.portcCheckedListBox.Items.AddRange(new object[] {
            "PC0",
            "PC1",
            "PC2",
            "PC3",
            "PC4",
            "PC5",
            "PC6",
            "PC7"});
            this.portcCheckedListBox.Location = new System.Drawing.Point(406, 49);
            this.portcCheckedListBox.Name = "portcCheckedListBox";
            this.portcCheckedListBox.Size = new System.Drawing.Size(46, 124);
            this.portcCheckedListBox.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(186, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "PA7";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "PA6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "PA5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "PA4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "PA3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "PA2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "PA1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "PA0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "PORTC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "PINA";
            // 
            // pina7LedBulb
            // 
            this.pina7LedBulb.Location = new System.Drawing.Point(156, 252);
            this.pina7LedBulb.Name = "pina7LedBulb";
            this.pina7LedBulb.On = false;
            this.pina7LedBulb.Size = new System.Drawing.Size(24, 23);
            this.pina7LedBulb.TabIndex = 9;
            this.pina7LedBulb.Text = "ledBulb8";
            // 
            // pina6LedBulb
            // 
            this.pina6LedBulb.Location = new System.Drawing.Point(156, 223);
            this.pina6LedBulb.Name = "pina6LedBulb";
            this.pina6LedBulb.On = false;
            this.pina6LedBulb.Size = new System.Drawing.Size(24, 23);
            this.pina6LedBulb.TabIndex = 8;
            this.pina6LedBulb.Text = "ledBulb7";
            // 
            // pina5LedBulb
            // 
            this.pina5LedBulb.Location = new System.Drawing.Point(156, 194);
            this.pina5LedBulb.Name = "pina5LedBulb";
            this.pina5LedBulb.On = false;
            this.pina5LedBulb.Size = new System.Drawing.Size(24, 23);
            this.pina5LedBulb.TabIndex = 7;
            this.pina5LedBulb.Text = "ledBulb6";
            // 
            // pina4LedBulb
            // 
            this.pina4LedBulb.Location = new System.Drawing.Point(156, 165);
            this.pina4LedBulb.Name = "pina4LedBulb";
            this.pina4LedBulb.On = false;
            this.pina4LedBulb.Size = new System.Drawing.Size(24, 23);
            this.pina4LedBulb.TabIndex = 6;
            this.pina4LedBulb.Text = "ledBulb5";
            // 
            // pina3LedBulb
            // 
            this.pina3LedBulb.Location = new System.Drawing.Point(156, 136);
            this.pina3LedBulb.Name = "pina3LedBulb";
            this.pina3LedBulb.On = false;
            this.pina3LedBulb.Size = new System.Drawing.Size(24, 23);
            this.pina3LedBulb.TabIndex = 5;
            this.pina3LedBulb.Text = "ledBulb4";
            // 
            // pina2LedBulb
            // 
            this.pina2LedBulb.Location = new System.Drawing.Point(156, 107);
            this.pina2LedBulb.Name = "pina2LedBulb";
            this.pina2LedBulb.On = false;
            this.pina2LedBulb.Size = new System.Drawing.Size(24, 23);
            this.pina2LedBulb.TabIndex = 4;
            this.pina2LedBulb.Text = "ledBulb3";
            // 
            // pina1LedBulb
            // 
            this.pina1LedBulb.Location = new System.Drawing.Point(156, 78);
            this.pina1LedBulb.Name = "pina1LedBulb";
            this.pina1LedBulb.On = false;
            this.pina1LedBulb.Size = new System.Drawing.Size(24, 23);
            this.pina1LedBulb.TabIndex = 3;
            this.pina1LedBulb.Text = "ledBulb2";
            // 
            // pina0LedBulb
            // 
            this.pina0LedBulb.Location = new System.Drawing.Point(156, 49);
            this.pina0LedBulb.Name = "pina0LedBulb";
            this.pina0LedBulb.On = false;
            this.pina0LedBulb.Size = new System.Drawing.Size(24, 23);
            this.pina0LedBulb.TabIndex = 2;
            this.pina0LedBulb.Text = "ledBulb1";
            // 
            // potsTab
            // 
            this.potsTab.Controls.Add(this.label14);
            this.potsTab.Controls.Add(this.label13);
            this.potsTab.Controls.Add(this.potGauge2);
            this.potsTab.Controls.Add(this.potGauge1);
            this.potsTab.Location = new System.Drawing.Point(4, 22);
            this.potsTab.Name = "potsTab";
            this.potsTab.Size = new System.Drawing.Size(675, 296);
            this.potsTab.TabIndex = 2;
            this.potsTab.Text = "Pots";
            this.potsTab.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(437, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "Pot 2 Voltage";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(138, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Pot 1 Voltage";
            // 
            // potGauge2
            // 
            this.potGauge2.BackColor = System.Drawing.Color.Transparent;
            this.potGauge2.DialColor = System.Drawing.Color.Lavender;
            this.potGauge2.DialText = null;
            this.potGauge2.Glossiness = 11.36364F;
            this.potGauge2.Location = new System.Drawing.Point(407, 81);
            this.potGauge2.MaxValue = 5F;
            this.potGauge2.MinValue = 0F;
            this.potGauge2.Name = "potGauge2";
            this.potGauge2.RecommendedValue = 0F;
            this.potGauge2.Size = new System.Drawing.Size(150, 150);
            this.potGauge2.TabIndex = 1;
            this.potGauge2.ThresholdPercent = 0F;
            this.potGauge2.Value = 0F;
            // 
            // potGauge1
            // 
            this.potGauge1.BackColor = System.Drawing.Color.Transparent;
            this.potGauge1.DialColor = System.Drawing.Color.Lavender;
            this.potGauge1.DialText = null;
            this.potGauge1.Glossiness = 11.36364F;
            this.potGauge1.Location = new System.Drawing.Point(107, 81);
            this.potGauge1.MaxValue = 5F;
            this.potGauge1.MinValue = 0F;
            this.potGauge1.Name = "potGauge1";
            this.potGauge1.RecommendedValue = 0F;
            this.potGauge1.Size = new System.Drawing.Size(150, 150);
            this.potGauge1.TabIndex = 0;
            this.potGauge1.ThresholdPercent = 0F;
            this.potGauge1.Value = 0F;
            // 
            // lightTab
            // 
            this.lightTab.Controls.Add(this.lampBrightnessTextBox);
            this.lightTab.Controls.Add(this.label15);
            this.lightTab.Controls.Add(this.lampBrightnessScrollBar);
            this.lightTab.Controls.Add(this.lightGauge);
            this.lightTab.Location = new System.Drawing.Point(4, 22);
            this.lightTab.Name = "lightTab";
            this.lightTab.Size = new System.Drawing.Size(675, 296);
            this.lightTab.TabIndex = 3;
            this.lightTab.Text = "Light";
            this.lightTab.UseVisualStyleBackColor = true;
            // 
            // lampBrightnessTextBox
            // 
            this.lampBrightnessTextBox.Location = new System.Drawing.Point(145, 241);
            this.lampBrightnessTextBox.Name = "lampBrightnessTextBox";
            this.lampBrightnessTextBox.ReadOnly = true;
            this.lampBrightnessTextBox.Size = new System.Drawing.Size(38, 20);
            this.lampBrightnessTextBox.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(60, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Lamp Brightness";
            // 
            // lampBrightnessScrollBar
            // 
            this.lampBrightnessScrollBar.LargeChange = 1;
            this.lampBrightnessScrollBar.Location = new System.Drawing.Point(99, 67);
            this.lampBrightnessScrollBar.Name = "lampBrightnessScrollBar";
            this.lampBrightnessScrollBar.Size = new System.Drawing.Size(29, 194);
            this.lampBrightnessScrollBar.TabIndex = 0;
            // 
            // lightGauge
            // 
            this.lightGauge.BackColor = System.Drawing.Color.Transparent;
            this.lightGauge.DialColor = System.Drawing.Color.Lavender;
            this.lightGauge.DialText = null;
            this.lightGauge.Glossiness = 11.36364F;
            this.lightGauge.Location = new System.Drawing.Point(410, 83);
            this.lightGauge.MaxValue = 255F;
            this.lightGauge.MinValue = 0F;
            this.lightGauge.Name = "lightGauge";
            this.lightGauge.RecommendedValue = 0F;
            this.lightGauge.Size = new System.Drawing.Size(150, 150);
            this.lightGauge.TabIndex = 1;
            this.lightGauge.ThresholdPercent = 0F;
            this.lightGauge.Value = 0F;
            // 
            // tempControlTab
            // 
            this.tempControlTab.Controls.Add(this.label22);
            this.tempControlTab.Controls.Add(this.label21);
            this.tempControlTab.Controls.Add(this.tempChart);
            this.tempControlTab.Controls.Add(this.label19);
            this.tempControlTab.Controls.Add(this.label18);
            this.tempControlTab.Controls.Add(this.label17);
            this.tempControlTab.Controls.Add(this.label16);
            this.tempControlTab.Controls.Add(this.motorSpeedTextBox);
            this.tempControlTab.Controls.Add(this.actualTempTextBox);
            this.tempControlTab.Controls.Add(this.kInumericUpDown);
            this.tempControlTab.Controls.Add(this.kPnumericUpDown);
            this.tempControlTab.Controls.Add(this.tempControlnumericUpDown);
            this.tempControlTab.Location = new System.Drawing.Point(4, 22);
            this.tempControlTab.Name = "tempControlTab";
            this.tempControlTab.Size = new System.Drawing.Size(675, 296);
            this.tempControlTab.TabIndex = 4;
            this.tempControlTab.Text = "Temp Control";
            this.tempControlTab.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(19, 165);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(18, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "Ki";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(19, 129);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "Kp";
            // 
            // tempChart
            // 
            chartArea1.AxisX.Title = "Samples [1s]";
            chartArea1.AxisY.Title = "Temperature [C]";
            chartArea1.Name = "ChartArea1";
            this.tempChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.tempChart.Legends.Add(legend1);
            this.tempChart.Location = new System.Drawing.Point(185, 0);
            this.tempChart.Name = "tempChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            series1.YValuesPerPoint = 6;
            this.tempChart.Series.Add(series1);
            this.tempChart.Size = new System.Drawing.Size(494, 300);
            this.tempChart.TabIndex = 9;
            this.tempChart.Text = "chart1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(58, 249);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Motor Speed [%]";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(58, 205);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Actual Temp [C]";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(69, 101);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "PI Tuning";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(55, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Setpoint Temp [C]";
            // 
            // motorSpeedTextBox
            // 
            this.motorSpeedTextBox.Location = new System.Drawing.Point(58, 265);
            this.motorSpeedTextBox.Name = "motorSpeedTextBox";
            this.motorSpeedTextBox.ReadOnly = true;
            this.motorSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.motorSpeedTextBox.TabIndex = 4;
            // 
            // actualTempTextBox
            // 
            this.actualTempTextBox.Location = new System.Drawing.Point(58, 221);
            this.actualTempTextBox.Name = "actualTempTextBox";
            this.actualTempTextBox.ReadOnly = true;
            this.actualTempTextBox.Size = new System.Drawing.Size(100, 20);
            this.actualTempTextBox.TabIndex = 3;
            // 
            // kInumericUpDown
            // 
            this.kInumericUpDown.DecimalPlaces = 1;
            this.kInumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.kInumericUpDown.Location = new System.Drawing.Point(58, 163);
            this.kInumericUpDown.Name = "kInumericUpDown";
            this.kInumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.kInumericUpDown.TabIndex = 2;
            // 
            // kPnumericUpDown
            // 
            this.kPnumericUpDown.DecimalPlaces = 1;
            this.kPnumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.kPnumericUpDown.Location = new System.Drawing.Point(58, 127);
            this.kPnumericUpDown.Name = "kPnumericUpDown";
            this.kPnumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.kPnumericUpDown.TabIndex = 1;
            // 
            // tempControlnumericUpDown
            // 
            this.tempControlnumericUpDown.DecimalPlaces = 1;
            this.tempControlnumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.tempControlnumericUpDown.Location = new System.Drawing.Point(58, 59);
            this.tempControlnumericUpDown.Name = "tempControlnumericUpDown";
            this.tempControlnumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.tempControlnumericUpDown.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 38400;
            // 
            // appTimer
            // 
            this.appTimer.Interval = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 318);
            this.Controls.Add(this.appTabs);
            this.Name = "Form1";
            this.Text = "AUT Application Board Control";
            this.appTabs.ResumeLayout(false);
            this.setupTab.ResumeLayout(false);
            this.setupTab.PerformLayout();
            this.digitalIOTab.ResumeLayout(false);
            this.digitalIOTab.PerformLayout();
            this.potsTab.ResumeLayout(false);
            this.potsTab.PerformLayout();
            this.lightTab.ResumeLayout(false);
            this.lightTab.PerformLayout();
            this.tempControlTab.ResumeLayout(false);
            this.tempControlTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kInumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kPnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempControlnumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl appTabs;
        private System.Windows.Forms.TabPage setupTab;
        private System.Windows.Forms.TabPage digitalIOTab;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox comPortComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectBtn;
        private Bulb.LedBulb setupLEDBulb;
        private System.Windows.Forms.Label connectLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bulb.LedBulb pina7LedBulb;
        private Bulb.LedBulb pina6LedBulb;
        private Bulb.LedBulb pina5LedBulb;
        private Bulb.LedBulb pina4LedBulb;
        private Bulb.LedBulb pina3LedBulb;
        private Bulb.LedBulb pina2LedBulb;
        private Bulb.LedBulb pina1LedBulb;
        private Bulb.LedBulb pina0LedBulb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox portcCheckedListBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private DmitryBrant.CustomControls.SevenSegment sevenSegment1;
        private DmitryBrant.CustomControls.SevenSegment sevenSegment2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabPage potsTab;
        private System.Windows.Forms.TabPage lightTab;
        private System.Windows.Forms.TabPage tempControlTab;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private AquaControls.AquaGauge potGauge2;
        private AquaControls.AquaGauge potGauge1;
        private System.Windows.Forms.Label label15;
        private AquaControls.AquaGauge lightGauge;
        private System.Windows.Forms.VScrollBar lampBrightnessScrollBar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox motorSpeedTextBox;
        private System.Windows.Forms.TextBox actualTempTextBox;
        private System.Windows.Forms.NumericUpDown kInumericUpDown;
        private System.Windows.Forms.NumericUpDown kPnumericUpDown;
        private System.Windows.Forms.NumericUpDown tempControlnumericUpDown;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataVisualization.Charting.Chart tempChart;
        private System.Windows.Forms.TextBox lampBrightnessTextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Timer appTimer;
    }
}

