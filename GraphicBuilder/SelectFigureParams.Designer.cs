namespace GraphicBuilder
{
    partial class SelectFigureParams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectFigureParams));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ApplyChanges = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gb_Line = new System.Windows.Forms.GroupBox();
            this.txb_End = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_Begin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gb_Line.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(179)))));
            this.panel1.Controls.Add(this.btn_ApplyChanges);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 32);
            this.panel1.TabIndex = 0;
            // 
            // btn_ApplyChanges
            // 
            this.btn_ApplyChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(179)))));
            this.btn_ApplyChanges.FlatAppearance.BorderSize = 0;
            this.btn_ApplyChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ApplyChanges.Image = ((System.Drawing.Image)(resources.GetObject("btn_ApplyChanges.Image")));
            this.btn_ApplyChanges.Location = new System.Drawing.Point(352, 4);
            this.btn_ApplyChanges.Name = "btn_ApplyChanges";
            this.btn_ApplyChanges.Size = new System.Drawing.Size(25, 25);
            this.btn_ApplyChanges.TabIndex = 0;
            this.btn_ApplyChanges.UseVisualStyleBackColor = false;
            this.btn_ApplyChanges.Click += new System.EventHandler(this.btn_ApplyChanges_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите новые параметры для фигуры";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(155)))), ((int)(((byte)(168)))));
            this.panel2.Controls.Add(this.gb_Line);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 183);
            this.panel2.TabIndex = 1;
            // 
            // gb_Line
            // 
            this.gb_Line.Controls.Add(this.txb_End);
            this.gb_Line.Controls.Add(this.label4);
            this.gb_Line.Controls.Add(this.txb_Begin);
            this.gb_Line.Controls.Add(this.label3);
            this.gb_Line.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_Line.Location = new System.Drawing.Point(12, 6);
            this.gb_Line.Name = "gb_Line";
            this.gb_Line.Size = new System.Drawing.Size(285, 72);
            this.gb_Line.TabIndex = 0;
            this.gb_Line.TabStop = false;
            this.gb_Line.Text = "Параметры линии";
            // 
            // txb_End
            // 
            this.txb_End.Location = new System.Drawing.Point(192, 40);
            this.txb_End.Name = "txb_End";
            this.txb_End.Size = new System.Drawing.Size(69, 22);
            this.txb_End.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Координаты конца линии(X Y):";
            // 
            // txb_Begin
            // 
            this.txb_Begin.Location = new System.Drawing.Point(200, 16);
            this.txb_Begin.Name = "txb_Begin";
            this.txb_Begin.Size = new System.Drawing.Size(69, 22);
            this.txb_Begin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Координаты начала линии(X Y):";
            // 
            // SelectFigureParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 215);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectFigureParams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectFigureParams";
            this.Load += new System.EventHandler(this.SelectFigureParams_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gb_Line.ResumeLayout(false);
            this.gb_Line.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ApplyChanges;
        private System.Windows.Forms.GroupBox gb_Line;
        private System.Windows.Forms.TextBox txb_End;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_Begin;
        private System.Windows.Forms.Label label3;
    }
}