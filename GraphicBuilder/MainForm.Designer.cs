﻿namespace GraphicBuilder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_StepOY = new System.Windows.Forms.Label();
            this.lbl_StepOX = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_CenterLEFT = new System.Windows.Forms.Button();
            this.btn_CenterRIGHT = new System.Windows.Forms.Button();
            this.btn_CenterDOWN = new System.Windows.Forms.Button();
            this.btn_CenterUP = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(220)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.button5);
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
            this.panel1.Location = new System.Drawing.Point(0, 633);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 41);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(603, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 633);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 633);
            this.panel3.TabIndex = 2;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(190)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 633);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::GraphicBuilder.Properties.Resources.plus25px;
            this.button5.Location = new System.Drawing.Point(968, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 41);
            this.button5.TabIndex = 35;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::GraphicBuilder.Properties.Resources.newpears_25px;
            this.button2.Location = new System.Drawing.Point(1010, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 41);
            this.button2.TabIndex = 34;
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
            this.ClientSize = new System.Drawing.Size(1052, 674);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Построение графика функции";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_CenterLEFT;
        private System.Windows.Forms.Button btn_CenterRIGHT;
        private System.Windows.Forms.Button btn_CenterDOWN;
        private System.Windows.Forms.Button btn_CenterUP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_StepOY;
        private System.Windows.Forms.Label lbl_StepOX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

