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
        //списки элементов управления на панели для добавления кривых
        public List<Label> labelList = new List<Label>();
        public List<TextBox> textBoxList = new List<TextBox>();
        public List<Button> buttonList = new List<Button>();
        Mathos.Parser.MathParser parser; //объек, использующийся для преобразования строки формулы
        int preX, preY = 5; //начальные значения координат элементов управления на панели с сущ кривыми

        public Color CurveColor = Color.Red;

        //сброс параметров
        public void ResetParams()
        {
            labelList.Clear();
            textBoxList.Clear();
            buttonList.Clear();
            RefreshPanel();
            preX = 0; preY = 5;
        }

        //расчёт точек для построения кривой
        private PointF[] GetPoints(double a, double b, int numberOfPoints, string func)
        {
            double step = Math.Abs(b - a) / numberOfPoints;
            PointF[] points = new PointF[numberOfPoints];
            for (int i = 0; i <= numberOfPoints; i++)
            {
                string x = Convert.ToString(a + i * step);
                parser.ProgrammaticallyParse("let x = " + x.ToString().Replace(",", "."));
                if (i == numberOfPoints) points[i - 1] = new PointF(float.Parse(x), (float)parser.Parse(func.Replace(",", ".")));
                else points[i] = new PointF(float.Parse(x), (float)parser.Parse(func.Replace(",", ".")));
               
            }

            return points;
        }

        //добавления новой кривой в список
        private void btn_AddGraphic_Click(object sender, EventArgs e)
        {
            parser = new Mathos.Parser.MathParser();
            PointF[] pt = null;

            if (txb_UsersFunc.Text != "" && txb_LeftLim.Text != "" && txb_RightLim.Text != "")
            {
                double A = 0 , B = 0; //нижний и верхний пределы области построения
                try
                {
                     A = double.Parse(txb_LeftLim.Text);
                     B = double.Parse(txb_RightLim.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ошибка при вводе значений интервала.", "Ошибка ввода",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    pt = GetPoints(A, B, 2000, txb_UsersFunc.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введён неверный формат функции: 'func(x)'.", "Ошибка ввода",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("Функция такого вида не присутствует в списке.", "Ошибка ввода",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Curves curve1;
                Color curveColor = CurveColor;

                // sorry :(

                //if (txb_CurveColor.Text != "")
                //{
                //    string[] el = txb_CurveColor.Text.Split(',');
                //    try
                //    {
                //        curveColor = Color.FromArgb(Int32.Parse(el[0]), Int32.Parse(el[1]), Int32.Parse(el[2]));
                //    }
                //    catch (FormatException)
                //    {
                //        MessageBox.Show("Введён неверный формат цвета кривой: 'Р,Г,Б'.", "Ошибка ввода",
                //        MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }

                curve1 = new Curves(pt, curveColor, Legend: txb_UsersFunc.Text);

                //}
                //else curve1 = new Curves(pt, Color.Red, Legend: txb_UsersFunc.Text);

                DialogResult result;
                try
                {
                    MainForm.graph.AddCurve(curve1);
                    AddGraphToList(txb_UsersFunc.Text, curve1.CurveColor);
                    RefreshPanel();
                }
                catch (ArgumentException ex)
                {
                    result = MessageBox.Show(ex.Message + "\nВсё равно добавить?",
                        "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        MainForm.graph.GraphCurves.Add(curve1);
                        AddGraphToList(txb_UsersFunc.Text, curve1.CurveColor);
                        RefreshPanel();
                    }
                }
            }
            else return;
        }

        //добавления элементов управления соответствующей кривой в коллеции
        public void AddGraphToList(string func, Color color)
        {
            Button bt;
            Graphics temp = pnl_CreatedCurves.CreateGraphics();
            SizeF size = temp.MeasureString(func, new Font("Arial", 10));
            temp.Dispose();

            labelList.Add(new Label()
            {
                Text = func,
                Location = new Point(preX, preY),
                Font = new Font("Arial", 10)
            });
            textBoxList.Add(new TextBox()
            {
                Location = new Point(preX + (int)size.Width + 5, preY),
                BackColor = color,
                Size = new Size(29, 20),
                ReadOnly = true,
                Enabled = false,
                BorderStyle = BorderStyle.None
                
            });
            bt = new Button()
            {

                FlatStyle = FlatStyle.Flat,
                Image = Properties.Resources.Newcross_20px,
                Location = new Point(preX + (int)size.Width + 40, preY),
                Size = new Size(21, 22),
                UseVisualStyleBackColor = true,
                
            };
            bt.Click += new EventHandler(DeleteCurve_Click);
            
            buttonList.Add(bt);
            preY += 50;
        }

        //обновляет элементы управления на панели
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

        private void btn_Info_Click(object sender, EventArgs e)
        {
           
        }

        //удаление элементов управления, Location.Y которых, равны. Метод вызывается при нажатии кнопки
        private void DeleteCurve_Click(object sender, EventArgs e)
        {
            Button crrButton = (Button)sender;
            int delY = crrButton.Location.Y;

            Label delLB = null;
            foreach(Label lb in labelList)
            {
                if (lb.Location.Y == crrButton.Location.Y)
                {
                    foreach (Curves curve in MainForm.graph.GraphCurves)
                    {
                        if (lb.Text == curve.Legend)
                        {
                            MainForm.graph.GraphCurves.Remove(curve);
                            break;
                        }
                    }
                    delLB = lb;
                    continue;
                }
                else if (lb.Location.Y > delY) lb.Location = new Point(lb.Location.X, lb.Location.Y - 50);
            }
            labelList.Remove(delLB);
            TextBox delTXB = null;
            foreach(TextBox txb in textBoxList)
            {
                if (txb.Location.Y == crrButton.Location.Y)
                {
                    delTXB = txb;
                    continue;
                }
                else if (txb.Location.Y > delY) txb.Location = new Point(txb.Location.X, txb.Location.Y - 50);
            }
            textBoxList.Remove(delTXB);

            foreach(Button btn in buttonList)
            {
                if(btn.Location.Y > delY) btn.Location = new Point(btn.Location.X, btn.Location.Y - 50);
            }
            buttonList.Remove(crrButton);
            if (labelList.Count == 0 && textBoxList.Count == 0 && buttonList.Count == 0)
            {
                ResetParams();
            }
            else RefreshPanel();
            preY -= 50;
            MainForm.graph.DrawDiagram();
        }

        private void AddGraph_Load(object sender, EventArgs e)
        {
            RefreshPanel();
            //hello, honey budger
            this.Width = Parent.Width;

            //вывод список созданных фигур
            foreach(Line ln in MainForm.Figures.Lines)
            {
                lst_CreatedFigures.Items.Add(ln.Name);
            }
        }

        // hello, honey budger
        private void Change_Colour_Click(object sender, EventArgs e)
        {
            DialogResult result; ColorDialog colorDialog;
            using (colorDialog = new ColorDialog())
            {
                colorDialog.FullOpen = true;
                colorDialog.Color = MainForm.graph.placeToDraw.BackColor;
                result = colorDialog.ShowDialog();
            }
            if (result == DialogResult.OK)
            {
                //sorry again  
                //MainForm.graph.placeToDraw.BackColor = colorDialog.Color;
                pcb_PlotColor.BackColor = colorDialog.Color;
                //MainForm.graph.DrawDiagram();
                CurveColor = colorDialog.Color;
            }
        }

        private void lst_CreatedFigures_DoubleClick(object sender, EventArgs e)
        {
            foreach(Line ln in MainForm.Figures.Lines)
            {
                if (ln.Name == lst_CreatedFigures.SelectedItem.ToString()) ln.DrawLine();
            }
        }

        private void btn_RefreshListBox_Click(object sender, EventArgs e)
        {
            lst_CreatedFigures.Items.Clear();
            
                foreach (Line ln in MainForm.Figures.Lines)
                {
                    lst_CreatedFigures.Items.Add(ln.Name);
                }
            
        }

        public AddGraph()
        {
            InitializeComponent();
        }


    }
}
