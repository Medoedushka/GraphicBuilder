namespace GraphicBuilder
{
    partial class ChangeLBL
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resultLBL = new GraphicBuilder.TextLabel();
            this.btn_ChangeTextFont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите новый текст:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultLBL
            // 
            this.resultLBL.AutoSize = true;
            this.resultLBL.Location = new System.Drawing.Point(2, 60);
            this.resultLBL.Name = "resultLBL";
            this.resultLBL.Size = new System.Drawing.Size(43, 15);
            this.resultLBL.TabIndex = 3;
            this.resultLBL.Text = "Result";
            // 
            // btn_ChangeTextFont
            // 
            this.btn_ChangeTextFont.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ChangeTextFont.Image = global::GraphicBuilder.Properties.Resources.more_20px;
            this.btn_ChangeTextFont.Location = new System.Drawing.Point(246, 27);
            this.btn_ChangeTextFont.Name = "btn_ChangeTextFont";
            this.btn_ChangeTextFont.Size = new System.Drawing.Size(29, 22);
            this.btn_ChangeTextFont.TabIndex = 11;
            this.btn_ChangeTextFont.UseVisualStyleBackColor = true;
            this.btn_ChangeTextFont.Click += new System.EventHandler(this.btn_ChangeTextFont_Click);
            // 
            // ChangeLBL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 84);
            this.Controls.Add(this.btn_ChangeTextFont);
            this.Controls.Add(this.resultLBL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChangeLBL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeLBL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        private TextLabel resultLBL;
        private System.Windows.Forms.Button btn_ChangeTextFont;
    }
}