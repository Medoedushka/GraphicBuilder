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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_BuildGraph = new System.Windows.Forms.Button();
            this.lbl_StepOY = new System.Windows.Forms.Label();
            this.lbl_StepOX = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnl_Windows = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ControlNote = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_DeleteCurves = new System.Windows.Forms.Button();
            this.btn_AddNewGraph = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_CenterLEFT = new System.Windows.Forms.Button();
            this.btn_CenterRIGHT = new System.Windows.Forms.Button();
            this.btn_CenterDOWN = new System.Windows.Forms.Button();
            this.btn_CenterUP = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_Windows.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(220)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.btn_BuildGraph);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_DeleteCurves);
            this.panel1.Controls.Add(this.btn_AddNewGraph);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lbl_StepOY);
            this.panel1.Controls.Add(this.btn_CenterLEFT);
            this.panel1.Controls.Add(this.lbl_StepOX);
            this.panel1.Controls.Add(this.btn_CenterRIGHT);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btn_CenterDOWN);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btn_CenterUP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 507);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 41);
            this.panel1.TabIndex = 0;
            // 
            // btn_BuildGraph
            // 
            this.btn_BuildGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BuildGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_BuildGraph.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_BuildGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuildGraph.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_BuildGraph.Location = new System.Drawing.Point(603, 2);
            this.btn_BuildGraph.Name = "btn_BuildGraph";
            this.btn_BuildGraph.Size = new System.Drawing.Size(119, 37);
            this.btn_BuildGraph.TabIndex = 37;
            this.btn_BuildGraph.Text = "Построить";
            this.btn_BuildGraph.UseVisualStyleBackColor = false;
            this.btn_BuildGraph.Click += new System.EventHandler(this.btn_BuildGraph_Click);
            // 
            // lbl_StepOY
            // 
            this.lbl_StepOY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_StepOY.AutoSize = true;
            this.lbl_StepOY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_StepOY.Location = new System.Drawing.Point(199, 25);
            this.lbl_StepOY.Name = "lbl_StepOY";
            this.lbl_StepOY.Size = new System.Drawing.Size(35, 13);
            this.lbl_StepOY.TabIndex = 25;
            this.lbl_StepOY.Text = "Num2";
            this.lbl_StepOY.Visible = false;
            // 
            // lbl_StepOX
            // 
            this.lbl_StepOX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_StepOX.AutoSize = true;
            this.lbl_StepOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_StepOX.Location = new System.Drawing.Point(199, 7);
            this.lbl_StepOX.Name = "lbl_StepOX";
            this.lbl_StepOX.Size = new System.Drawing.Size(35, 13);
            this.lbl_StepOX.TabIndex = 24;
            this.lbl_StepOX.Text = "Num1";
            this.lbl_StepOX.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(86, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Шаг деления оси OY:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(86, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Шаг деления оси OX:";
            // 
            // pnl_Windows
            // 
            this.pnl_Windows.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnl_Windows.Controls.Add(this.label6);
            this.pnl_Windows.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Windows.Location = new System.Drawing.Point(603, 0);
            this.pnl_Windows.Name = "pnl_Windows";
            this.pnl_Windows.Size = new System.Drawing.Size(449, 507);
            this.pnl_Windows.TabIndex = 1;
            this.pnl_Windows.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 507);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(190)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 507);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::GraphicBuilder.Properties.Resources.lineChart_25px;
            this.button1.Location = new System.Drawing.Point(559, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 41);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteCurves
            // 
            this.btn_DeleteCurves.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteCurves.FlatAppearance.BorderSize = 0;
            this.btn_DeleteCurves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteCurves.Image = global::GraphicBuilder.Properties.Resources.dustBin_25px;
            this.btn_DeleteCurves.Location = new System.Drawing.Point(926, 2);
            this.btn_DeleteCurves.Name = "btn_DeleteCurves";
            this.btn_DeleteCurves.Size = new System.Drawing.Size(41, 41);
            this.btn_DeleteCurves.TabIndex = 35;
            this.ControlNote.SetToolTip(this.btn_DeleteCurves, "Очистить ВСЕ добавленные построения");
            this.btn_DeleteCurves.UseVisualStyleBackColor = true;
            this.btn_DeleteCurves.Click += new System.EventHandler(this.btn_DeleteCurves_Click);
            // 
            // btn_AddNewGraph
            // 
            this.btn_AddNewGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddNewGraph.FlatAppearance.BorderSize = 0;
            this.btn_AddNewGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNewGraph.Image = global::GraphicBuilder.Properties.Resources.plus25px;
            this.btn_AddNewGraph.Location = new System.Drawing.Point(968, 2);
            this.btn_AddNewGraph.Name = "btn_AddNewGraph";
            this.btn_AddNewGraph.Size = new System.Drawing.Size(41, 41);
            this.btn_AddNewGraph.TabIndex = 35;
            this.ControlNote.SetToolTip(this.btn_AddNewGraph, "Добавить новое построение");
            this.btn_AddNewGraph.UseVisualStyleBackColor = true;
            this.btn_AddNewGraph.Click += new System.EventHandler(this.btn_AddNewGraph_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::GraphicBuilder.Properties.Resources.newpears_25px;
            this.button2.Location = new System.Drawing.Point(1010, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 41);
            this.button2.TabIndex = 34;
            this.ControlNote.SetToolTip(this.button2, "Настройки");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_CenterLEFT
            // 
            this.btn_CenterLEFT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_CenterLEFT.FlatAppearance.BorderSize = 0;
            this.btn_CenterLEFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CenterLEFT.Image = global::GraphicBuilder.Properties.Resources.ArrowLeft_25px;
            this.btn_CenterLEFT.Location = new System.Drawing.Point(41, 7);
            this.btn_CenterLEFT.Name = "btn_CenterLEFT";
            this.btn_CenterLEFT.Size = new System.Drawing.Size(20, 32);
            this.btn_CenterLEFT.TabIndex = 36;
            this.btn_CenterLEFT.UseVisualStyleBackColor = true;
            // 
            // btn_CenterRIGHT
            // 
            this.btn_CenterRIGHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_CenterRIGHT.FlatAppearance.BorderSize = 0;
            this.btn_CenterRIGHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CenterRIGHT.Image = global::GraphicBuilder.Properties.Resources.ArrowRight_25px1;
            this.btn_CenterRIGHT.Location = new System.Drawing.Point(60, 7);
            this.btn_CenterRIGHT.Name = "btn_CenterRIGHT";
            this.btn_CenterRIGHT.Size = new System.Drawing.Size(20, 32);
            this.btn_CenterRIGHT.TabIndex = 34;
            this.btn_CenterRIGHT.UseVisualStyleBackColor = true;
            // 
            // btn_CenterDOWN
            // 
            this.btn_CenterDOWN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_CenterDOWN.FlatAppearance.BorderSize = 0;
            this.btn_CenterDOWN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CenterDOWN.Image = global::GraphicBuilder.Properties.Resources.ArrowBottom_25px;
            this.btn_CenterDOWN.Location = new System.Drawing.Point(3, 22);
            this.btn_CenterDOWN.Name = "btn_CenterDOWN";
            this.btn_CenterDOWN.Size = new System.Drawing.Size(32, 18);
            this.btn_CenterDOWN.TabIndex = 35;
            this.btn_CenterDOWN.UseVisualStyleBackColor = true;
            // 
            // btn_CenterUP
            // 
            this.btn_CenterUP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_CenterUP.FlatAppearance.BorderSize = 0;
            this.btn_CenterUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CenterUP.Image = global::GraphicBuilder.Properties.Resources.ArrowTop_25px;
            this.btn_CenterUP.Location = new System.Drawing.Point(3, 3);
            this.btn_CenterUP.Name = "btn_CenterUP";
            this.btn_CenterUP.Size = new System.Drawing.Size(32, 20);
            this.btn_CenterUP.TabIndex = 33;
            this.btn_CenterUP.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 548);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnl_Windows);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Построение графика функции";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Windows.ResumeLayout(false);
            this.pnl_Windows.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Windows;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_CenterLEFT;
        private System.Windows.Forms.Button btn_CenterRIGHT;
        private System.Windows.Forms.Button btn_CenterDOWN;
        private System.Windows.Forms.Button btn_CenterUP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_AddNewGraph;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_StepOY;
        private System.Windows.Forms.Label lbl_StepOX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_BuildGraph;
        private System.Windows.Forms.Button btn_DeleteCurves;
        private System.Windows.Forms.ToolTip ControlNote;
        private System.Windows.Forms.Button button1;
    }
}

