namespace GraphicBuilder
{
    partial class AddGraph
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_CreatedCurves = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_UsersFunc = new System.Windows.Forms.TextBox();
            this.btn_AddGraphic = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txb_RightLim = new System.Windows.Forms.TextBox();
            this.txb_LeftLim = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_CreatedFigures = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_RefreshListBox = new System.Windows.Forms.Button();
            this.btn_ShowAllFigures = new System.Windows.Forms.Button();
            this.btn_ShowLines = new System.Windows.Forms.Button();
            this.btn_ChangePlotColor = new System.Windows.Forms.Button();
            this.pcb_PlotColor = new System.Windows.Forms.PictureBox();
            this.btn_Info = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_PlotColor)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 39);
            this.label6.TabIndex = 3;
            this.label6.Text = "Построение";
            // 
            // pnl_CreatedCurves
            // 
            this.pnl_CreatedCurves.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_CreatedCurves.AutoScroll = true;
            this.pnl_CreatedCurves.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_CreatedCurves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_CreatedCurves.Location = new System.Drawing.Point(3, 60);
            this.pnl_CreatedCurves.Name = "pnl_CreatedCurves";
            this.pnl_CreatedCurves.Size = new System.Drawing.Size(427, 142);
            this.pnl_CreatedCurves.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Графики:";
            // 
            // txb_UsersFunc
            // 
            this.txb_UsersFunc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_UsersFunc.BackColor = System.Drawing.SystemColors.Control;
            this.txb_UsersFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_UsersFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_UsersFunc.Location = new System.Drawing.Point(3, 202);
            this.txb_UsersFunc.Name = "txb_UsersFunc";
            this.txb_UsersFunc.Size = new System.Drawing.Size(427, 23);
            this.txb_UsersFunc.TabIndex = 31;
            // 
            // btn_AddGraphic
            // 
            this.btn_AddGraphic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddGraphic.AutoSize = true;
            this.btn_AddGraphic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddGraphic.Location = new System.Drawing.Point(317, 226);
            this.btn_AddGraphic.Name = "btn_AddGraphic";
            this.btn_AddGraphic.Size = new System.Drawing.Size(83, 30);
            this.btn_AddGraphic.TabIndex = 46;
            this.btn_AddGraphic.Text = "Добавить";
            this.btn_AddGraphic.UseVisualStyleBackColor = true;
            this.btn_AddGraphic.Click += new System.EventHandler(this.btn_AddGraphic_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(305, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 16);
            this.label15.TabIndex = 45;
            this.label15.Text = "]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(239, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 18);
            this.label14.TabIndex = 44;
            this.label14.Text = ";";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(173, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 16);
            this.label13.TabIndex = 43;
            this.label13.Text = "[";
            // 
            // txb_RightLim
            // 
            this.txb_RightLim.BackColor = System.Drawing.SystemColors.Control;
            this.txb_RightLim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_RightLim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_RightLim.Location = new System.Drawing.Point(252, 231);
            this.txb_RightLim.Name = "txb_RightLim";
            this.txb_RightLim.Size = new System.Drawing.Size(53, 22);
            this.txb_RightLim.TabIndex = 42;
            // 
            // txb_LeftLim
            // 
            this.txb_LeftLim.BackColor = System.Drawing.SystemColors.Control;
            this.txb_LeftLim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_LeftLim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_LeftLim.Location = new System.Drawing.Point(186, 231);
            this.txb_LeftLim.Name = "txb_LeftLim";
            this.txb_LeftLim.Size = new System.Drawing.Size(53, 22);
            this.txb_LeftLim.TabIndex = 41;
            this.txb_LeftLim.WordWrap = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(0, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 17);
            this.label12.TabIndex = 40;
            this.label12.Text = "Интервал построения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(5, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Цвет кривой: \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Фигуры:";
            // 
            // lst_CreatedFigures
            // 
            this.lst_CreatedFigures.FormattingEnabled = true;
            this.lst_CreatedFigures.Location = new System.Drawing.Point(3, 356);
            this.lst_CreatedFigures.Name = "lst_CreatedFigures";
            this.lst_CreatedFigures.Size = new System.Drawing.Size(302, 134);
            this.lst_CreatedFigures.TabIndex = 54;
            this.lst_CreatedFigures.DoubleClick += new System.EventHandler(this.lst_CreatedFigures_DoubleClick);
            // 
            // btn_RefreshListBox
            // 
            this.btn_RefreshListBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_RefreshListBox.FlatAppearance.BorderSize = 0;
            this.btn_RefreshListBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RefreshListBox.Image = global::GraphicBuilder.Properties.Resources.refresh_25;
            this.btn_RefreshListBox.Location = new System.Drawing.Point(308, 418);
            this.btn_RefreshListBox.Name = "btn_RefreshListBox";
            this.btn_RefreshListBox.Size = new System.Drawing.Size(25, 25);
            this.btn_RefreshListBox.TabIndex = 56;
            this.btn_RefreshListBox.UseVisualStyleBackColor = false;
            this.btn_RefreshListBox.Click += new System.EventHandler(this.btn_RefreshListBox_Click);
            // 
            // btn_ShowAllFigures
            // 
            this.btn_ShowAllFigures.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ShowAllFigures.Enabled = false;
            this.btn_ShowAllFigures.FlatAppearance.BorderSize = 0;
            this.btn_ShowAllFigures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowAllFigures.Image = global::GraphicBuilder.Properties.Resources.figures_25px;
            this.btn_ShowAllFigures.Location = new System.Drawing.Point(308, 387);
            this.btn_ShowAllFigures.Name = "btn_ShowAllFigures";
            this.btn_ShowAllFigures.Size = new System.Drawing.Size(25, 25);
            this.btn_ShowAllFigures.TabIndex = 56;
            this.toolTip1.SetToolTip(this.btn_ShowAllFigures, "Показать все фигуры");
            this.btn_ShowAllFigures.UseVisualStyleBackColor = false;
            // 
            // btn_ShowLines
            // 
            this.btn_ShowLines.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ShowLines.FlatAppearance.BorderSize = 0;
            this.btn_ShowLines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowLines.Image = global::GraphicBuilder.Properties.Resources.line_25px;
            this.btn_ShowLines.Location = new System.Drawing.Point(308, 356);
            this.btn_ShowLines.Name = "btn_ShowLines";
            this.btn_ShowLines.Size = new System.Drawing.Size(25, 25);
            this.btn_ShowLines.TabIndex = 55;
            this.toolTip1.SetToolTip(this.btn_ShowLines, "Показать только прямые линии");
            this.btn_ShowLines.UseVisualStyleBackColor = false;
            // 
            // btn_ChangePlotColor
            // 
            this.btn_ChangePlotColor.FlatAppearance.BorderSize = 0;
            this.btn_ChangePlotColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangePlotColor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangePlotColor.Image = global::GraphicBuilder.Properties.Resources.imgonline_com_ua_Resize_fS0FFiRVBrr6x88Q;
            this.btn_ChangePlotColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChangePlotColor.Location = new System.Drawing.Point(139, 265);
            this.btn_ChangePlotColor.Name = "btn_ChangePlotColor";
            this.btn_ChangePlotColor.Size = new System.Drawing.Size(36, 34);
            this.btn_ChangePlotColor.TabIndex = 52;
            this.btn_ChangePlotColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ChangePlotColor.UseVisualStyleBackColor = true;
            this.btn_ChangePlotColor.Click += new System.EventHandler(this.Change_Colour_Click);
            // 
            // pcb_PlotColor
            // 
            this.pcb_PlotColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcb_PlotColor.Location = new System.Drawing.Point(113, 269);
            this.pcb_PlotColor.Name = "pcb_PlotColor";
            this.pcb_PlotColor.Size = new System.Drawing.Size(25, 25);
            this.pcb_PlotColor.TabIndex = 51;
            this.pcb_PlotColor.TabStop = false;
            // 
            // btn_Info
            // 
            this.btn_Info.AutoSize = true;
            this.btn_Info.FlatAppearance.BorderSize = 0;
            this.btn_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Info.Image = global::GraphicBuilder.Properties.Resources.newInfo_25px;
            this.btn_Info.Location = new System.Drawing.Point(409, 226);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(33, 32);
            this.btn_Info.TabIndex = 49;
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // AddGraph
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_RefreshListBox);
            this.Controls.Add(this.btn_ShowAllFigures);
            this.Controls.Add(this.btn_ShowLines);
            this.Controls.Add(this.lst_CreatedFigures);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ChangePlotColor);
            this.Controls.Add(this.pcb_PlotColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.btn_AddGraphic);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txb_RightLim);
            this.Controls.Add(this.txb_LeftLim);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txb_UsersFunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_CreatedCurves);
            this.Controls.Add(this.label6);
            this.Name = "AddGraph";
            this.Size = new System.Drawing.Size(454, 507);
            this.Load += new System.EventHandler(this.AddGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_PlotColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnl_CreatedCurves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_UsersFunc;
        private System.Windows.Forms.Button btn_AddGraphic;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txb_RightLim;
        private System.Windows.Forms.TextBox txb_LeftLim;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.Button btn_ChangePlotColor;
        private System.Windows.Forms.PictureBox pcb_PlotColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_CreatedFigures;
        private System.Windows.Forms.Button btn_ShowLines;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_ShowAllFigures;
        private System.Windows.Forms.Button btn_RefreshListBox;
    }
}
