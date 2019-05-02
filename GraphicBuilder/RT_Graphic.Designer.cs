namespace GraphicBuilder
{
    partial class RT_Graphic
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
            this.pnl_Settings = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chb_AutoMax = new System.Windows.Forms.CheckBox();
            this.btn_ApplyConf = new System.Windows.Forms.Button();
            this.txb_WaitTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_BaundRate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_PortName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.pcb_FileInfo = new System.Windows.Forms.PictureBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.txb_FilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Seconds = new System.Windows.Forms.Label();
            this.lbl_Minutes = new System.Windows.Forms.Label();
            this.lbl_Hours = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pc = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tls_MoveLeft = new System.Windows.Forms.ToolStripButton();
            this.tls_MoveRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tls_IncreaseOX = new System.Windows.Forms.ToolStripButton();
            this.tls_DecreaseOX = new System.Windows.Forms.ToolStripButton();
            this.tls_PriceOX = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tls_IncreaseOY = new System.Windows.Forms.ToolStripButton();
            this.tls_DecreaseOY = new System.Windows.Forms.ToolStripButton();
            this.tls_PriceOY = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_StartConnection = new System.Windows.Forms.ToolStripButton();
            this.btn_StopConnection = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_HideSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tmr_MOVE = new System.Windows.Forms.Timer(this.components);
            this.tmr_WorkingTime = new System.Windows.Forms.Timer(this.components);
            this.pnl_Settings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.group1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_FileInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Settings
            // 
            this.pnl_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(143)))), ((int)(((byte)(173)))));
            this.pnl_Settings.Controls.Add(this.groupBox2);
            this.pnl_Settings.Controls.Add(this.groupBox1);
            this.pnl_Settings.Controls.Add(this.group1);
            this.pnl_Settings.Controls.Add(this.label1);
            this.pnl_Settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Settings.Location = new System.Drawing.Point(674, 0);
            this.pnl_Settings.Name = "pnl_Settings";
            this.pnl_Settings.Size = new System.Drawing.Size(310, 557);
            this.pnl_Settings.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chb_AutoMax);
            this.groupBox2.Controls.Add(this.btn_ApplyConf);
            this.groupBox2.Controls.Add(this.txb_WaitTime);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 136);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дополнительные настройки";
            // 
            // chb_AutoMax
            // 
            this.chb_AutoMax.AutoSize = true;
            this.chb_AutoMax.Checked = true;
            this.chb_AutoMax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_AutoMax.FlatAppearance.BorderSize = 0;
            this.chb_AutoMax.Font = new System.Drawing.Font("Arial", 9F);
            this.chb_AutoMax.Location = new System.Drawing.Point(9, 82);
            this.chb_AutoMax.Name = "chb_AutoMax";
            this.chb_AutoMax.Size = new System.Drawing.Size(243, 19);
            this.chb_AutoMax.TabIndex = 5;
            this.chb_AutoMax.Text = "Автоподбор максимального значения";
            this.chb_AutoMax.UseVisualStyleBackColor = true;
            this.chb_AutoMax.CheckedChanged += new System.EventHandler(this.chb_AutoMax_CheckedChanged);
            // 
            // btn_ApplyConf
            // 
            this.btn_ApplyConf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ApplyConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ApplyConf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ApplyConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btn_ApplyConf.Location = new System.Drawing.Point(9, 107);
            this.btn_ApplyConf.Name = "btn_ApplyConf";
            this.btn_ApplyConf.Size = new System.Drawing.Size(88, 23);
            this.btn_ApplyConf.TabIndex = 4;
            this.btn_ApplyConf.Text = "Применить";
            this.btn_ApplyConf.UseVisualStyleBackColor = true;
            this.btn_ApplyConf.Click += new System.EventHandler(this.btn_ApplyConf_Click);
            // 
            // txb_WaitTime
            // 
            this.txb_WaitTime.Location = new System.Drawing.Point(202, 24);
            this.txb_WaitTime.Name = "txb_WaitTime";
            this.txb_WaitTime.Size = new System.Drawing.Size(75, 23);
            this.txb_WaitTime.TabIndex = 1;
            this.txb_WaitTime.Text = "25";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F);
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Время задержки(миллисекунд):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_BaundRate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_PortName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM-порт";
            // 
            // cmb_BaundRate
            // 
            this.cmb_BaundRate.FormattingEnabled = true;
            this.cmb_BaundRate.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600"});
            this.cmb_BaundRate.Location = new System.Drawing.Point(214, 68);
            this.cmb_BaundRate.Name = "cmb_BaundRate";
            this.cmb_BaundRate.Size = new System.Drawing.Size(76, 24);
            this.cmb_BaundRate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Символьная скорость(BaundRate):";
            // 
            // cmb_PortName
            // 
            this.cmb_PortName.FormattingEnabled = true;
            this.cmb_PortName.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5"});
            this.cmb_PortName.Location = new System.Drawing.Point(83, 30);
            this.cmb_PortName.Name = "cmb_PortName";
            this.cmb_PortName.Size = new System.Drawing.Size(92, 24);
            this.cmb_PortName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя порта:";
            // 
            // group1
            // 
            this.group1.Controls.Add(this.pcb_FileInfo);
            this.group1.Controls.Add(this.lbl_Status);
            this.group1.Controls.Add(this.btn_OpenFile);
            this.group1.Controls.Add(this.txb_FilePath);
            this.group1.Controls.Add(this.label2);
            this.group1.ForeColor = System.Drawing.Color.White;
            this.group1.Location = new System.Drawing.Point(3, 59);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(301, 106);
            this.group1.TabIndex = 1;
            this.group1.TabStop = false;
            this.group1.Text = "Тестовый файл";
            // 
            // pcb_FileInfo
            // 
            this.pcb_FileInfo.Image = global::GraphicBuilder.Properties.Resources.que_15px;
            this.pcb_FileInfo.Location = new System.Drawing.Point(84, 17);
            this.pcb_FileInfo.Name = "pcb_FileInfo";
            this.pcb_FileInfo.Size = new System.Drawing.Size(16, 16);
            this.pcb_FileInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcb_FileInfo.TabIndex = 4;
            this.pcb_FileInfo.TabStop = false;
            this.pcb_FileInfo.MouseHover += new System.EventHandler(this.pcb_FileInfo_MouseHover);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Wingdings 2", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_Status.ForeColor = System.Drawing.Color.Red;
            this.lbl_Status.Location = new System.Drawing.Point(120, 71);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(26, 24);
            this.lbl_Status.TabIndex = 2;
            this.lbl_Status.Text = "O";
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OpenFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btn_OpenFile.Location = new System.Drawing.Point(9, 70);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(105, 23);
            this.btn_OpenFile.TabIndex = 2;
            this.btn_OpenFile.Text = "Открыть файл";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // txb_FilePath
            // 
            this.txb_FilePath.Location = new System.Drawing.Point(9, 41);
            this.txb_FilePath.Name = "txb_FilePath";
            this.txb_FilePath.Size = new System.Drawing.Size(283, 23);
            this.txb_FilePath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Путь к файлу";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(143)))), ((int)(((byte)(173)))));
            this.panel3.Controls.Add(this.lbl_Seconds);
            this.panel3.Controls.Add(this.lbl_Minutes);
            this.panel3.Controls.Add(this.lbl_Hours);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(559, 530);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 26);
            this.panel3.TabIndex = 6;
            // 
            // lbl_Seconds
            // 
            this.lbl_Seconds.AutoSize = true;
            this.lbl_Seconds.Location = new System.Drawing.Point(90, 4);
            this.lbl_Seconds.Name = "lbl_Seconds";
            this.lbl_Seconds.Size = new System.Drawing.Size(24, 17);
            this.lbl_Seconds.TabIndex = 8;
            this.lbl_Seconds.Text = "00";
            // 
            // lbl_Minutes
            // 
            this.lbl_Minutes.AutoSize = true;
            this.lbl_Minutes.Location = new System.Drawing.Point(64, 4);
            this.lbl_Minutes.Name = "lbl_Minutes";
            this.lbl_Minutes.Size = new System.Drawing.Size(24, 17);
            this.lbl_Minutes.TabIndex = 8;
            this.lbl_Minutes.Text = "00";
            // 
            // lbl_Hours
            // 
            this.lbl_Hours.AutoSize = true;
            this.lbl_Hours.Location = new System.Drawing.Point(38, 4);
            this.lbl_Hours.Name = "lbl_Hours";
            this.lbl_Hours.Size = new System.Drawing.Size(24, 17);
            this.lbl_Hours.TabIndex = 8;
            this.lbl_Hours.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(84, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(58, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = ":";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pc);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 557);
            this.panel2.TabIndex = 5;
            // 
            // pc
            // 
            this.pc.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pc.Location = new System.Drawing.Point(0, 0);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(674, 529);
            this.pc.TabIndex = 3;
            this.pc.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(143)))), ((int)(((byte)(173)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tls_MoveLeft,
            this.tls_MoveRight,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tls_IncreaseOX,
            this.tls_DecreaseOX,
            this.tls_PriceOX,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.tls_IncreaseOY,
            this.tls_DecreaseOY,
            this.tls_PriceOY,
            this.toolStripSeparator3,
            this.btn_StartConnection,
            this.btn_StopConnection,
            this.toolStripSeparator4,
            this.btn_HideSettings,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 529);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(674, 28);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tls_MoveLeft
            // 
            this.tls_MoveLeft.AutoSize = false;
            this.tls_MoveLeft.AutoToolTip = false;
            this.tls_MoveLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tls_MoveLeft.Image = global::GraphicBuilder.Properties.Resources.RightArrow_25px;
            this.tls_MoveLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_MoveLeft.Name = "tls_MoveLeft";
            this.tls_MoveLeft.Size = new System.Drawing.Size(25, 25);
            this.tls_MoveLeft.Text = "toolStripButton1";
            this.tls_MoveLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tls_MoveLeft_MouseDown);
            this.tls_MoveLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tls_MoveLeft_MouseUp);
            // 
            // tls_MoveRight
            // 
            this.tls_MoveRight.AutoSize = false;
            this.tls_MoveRight.AutoToolTip = false;
            this.tls_MoveRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tls_MoveRight.Image = global::GraphicBuilder.Properties.Resources.LeftArrow_25px;
            this.tls_MoveRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_MoveRight.Name = "tls_MoveRight";
            this.tls_MoveRight.Size = new System.Drawing.Size(25, 25);
            this.tls_MoveRight.Text = "toolStripButton2";
            this.tls_MoveRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tls_MoveRight_MouseDown);
            this.tls_MoveRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tls_MoveRight_MouseUp);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(123)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(18, 25);
            this.toolStripLabel1.Text = "X:";
            // 
            // tls_IncreaseOX
            // 
            this.tls_IncreaseOX.AutoToolTip = false;
            this.tls_IncreaseOX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tls_IncreaseOX.Image = global::GraphicBuilder.Properties.Resources.Plus_25px;
            this.tls_IncreaseOX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_IncreaseOX.Name = "tls_IncreaseOX";
            this.tls_IncreaseOX.Size = new System.Drawing.Size(23, 25);
            this.tls_IncreaseOX.Text = "toolStripButton1";
            this.tls_IncreaseOX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tls_IncreaseOX_MouseDown);
            this.tls_IncreaseOX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tls_IncreaseOX_MouseUp);
            // 
            // tls_DecreaseOX
            // 
            this.tls_DecreaseOX.AutoToolTip = false;
            this.tls_DecreaseOX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tls_DecreaseOX.Image = global::GraphicBuilder.Properties.Resources.Minus_25px;
            this.tls_DecreaseOX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_DecreaseOX.Name = "tls_DecreaseOX";
            this.tls_DecreaseOX.Size = new System.Drawing.Size(23, 25);
            this.tls_DecreaseOX.Text = "toolStripButton2";
            this.tls_DecreaseOX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tls_DecreaseOX_MouseDown);
            this.tls_DecreaseOX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tls_DecreaseOX_MouseUp);
            // 
            // tls_PriceOX
            // 
            this.tls_PriceOX.AutoSize = false;
            this.tls_PriceOX.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "6",
            "10"});
            this.tls_PriceOX.Name = "tls_PriceOX";
            this.tls_PriceOX.Size = new System.Drawing.Size(40, 23);
            this.tls_PriceOX.Text = "1";
            this.tls_PriceOX.Leave += new System.EventHandler(this.tls_PriceOX_Leave);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(123)))));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 25);
            this.toolStripLabel2.Text = "Y:";
            // 
            // tls_IncreaseOY
            // 
            this.tls_IncreaseOY.AutoToolTip = false;
            this.tls_IncreaseOY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tls_IncreaseOY.Image = global::GraphicBuilder.Properties.Resources.Plus_25px;
            this.tls_IncreaseOY.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_IncreaseOY.Name = "tls_IncreaseOY";
            this.tls_IncreaseOY.Size = new System.Drawing.Size(23, 25);
            this.tls_IncreaseOY.Text = "toolStripButton1";
            this.tls_IncreaseOY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tls_IncreaseOY_MouseDown);
            this.tls_IncreaseOY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tls_IncreaseOY_MouseUp);
            // 
            // tls_DecreaseOY
            // 
            this.tls_DecreaseOY.AutoToolTip = false;
            this.tls_DecreaseOY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tls_DecreaseOY.Image = global::GraphicBuilder.Properties.Resources.Minus_25px;
            this.tls_DecreaseOY.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_DecreaseOY.Name = "tls_DecreaseOY";
            this.tls_DecreaseOY.Size = new System.Drawing.Size(23, 25);
            this.tls_DecreaseOY.Text = "toolStripButton2";
            this.tls_DecreaseOY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tls_DecreaseOY_MouseDown);
            this.tls_DecreaseOY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tls_DecreaseOY_MouseUp);
            // 
            // tls_PriceOY
            // 
            this.tls_PriceOY.AutoSize = false;
            this.tls_PriceOY.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "6",
            "10"});
            this.tls_PriceOY.Name = "tls_PriceOY";
            this.tls_PriceOY.Size = new System.Drawing.Size(40, 23);
            this.tls_PriceOY.Text = "1";
            this.tls_PriceOY.Leave += new System.EventHandler(this.tls_PriceOY_Leave);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // btn_StartConnection
            // 
            this.btn_StartConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btn_StartConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_StartConnection.Image = global::GraphicBuilder.Properties.Resources.play_25px;
            this.btn_StartConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_StartConnection.Name = "btn_StartConnection";
            this.btn_StartConnection.Size = new System.Drawing.Size(23, 25);
            this.btn_StartConnection.Text = "toolStripButton1";
            this.btn_StartConnection.Click += new System.EventHandler(this.btn_StartConnection_Click);
            // 
            // btn_StopConnection
            // 
            this.btn_StopConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btn_StopConnection.Checked = true;
            this.btn_StopConnection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btn_StopConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_StopConnection.Image = global::GraphicBuilder.Properties.Resources.stop_25px;
            this.btn_StopConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_StopConnection.Name = "btn_StopConnection";
            this.btn_StopConnection.Size = new System.Drawing.Size(23, 25);
            this.btn_StopConnection.Text = "toolStripButton2";
            this.btn_StopConnection.Click += new System.EventHandler(this.btn_StopConnection_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // btn_HideSettings
            // 
            this.btn_HideSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(197)))), ((int)(((byte)(199)))));
            this.btn_HideSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_HideSettings.Image = global::GraphicBuilder.Properties.Resources.unvisibie_25px;
            this.btn_HideSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_HideSettings.Name = "btn_HideSettings";
            this.btn_HideSettings.Size = new System.Drawing.Size(23, 25);
            this.btn_HideSettings.Text = "toolStripButton1";
            this.btn_HideSettings.Click += new System.EventHandler(this.btn_HideSettings_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // tmr_MOVE
            // 
            this.tmr_MOVE.Tick += new System.EventHandler(this.tmr_MOVE_Tick);
            // 
            // tmr_WorkingTime
            // 
            this.tmr_WorkingTime.Interval = 1000;
            this.tmr_WorkingTime.Tick += new System.EventHandler(this.tmr_WorkingTime_Tick);
            // 
            // RT_Graphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_Settings);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RT_Graphic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Построение графика в реальном времени";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RT_Graphic_FormClosing);
            this.Load += new System.EventHandler(this.RT_Graphic_Load);
            this.pnl_Settings.ResumeLayout(false);
            this.pnl_Settings.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_FileInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pc;
        private System.Windows.Forms.Panel pnl_Settings;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.TextBox txb_FilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_BaundRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_PortName;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ApplyConf;
        private System.Windows.Forms.TextBox txb_WaitTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pcb_FileInfo;
        private System.Windows.Forms.Timer tmr_MOVE;
        private System.Windows.Forms.CheckBox chb_AutoMax;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Seconds;
        private System.Windows.Forms.Label lbl_Minutes;
        private System.Windows.Forms.Label lbl_Hours;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer tmr_WorkingTime;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tls_MoveLeft;
        private System.Windows.Forms.ToolStripButton tls_MoveRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tls_IncreaseOX;
        private System.Windows.Forms.ToolStripButton tls_DecreaseOX;
        private System.Windows.Forms.ToolStripComboBox tls_PriceOX;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton tls_IncreaseOY;
        private System.Windows.Forms.ToolStripButton tls_DecreaseOY;
        private System.Windows.Forms.ToolStripComboBox tls_PriceOY;
        private System.Windows.Forms.ToolStripButton btn_StartConnection;
        private System.Windows.Forms.ToolStripButton btn_StopConnection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_HideSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}