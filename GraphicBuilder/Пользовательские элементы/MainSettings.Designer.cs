namespace GraphicBuilder
{
    partial class MainSettings
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chb_SmoothAngles = new System.Windows.Forms.CheckBox();
            this.chb_ShowPoints = new System.Windows.Forms.CheckBox();
            this.chb_Grid = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_CurrentFont = new System.Windows.Forms.TextBox();
            this.btn_ChangeTextFont = new System.Windows.Forms.Button();
            this.btn_ChangePlotColor = new System.Windows.Forms.Button();
            this.pcb_PlotColor = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_PlotColor)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(348, 42);
            this.label6.TabIndex = 3;
            this.label6.Text = "Настройки построения";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chb_SmoothAngles);
            this.groupBox1.Controls.Add(this.chb_ShowPoints);
            this.groupBox1.Controls.Add(this.chb_Grid);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox1.Location = new System.Drawing.Point(3, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки графика";
            // 
            // chb_SmoothAngles
            // 
            this.chb_SmoothAngles.AutoSize = true;
            this.chb_SmoothAngles.Font = new System.Drawing.Font("Arial", 10F);
            this.chb_SmoothAngles.Location = new System.Drawing.Point(7, 81);
            this.chb_SmoothAngles.Name = "chb_SmoothAngles";
            this.chb_SmoothAngles.Size = new System.Drawing.Size(149, 20);
            this.chb_SmoothAngles.TabIndex = 2;
            this.chb_SmoothAngles.Text = "Сглаживать линии";
            this.chb_SmoothAngles.UseVisualStyleBackColor = true;
            this.chb_SmoothAngles.CheckedChanged += new System.EventHandler(this.chb_SmoothAngles_CheckedChanged);
            // 
            // chb_ShowPoints
            // 
            this.chb_ShowPoints.AutoSize = true;
            this.chb_ShowPoints.Font = new System.Drawing.Font("Arial", 10F);
            this.chb_ShowPoints.Location = new System.Drawing.Point(7, 53);
            this.chb_ShowPoints.Name = "chb_ShowPoints";
            this.chb_ShowPoints.Size = new System.Drawing.Size(171, 20);
            this.chb_ShowPoints.TabIndex = 1;
            this.chb_ShowPoints.Text = "Явно указывать точки";
            this.chb_ShowPoints.UseVisualStyleBackColor = true;
            this.chb_ShowPoints.CheckedChanged += new System.EventHandler(this.chb_ShowPoints_CheckedChanged);
            // 
            // chb_Grid
            // 
            this.chb_Grid.AutoSize = true;
            this.chb_Grid.Font = new System.Drawing.Font("Arial", 10F);
            this.chb_Grid.Location = new System.Drawing.Point(7, 25);
            this.chb_Grid.Name = "chb_Grid";
            this.chb_Grid.Size = new System.Drawing.Size(66, 20);
            this.chb_Grid.TabIndex = 0;
            this.chb_Grid.Text = "Сетка";
            this.chb_Grid.UseVisualStyleBackColor = true;
            this.chb_Grid.CheckedChanged += new System.EventHandler(this.chb_Grid_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(7, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Цвет области построения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(7, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Шрифт текста области построения:";
            // 
            // txb_CurrentFont
            // 
            this.txb_CurrentFont.Location = new System.Drawing.Point(258, 258);
            this.txb_CurrentFont.Name = "txb_CurrentFont";
            this.txb_CurrentFont.ReadOnly = true;
            this.txb_CurrentFont.Size = new System.Drawing.Size(153, 22);
            this.txb_CurrentFont.TabIndex = 9;
            // 
            // btn_ChangeTextFont
            // 
            this.btn_ChangeTextFont.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ChangeTextFont.Image = global::GraphicBuilder.Properties.Resources.more_20px;
            this.btn_ChangeTextFont.Location = new System.Drawing.Point(417, 258);
            this.btn_ChangeTextFont.Name = "btn_ChangeTextFont";
            this.btn_ChangeTextFont.Size = new System.Drawing.Size(29, 22);
            this.btn_ChangeTextFont.TabIndex = 10;
            this.btn_ChangeTextFont.UseVisualStyleBackColor = true;
            this.btn_ChangeTextFont.Click += new System.EventHandler(this.btn_ChangeTextFont_Click);
            // 
            // btn_ChangePlotColor
            // 
            this.btn_ChangePlotColor.FlatAppearance.BorderSize = 0;
            this.btn_ChangePlotColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangePlotColor.Image = global::GraphicBuilder.Properties.Resources.imgonline_com_ua_Resize_fS0FFiRVBrr6x88Q;
            this.btn_ChangePlotColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChangePlotColor.Location = new System.Drawing.Point(222, 211);
            this.btn_ChangePlotColor.Name = "btn_ChangePlotColor";
            this.btn_ChangePlotColor.Size = new System.Drawing.Size(36, 34);
            this.btn_ChangePlotColor.TabIndex = 7;
            this.btn_ChangePlotColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ChangePlotColor.UseVisualStyleBackColor = true;
            this.btn_ChangePlotColor.Click += new System.EventHandler(this.btn_ChangePlotColor_Click);
            // 
            // pcb_PlotColor
            // 
            this.pcb_PlotColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcb_PlotColor.Location = new System.Drawing.Point(196, 215);
            this.pcb_PlotColor.Name = "pcb_PlotColor";
            this.pcb_PlotColor.Size = new System.Drawing.Size(25, 25);
            this.pcb_PlotColor.TabIndex = 6;
            this.pcb_PlotColor.TabStop = false;
            // 
            // MainSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_ChangeTextFont);
            this.Controls.Add(this.txb_CurrentFont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ChangePlotColor);
            this.Controls.Add(this.pcb_PlotColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainSettings";
            this.Size = new System.Drawing.Size(449, 561);
            this.Load += new System.EventHandler(this.MainSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_PlotColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chb_SmoothAngles;
        private System.Windows.Forms.CheckBox chb_ShowPoints;
        private System.Windows.Forms.CheckBox chb_Grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcb_PlotColor;
        private System.Windows.Forms.Button btn_ChangePlotColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_CurrentFont;
        private System.Windows.Forms.Button btn_ChangeTextFont;
    }
}
