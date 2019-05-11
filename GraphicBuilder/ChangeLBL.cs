using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicBuilder
{
    public partial class ChangeLBL : Form
    {
        public static string lbl_Text { get; set; }
        public static Font lbl_Font { get; set; }
        public static Color lbl_Color { get; set; }

        public ChangeLBL()
        {
            InitializeComponent();
        }

        private void ChangeLBL_Load(object sender, EventArgs e)
        {
            resultLBL.Text = lbl_Text;
            resultLBL.Font = lbl_Font;
            resultLBL.ForeColor = lbl_Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                lbl_Text = textBox1.Text;

            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            resultLBL.Text = textBox1.Text;
        }

        private void btn_ChangeTextFont_Click(object sender, EventArgs e)
        {
            DialogResult result; FontDialog font;
            using (font = new FontDialog())
            {
                font.ShowColor = true;
                font.Font = lbl_Font;
                font.Color = lbl_Color;
                result = font.ShowDialog();
            }
            if (result == DialogResult.OK)
            {
                resultLBL.Font = lbl_Font = font.Font;
                resultLBL.ForeColor = lbl_Color = font.Color;
                
            }
        }

        
    }
}
