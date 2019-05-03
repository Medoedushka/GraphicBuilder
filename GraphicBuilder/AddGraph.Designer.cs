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
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_CreatedCurves = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_UsersFunc = new System.Windows.Forms.TextBox();
            this.txb_CurveColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddGraphic = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txb_RightLim = new System.Windows.Forms.TextBox();
            this.txb_LeftLim = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 42);
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
            this.pnl_CreatedCurves.Size = new System.Drawing.Size(443, 142);
            this.pnl_CreatedCurves.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
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
            this.txb_UsersFunc.Size = new System.Drawing.Size(443, 23);
            this.txb_UsersFunc.TabIndex = 31;
            // 
            // txb_CurveColor
            // 
            this.txb_CurveColor.BackColor = System.Drawing.SystemColors.Control;
            this.txb_CurveColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_CurveColor.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CurveColor.Location = new System.Drawing.Point(125, 257);
            this.txb_CurveColor.Name = "txb_CurveColor";
            this.txb_CurveColor.Size = new System.Drawing.Size(53, 22);
            this.txb_CurveColor.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Цвет кривой(Р,Г,Б):";
            // 
            // btn_AddGraphic
            // 
            this.btn_AddGraphic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddGraphic.Location = new System.Drawing.Point(324, 227);
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
            this.label13.AutoSize = true;
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
            this.txb_RightLim.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_RightLim.Location = new System.Drawing.Point(252, 231);
            this.txb_RightLim.Name = "txb_RightLim";
            this.txb_RightLim.Size = new System.Drawing.Size(53, 22);
            this.txb_RightLim.TabIndex = 42;
            // 
            // txb_LeftLim
            // 
            this.txb_LeftLim.BackColor = System.Drawing.SystemColors.Control;
            this.txb_LeftLim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_LeftLim.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txb_LeftLim.Location = new System.Drawing.Point(186, 231);
            this.txb_LeftLim.Name = "txb_LeftLim";
            this.txb_LeftLim.Size = new System.Drawing.Size(53, 22);
            this.txb_LeftLim.TabIndex = 41;
            this.txb_LeftLim.WordWrap = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 22);
            this.label12.TabIndex = 40;
            this.label12.Text = "Интервал построения:";
            // 
            // btn_Info
            // 
            this.btn_Info.FlatAppearance.BorderSize = 0;
            this.btn_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Info.Image = global::GraphicBuilder.Properties.Resources.newInfo_25px;
            this.btn_Info.Location = new System.Drawing.Point(413, 225);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(33, 32);
            this.btn_Info.TabIndex = 49;
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // AddGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.txb_CurveColor);
            this.Controls.Add(this.label2);
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
            this.Size = new System.Drawing.Size(449, 507);
            this.Load += new System.EventHandler(this.AddGraph_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnl_CreatedCurves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_UsersFunc;
        private System.Windows.Forms.TextBox txb_CurveColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddGraphic;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txb_RightLim;
        private System.Windows.Forms.TextBox txb_LeftLim;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Info;
    }
}
