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
    public partial class SelectFigureParams : Form
    {
        Figure figure;

        public PointF CenterLoction;
        public PointF BeginCoord, EndCoord;


        public SelectFigureParams(Figure f)
        {
            figure = f;
            InitializeComponent();
        }
        
        private void InitParams()
        {
            if (figure is Line)
            {
                txb_Begin.Text = Math.Round(figure.Begin.X, 2) + " " + Math.Round(figure.Begin.Y, 2);
                txb_End.Text = Math.Round(figure.End.X, 2) + " " + Math.Round(figure.End.Y, 2);
            }
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectFigureParams_Load(object sender, EventArgs e)
        {
            InitParams();
        }

        private void btn_ApplyChanges_Click(object sender, EventArgs e)
        {
            if (figure is Line)
            {
                
                string[] el = txb_Begin.Text.Split(' ');
                if (el[0] != "" && el[1] != "")
                    BeginCoord = new PointF(float.Parse(el[0]), float.Parse(el[1]));

                el = txb_End.Text.Split(' ');
                if (el[0] != "" && el[1] != "")
                    EndCoord = new PointF(float.Parse(el[0]), float.Parse(el[1]));
            }
            this.Close();
        }
        
    }
}
