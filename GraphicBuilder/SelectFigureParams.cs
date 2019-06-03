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

        PointF CenterLoction;
        double Length;

        public SelectFigureParams(Figure f)
        {
            figure = f;
            InitializeComponent();
        }

        //private void CreateControls()
        //{
        //    panel2.Controls.Clear();

        //    if (figure is Line)
        //    {
        //        Label lb_coord = new Label()
        //        {
        //            Location = new Point(0, 5),
        //            AutoSize = true,
        //            Text = "Координата центра(X;Y): ",
        //            Font = this.Font
        //        };
        //        this.panel2.Controls.Add(lb_coord);
        //        TextBox txbCoord = new TextBox()
        //        {
        //            Location = new Point(lb_coord.Size.Width + 5, 3),
        //            Font = this.Font,
        //            BackColor = Color.White,
        //            Size = new Size(50, 20),
        //            BorderStyle = BorderStyle.FixedSingle,

        //        };
        //        this.panel2.Controls.Add(txbCoord);
        //        Label lb_length = new Label()
        //        {
        //            Location = new Point(0, txbCoord.Size.Height + 5),
        //            Text = "Длинна: ",
        //            Font = this.Font,
        //            AutoSize = true
        //        };
        //        this.panel2.Controls.Add(lb_length);
        //        TextBox txbLength = new TextBox()
        //        {
        //            Name = "af",
        //            Location = new Point(lb_length.Size.Width + 5, lb_length.Location.Y),
        //            Font = this.Font,
        //            BackColor = Color.White,
        //            Size = new Size(50, 20),
        //            BorderStyle = BorderStyle.FixedSingle,

        //        };
                
        //        this.panel2.Controls.Add(txbLength);
                

        //    }
        //}

        private void SelectLine()
        {
            
        }

        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectFigureParams_Load(object sender, EventArgs e)
        {
            
        }
    }
}
