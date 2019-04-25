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
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tls_MoveLeft = new System.Windows.Forms.ToolStripButton();
            this.tls_MoveRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Connection = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.txb_FilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pc = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_PortName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_BaundRate = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.group1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(143)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.btn_Connection);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.group1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(674, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 557);
            this.panel1.TabIndex = 4;
           
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tls_MoveLeft,
            this.tls_MoveRight,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 529);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(310, 28);
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
            this.tls_MoveLeft.Click += new System.EventHandler(this.tls_MoveLeft_Click);
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
            this.tls_MoveRight.Click += new System.EventHandler(this.tls_MoveRight_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // btn_Connection
            // 
            this.btn_Connection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Connection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Connection.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Connection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.btn_Connection.Location = new System.Drawing.Point(2, 500);
            this.btn_Connection.Name = "btn_Connection";
            this.btn_Connection.Size = new System.Drawing.Size(146, 26);
            this.btn_Connection.TabIndex = 3;
            this.btn_Connection.Text = "Подключиться";
            this.btn_Connection.UseVisualStyleBackColor = true;
            this.btn_Connection.Click += new System.EventHandler(this.btn_Connection_Click);
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
            this.groupBox1.Text = "USB-порт";
            // 
            // group1
            // 
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
            // panel2
            // 
            this.panel2.Controls.Add(this.pc);
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
            this.pc.Size = new System.Drawing.Size(674, 557);
            this.pc.TabIndex = 3;
            this.pc.TabStop = false;
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
            // RT_Graphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RT_Graphic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Построение графика в реальном времени";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RT_Graphic_FormClosing);
            this.Load += new System.EventHandler(this.RT_Graphic_Load);
           
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.TextBox txb_FilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Connection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tls_MoveLeft;
        private System.Windows.Forms.ToolStripButton tls_MoveRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox cmb_BaundRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_PortName;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
    }
}