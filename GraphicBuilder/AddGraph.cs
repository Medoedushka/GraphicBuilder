using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDrawing;
using Mathos;

namespace GraphicBuilder
{
    public partial class AddGraph : UserControl
    {
        public List<Label> labelList = new List<Label>();
        public List<TextBox> textBoxList = new List<TextBox>();
        public List<Button> buttonList = new List<Button>();
        int brightness;
        Panel EmtyTxb;

        Mathos.Parser.MathParser parser;
        int preX, preY = 5;

        public void ResetParams()
        {
            labelList.Clear();
            textBoxList.Clear();
            buttonList.Clear();
            RefreshPanel();
            preX = 0; preY = 5;
        }


        public PointF[] GetPoints(double a, double b, int numberOfPoints, string func)
        {
            double step = Math.Abs(b - a) / numberOfPoints;
            PointF[] points = new PointF[numberOfPoints];
            for (int i = 0; i <= numberOfPoints; i++)
            {
                string x = Convert.ToString(a + i * step);

                string strX = x.ToString().Replace(",", ".");

                parser.ProgrammaticallyParse("let x = " + strX);
                if (i == numberOfPoints)
                {
                    x = strX.Replace(".", ",");
                    points[i - 1] = new PointF(float.Parse(x), (float)parser.Parse(func));
                }

                else
                {
                    points[i] = new PointF(float.Parse(x), (float)parser.Parse(func));

                }

            }

            return points;
        }

        private void btn_AddGraphic_Click(object sender, EventArgs e)
        {
            parser = new Mathos.Parser.MathParser();

            if (txb_UsersFunc.Text != "" && txb_LeftLim.Text != "" && txb_RightLim.Text != "")
            {
                double A = double.Parse(txb_LeftLim.Text);
                double B = double.Parse(txb_RightLim.Text);
                PointF[] pt = GetPoints(A, B, 1000, txb_UsersFunc.Text);
                Curves curve1;
                if (txb_CurveColor.Text != "")
                {
                    string[] el = txb_CurveColor.Text.Split(',');
                    Color curveColor = Color.FromArgb(Int32.Parse(el[0]), Int32.Parse(el[1]), Int32.Parse(el[2]));
                    curve1 = new Curves(pt, curveColor, Legend: txb_UsersFunc.Text);
                }
                else curve1 = new Curves(pt, Color.Red, Legend: txb_UsersFunc.Text);

                try
                {
                    MainForm.graph.AddCurve(curve1);
                    AddGraphToList(txb_UsersFunc.Text, curve1.CurveColor);
                    RefreshPanel();
                }
                catch(ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                
                return;
            }
            
        }

        private void AddGraphToList(string func, Color color)
        {
            labelList.Add(new Label()
            {
                Text = func,
                Location = new Point(preX, preY),
                Font = new Font("Arial", 10)
            });
            textBoxList.Add(new TextBox()
            {
                Location = new Point(preX + func.Length + 35, preY),
                BackColor = color,
                Size = new Size(29, 20),
                ReadOnly = true,
                Enabled = false,
                BorderStyle = BorderStyle.None
            });
            buttonList.Add(new Button()
            {

                FlatStyle = FlatStyle.Flat,
                Image = Properties.Resources.Newcross_20px,
                Location = new Point(preX + func.Length + 70, preY),
                Size = new Size(21, 22),
                UseVisualStyleBackColor = true
            });
            preY += 50;
        }

        public void RefreshPanel()
        {
            pnl_CreatedCurves.Controls.Clear();

            foreach (Button btn in buttonList)
            {
                pnl_CreatedCurves.Controls.Add(btn);
                foreach (TextBox txb in textBoxList)
                {
                    pnl_CreatedCurves.Controls.Add(txb);
                    foreach (Label lbl in labelList)
                    {
                        pnl_CreatedCurves.Controls.Add(lbl);
                    }
                }
            }
        }

        

        public AddGraph()
        {
            InitializeComponent();
        }


    }
}
