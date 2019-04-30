namespace GraphicBuilder
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_Windows = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmb_PriceOX = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cmb_PriceOY = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_BuildGraph = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.ControlNote = new System.Windows.Forms.ToolTip(this.components);
            this.tmr_ChangeMainParams = new System.Windows.Forms.Timer(this.components);
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.сохранитьPngкартинкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьRTпостроениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_CenterUP = new System.Windows.Forms.ToolStripButton();
            this.btn_CenterDOWN = new System.Windows.Forms.ToolStripButton();
            this.btn_CenterLEFT = new System.Windows.Forms.ToolStripButton();
            this.btn_CenterRIGHT = new System.Windows.Forms.ToolStripButton();
            this.btn_IncreaseOX = new System.Windows.Forms.ToolStripButton();
            this.btn_DecreaseOX = new System.Windows.Forms.ToolStripButton();
            this.btn_IncreaseOY = new System.Windows.Forms.ToolStripButton();
            this.btn_DecreaseOY = new System.Windows.Forms.ToolStripButton();
            this.btn_HideSettings = new System.Windows.Forms.ToolStripButton();
            this.btn_BuildRTGraph = new System.Windows.Forms.ToolStripButton();
            this.btn_AddNewGraph = new System.Windows.Forms.ToolStripButton();
            this.btn_MainSettings = new System.Windows.Forms.ToolStripButton();
            this.btn_DeleteCurves = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.pnl_Windows.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Windows
            // 
            this.pnl_Windows.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnl_Windows.Controls.Add(this.label6);
            this.pnl_Windows.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Windows.Location = new System.Drawing.Point(683, 0);
            this.pnl_Windows.Name = "pnl_Windows";
            this.pnl_Windows.Size = new System.Drawing.Size(449, 561);
            this.pnl_Windows.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 42);
            this.label6.TabIndex = 2;
            this.label6.Text = "Главное меню";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.toolStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(683, 561);
            this.panel3.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(220)))), ((int)(((byte)(130)))));
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripLabel1,
            this.btn_CenterUP,
            this.btn_CenterDOWN,
            this.btn_CenterLEFT,
            this.btn_CenterRIGHT,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.btn_IncreaseOX,
            this.btn_DecreaseOX,
            this.cmb_PriceOX,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.btn_IncreaseOY,
            this.btn_DecreaseOY,
            this.cmb_PriceOY,
            this.toolStripSeparator6,
            this.btn_HideSettings,
            this.toolStripSeparator3,
            this.btn_BuildGraph,
            this.toolStripSeparator4,
            this.toolStripLabel4,
            this.btn_BuildRTGraph,
            this.toolStripSeparator5,
            this.btn_AddNewGraph,
            this.toolStripSeparator7,
            this.btn_MainSettings,
            this.toolStripSeparator8,
            this.btn_DeleteCurves,
            this.toolStripSeparator9});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(683, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(237)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel1.Text = "Камера:";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(237)))));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(18, 22);
            this.toolStripLabel2.Text = "X:";
            // 
            // cmb_PriceOX
            // 
            this.cmb_PriceOX.AutoSize = false;
            this.cmb_PriceOX.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "6",
            "10"});
            this.cmb_PriceOX.Name = "cmb_PriceOX";
            this.cmb_PriceOX.Size = new System.Drawing.Size(50, 23);
            this.cmb_PriceOX.Leave += new System.EventHandler(this.cmb_PriceOX_Leave);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(237)))));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel3.Text = "Y:";
            // 
            // cmb_PriceOY
            // 
            this.cmb_PriceOY.AutoSize = false;
            this.cmb_PriceOY.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "6",
            "10"});
            this.cmb_PriceOY.Name = "cmb_PriceOY";
            this.cmb_PriceOY.Size = new System.Drawing.Size(50, 23);
            this.cmb_PriceOY.Leave += new System.EventHandler(this.cmb_PriceOY_Leave);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_BuildGraph
            // 
            this.btn_BuildGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_BuildGraph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_BuildGraph.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_BuildGraph.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_BuildGraph.Name = "btn_BuildGraph";
            this.btn_BuildGraph.Size = new System.Drawing.Size(72, 22);
            this.btn_BuildGraph.Tag = "";
            this.btn_BuildGraph.Text = "Построить";
            this.btn_BuildGraph.Click += new System.EventHandler(this.btn_BuildGraph_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(237)))));
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(72, 22);
            this.toolStripLabel4.Text = "RT-график:";
            this.toolStripLabel4.Click += new System.EventHandler(this.toolStripLabel4_Click);
            // 
            // tmr_ChangeMainParams
            // 
            this.tmr_ChangeMainParams.Interval = 40;
            this.tmr_ChangeMainParams.Tick += new System.EventHandler(this.tmr_ChangeMainParams_Tick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(190)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(683, 536);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьPngкартинкуToolStripMenuItem,
            this.открытьRTпостроениеToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::GraphicBuilder.Properties.Resources.file_25px;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // сохранитьPngкартинкуToolStripMenuItem
            // 
            this.сохранитьPngкартинкуToolStripMenuItem.Name = "сохранитьPngкартинкуToolStripMenuItem";
            this.сохранитьPngкартинкуToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.сохранитьPngкартинкуToolStripMenuItem.Text = "Сохранить png-картинку ";
            this.сохранитьPngкартинкуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьPngкартинкуToolStripMenuItem_Click);
            // 
            // открытьRTпостроениеToolStripMenuItem
            // 
            this.открытьRTпостроениеToolStripMenuItem.Name = "открытьRTпостроениеToolStripMenuItem";
            this.открытьRTпостроениеToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.открытьRTпостроениеToolStripMenuItem.Text = "Открыть RT-построение";
            this.открытьRTпостроениеToolStripMenuItem.Click += new System.EventHandler(this.btn_OpenRTGraph_Click);
            // 
            // btn_CenterUP
            // 
            this.btn_CenterUP.AutoSize = false;
            this.btn_CenterUP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_CenterUP.Image = global::GraphicBuilder.Properties.Resources.ArrowTop_25px;
            this.btn_CenterUP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_CenterUP.Name = "btn_CenterUP";
            this.btn_CenterUP.Size = new System.Drawing.Size(25, 25);
            this.btn_CenterUP.Text = "toolStripButton1";
            this.btn_CenterUP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_CenterUP_MouseDown);
            this.btn_CenterUP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_CenterUP_MouseUp);
            // 
            // btn_CenterDOWN
            // 
            this.btn_CenterDOWN.AutoSize = false;
            this.btn_CenterDOWN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_CenterDOWN.Image = global::GraphicBuilder.Properties.Resources.ArrowBottom_25px;
            this.btn_CenterDOWN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_CenterDOWN.Name = "btn_CenterDOWN";
            this.btn_CenterDOWN.Size = new System.Drawing.Size(25, 25);
            this.btn_CenterDOWN.Text = "toolStripButton2";
            this.btn_CenterDOWN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_CenterDOWN_MouseDown);
            this.btn_CenterDOWN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_CenterDOWN_MouseUp);
            // 
            // btn_CenterLEFT
            // 
            this.btn_CenterLEFT.AutoSize = false;
            this.btn_CenterLEFT.AutoToolTip = false;
            this.btn_CenterLEFT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_CenterLEFT.Image = global::GraphicBuilder.Properties.Resources.ArrowLeft_25px;
            this.btn_CenterLEFT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_CenterLEFT.Name = "btn_CenterLEFT";
            this.btn_CenterLEFT.Size = new System.Drawing.Size(25, 25);
            this.btn_CenterLEFT.Text = "toolStripButton3";
            this.btn_CenterLEFT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_CenterLEFT_MouseDown);
            this.btn_CenterLEFT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_CenterLEFT_MouseUp);
            // 
            // btn_CenterRIGHT
            // 
            this.btn_CenterRIGHT.AutoSize = false;
            this.btn_CenterRIGHT.AutoToolTip = false;
            this.btn_CenterRIGHT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_CenterRIGHT.Image = global::GraphicBuilder.Properties.Resources.ArrowRight_25px1;
            this.btn_CenterRIGHT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_CenterRIGHT.Name = "btn_CenterRIGHT";
            this.btn_CenterRIGHT.Size = new System.Drawing.Size(25, 25);
            this.btn_CenterRIGHT.Text = "toolStripButton4";
            this.btn_CenterRIGHT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_CenterRIGHT_MouseDown);
            this.btn_CenterRIGHT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_CenterLEFT_MouseUp);
            // 
            // btn_IncreaseOX
            // 
            this.btn_IncreaseOX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_IncreaseOX.Image = global::GraphicBuilder.Properties.Resources.mainPlus_25px;
            this.btn_IncreaseOX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_IncreaseOX.Name = "btn_IncreaseOX";
            this.btn_IncreaseOX.Size = new System.Drawing.Size(23, 22);
            this.btn_IncreaseOX.Text = "toolStripButton5";
            this.btn_IncreaseOX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_IncreaseOX_MouseDown);
            this.btn_IncreaseOX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_IncreaseOX_MouseUp);
            // 
            // btn_DecreaseOX
            // 
            this.btn_DecreaseOX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_DecreaseOX.Image = global::GraphicBuilder.Properties.Resources.mainMinus_25px;
            this.btn_DecreaseOX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DecreaseOX.Name = "btn_DecreaseOX";
            this.btn_DecreaseOX.Size = new System.Drawing.Size(23, 22);
            this.btn_DecreaseOX.Text = "toolStripButton6";
            this.btn_DecreaseOX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_DecreaseOX_MouseDown);
            this.btn_DecreaseOX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_DecreaseOX_MouseUp);
            // 
            // btn_IncreaseOY
            // 
            this.btn_IncreaseOY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_IncreaseOY.Image = global::GraphicBuilder.Properties.Resources.mainPlus_25px;
            this.btn_IncreaseOY.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_IncreaseOY.Name = "btn_IncreaseOY";
            this.btn_IncreaseOY.Size = new System.Drawing.Size(23, 22);
            this.btn_IncreaseOY.Text = "toolStripButton7";
            this.btn_IncreaseOY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_IncreaseOY_MouseDown);
            this.btn_IncreaseOY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_IncreaseOY_MouseUp);
            // 
            // btn_DecreaseOY
            // 
            this.btn_DecreaseOY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_DecreaseOY.Image = global::GraphicBuilder.Properties.Resources.mainMinus_25px;
            this.btn_DecreaseOY.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DecreaseOY.Name = "btn_DecreaseOY";
            this.btn_DecreaseOY.Size = new System.Drawing.Size(23, 22);
            this.btn_DecreaseOY.Text = "toolStripButton8";
            this.btn_DecreaseOY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_DecreaseOY_MouseDown);
            this.btn_DecreaseOY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_DecreaseOY_MouseUp);
            // 
            // btn_HideSettings
            // 
            this.btn_HideSettings.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_HideSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_HideSettings.Image = global::GraphicBuilder.Properties.Resources.unvisibie_25px;
            this.btn_HideSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_HideSettings.Name = "btn_HideSettings";
            this.btn_HideSettings.Size = new System.Drawing.Size(23, 22);
            this.btn_HideSettings.Text = "toolStripButton1";
            this.btn_HideSettings.Click += new System.EventHandler(this.btn_HideSettings_Click);
            // 
            // btn_BuildRTGraph
            // 
            this.btn_BuildRTGraph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_BuildRTGraph.Image = global::GraphicBuilder.Properties.Resources.lineChart_25px;
            this.btn_BuildRTGraph.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_BuildRTGraph.Name = "btn_BuildRTGraph";
            this.btn_BuildRTGraph.Size = new System.Drawing.Size(23, 22);
            this.btn_BuildRTGraph.Text = "toolStripButton1";
            this.btn_BuildRTGraph.Click += new System.EventHandler(this.btn_BuildRTGraph_Click);
            // 
            // btn_AddNewGraph
            // 
            this.btn_AddNewGraph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AddNewGraph.Image = global::GraphicBuilder.Properties.Resources.plus25px;
            this.btn_AddNewGraph.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AddNewGraph.Name = "btn_AddNewGraph";
            this.btn_AddNewGraph.Size = new System.Drawing.Size(23, 22);
            this.btn_AddNewGraph.Text = "toolStripButton1";
            this.btn_AddNewGraph.Click += new System.EventHandler(this.btn_AddNewGraph_Click);
            // 
            // btn_MainSettings
            // 
            this.btn_MainSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_MainSettings.Image = global::GraphicBuilder.Properties.Resources.settings_25px;
            this.btn_MainSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_MainSettings.Name = "btn_MainSettings";
            this.btn_MainSettings.Size = new System.Drawing.Size(23, 20);
            this.btn_MainSettings.Text = "toolStripButton2";
            this.btn_MainSettings.Click += new System.EventHandler(this.btn_MainSettings_Click);
            // 
            // btn_DeleteCurves
            // 
            this.btn_DeleteCurves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_DeleteCurves.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_DeleteCurves.Image = global::GraphicBuilder.Properties.Resources.dustBin_25px;
            this.btn_DeleteCurves.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DeleteCurves.Name = "btn_DeleteCurves";
            this.btn_DeleteCurves.Size = new System.Drawing.Size(23, 20);
            this.btn_DeleteCurves.Text = "toolStripButton3";
            this.btn_DeleteCurves.Click += new System.EventHandler(this.btn_DeleteCurves_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnl_Windows);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Построение графика функции";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.pnl_Windows.ResumeLayout(false);
            this.pnl_Windows.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Windows;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip ControlNote;
        private System.Windows.Forms.Timer tmr_ChangeMainParams;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_CenterUP;
        private System.Windows.Forms.ToolStripButton btn_CenterDOWN;
        private System.Windows.Forms.ToolStripButton btn_CenterLEFT;
        private System.Windows.Forms.ToolStripButton btn_CenterRIGHT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btn_IncreaseOX;
        private System.Windows.Forms.ToolStripButton btn_DecreaseOX;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btn_IncreaseOY;
        private System.Windows.Forms.ToolStripButton btn_DecreaseOY;
        private System.Windows.Forms.ToolStripComboBox cmb_PriceOX;
        private System.Windows.Forms.ToolStripComboBox cmb_PriceOY;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_BuildGraph;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьPngкартинкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton btn_BuildRTGraph;
        private System.Windows.Forms.ToolStripMenuItem открытьRTпостроениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btn_HideSettings;
        private System.Windows.Forms.ToolStripButton btn_AddNewGraph;
        private System.Windows.Forms.ToolStripButton btn_MainSettings;
        private System.Windows.Forms.ToolStripButton btn_DeleteCurves;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
    }
}

