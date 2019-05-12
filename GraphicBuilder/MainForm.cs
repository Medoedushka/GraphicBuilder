﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyDrawing;
using Newtonsoft.Json;
using Mathos;
using System.IO;
using System.Threading;

namespace GraphicBuilder
{
    public partial class MainForm : Form
    {
        public static PointsGraphic graph;
        AddGraph addGraph;
        MainSettings mainSettings;

        int ShiftOX; //результирующее смещение центра по оси ОХ
        int ShiftOY; //результирующее смещение центра по оси ОY

        bool Hidden { get; set; }

        public static string TextValue;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            graph = new PointsGraphic(pictureBox1, AxesMode.Static, AxesPosition.AllQuarters);
            addGraph = new AddGraph()
            {
                Location = new Point(0, 0),
                Dock = DockStyle.Right
            };
            Hidden = false;
            cmb_PriceOX.Text = graph.Config.PriceForPointOX.ToString();
            cmb_PriceOY.Text = graph.Config.PriceForPointOY.ToString();
            graph.Config.Grid = true;
            graph.Config.SmoothAngles = true;
            //hello, honey budger
            pnl_Windows.Width =(int) (this.Width / 3.5);
        }

        #region StaticCameraMoving
        enum Param
        {
            StepOX,
            StepOY,
            RCenterPosX,
            RCenterPosY
        }
        Param crrParam; //текущий изменяемый параметр
        int value; //величина, на которую происзодит изменение
        private void ChangeParams(Param param, int value)
        {
            if (param == Param.StepOX) graph.Config.StepOX += value;

            if (param == Param.StepOY) graph.Config.StepOY += value;

            if (param == Param.RCenterPosX)
            {
                graph.RealCenter = new Point(graph.RealCenter.X + value, graph.RealCenter.Y);
                ShiftOX += value;
            }
           
            if (param == Param.RCenterPosY)
            {
                graph.RealCenter = new Point(graph.RealCenter.X, graph.RealCenter.Y + value);
                ShiftOY += value;
            }
                
            graph.DrawDiagram();
        }

        private void tmr_ChangeMainParams_Tick(object sender, EventArgs e)
        {
            ChangeParams(crrParam, value);
        }

        private void btn_CenterLEFT_MouseDown(object sender, MouseEventArgs e)
        {
            crrParam = Param.RCenterPosX; value = 5;
            tmr_ChangeMainParams.Start();
        }
        private void btn_CenterLEFT_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_ChangeMainParams.Stop();
        }

        private void btn_CenterRIGHT_MouseDown(object sender, MouseEventArgs e)
        {
            crrParam = Param.RCenterPosX; value = -5;
            tmr_ChangeMainParams.Start();
        }
        private void btn_CenterRIGHT_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_ChangeMainParams.Stop();
        }

        private void btn_CenterUP_MouseDown(object sender, MouseEventArgs e)
        {
            crrParam = Param.RCenterPosY; value = 5;
            tmr_ChangeMainParams.Start();
        }
        private void btn_CenterUP_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_ChangeMainParams.Stop();
        }

        private void btn_CenterDOWN_MouseDown(object sender, MouseEventArgs e)
        {
            crrParam = Param.RCenterPosY; value = -5;
            tmr_ChangeMainParams.Start();
        }
        private void btn_CenterDOWN_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_ChangeMainParams.Stop();
        }

        private void btn_IncreaseOX_MouseDown(object sender, MouseEventArgs e)
        {
            crrParam = Param.StepOX; value = 5;
            tmr_ChangeMainParams.Start();
        }
        private void btn_IncreaseOX_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_ChangeMainParams.Stop();
        }

        private void btn_DecreaseOX_MouseDown(object sender, MouseEventArgs e)
        {
            crrParam = Param.StepOX; value = -5;
            tmr_ChangeMainParams.Start();
        }
        private void btn_DecreaseOX_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_ChangeMainParams.Stop();
        }

        private void btn_IncreaseOY_MouseDown(object sender, MouseEventArgs e)
        {
            crrParam = Param.StepOY; value = 5;
            tmr_ChangeMainParams.Start();
        }
        private void btn_IncreaseOY_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_ChangeMainParams.Stop();
        }

        private void btn_DecreaseOY_MouseDown(object sender, MouseEventArgs e)
        {
            crrParam = Param.StepOY; value = -5;
            tmr_ChangeMainParams.Start();
        }
        private void btn_DecreaseOY_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_ChangeMainParams.Stop();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                crrParam = Param.RCenterPosY; value = 5;
                tmr_ChangeMainParams.Start();
            }
            else if (e.KeyCode == Keys.S)
            {
                crrParam = Param.RCenterPosY; value = -5;
                tmr_ChangeMainParams.Start();
            }
            else if (e.KeyCode == Keys.D)
            {
                crrParam = Param.RCenterPosX; value = -5;
                tmr_ChangeMainParams.Start();
            }
            else if (e.KeyCode == Keys.A)
            {
                crrParam = Param.RCenterPosX; value = 5;
                tmr_ChangeMainParams.Start();
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            tmr_ChangeMainParams.Stop();
        }
        #endregion

        #region Tools
        bool CutMode { get; set; }
        bool CountSquare { get; set; }

        byte numLines = 0;
        byte Lines = 0;
        int firstX, secondX;

        private void вырезатьОбластьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!CutMode && cmb_CutCurveLeg.Text != "")
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.FillRectangle(new SolidBrush(Color.FromArgb(100, 120, 120, 120)), new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                CutMode = true;
                g.Dispose();
            }
            else
            {
                CutMode = false;
                graph.DrawDiagram();
            }

        }
        private void рассчитатьПлощадьПодКривойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CountSquare && рассчитатьПлощадьПодКривойToolStripMenuItem.Checked == false)
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.FillRectangle(new SolidBrush(Color.FromArgb(100, 120, 120, 120)), new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                CountSquare = true;
                рассчитатьПлощадьПодКривойToolStripMenuItem.Checked = true;
                g.Dispose();
            }
            else
            {
                рассчитатьПлощадьПодКривойToolStripMenuItem.Checked = false;
                CountSquare = false;
                graph.DrawDiagram();
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //Рассчёт площади под графиком
            if (CountSquare)
            {
               
                Graphics g = pictureBox1.CreateGraphics();
                
                int MouseX = e.X;
                if (Lines < 2)
                {
                    g.DrawLine(new Pen(Color.Black), MouseX, pictureBox1.Height, MouseX, 0);
                    Lines++;
                    if (Lines == 1) firstX = MouseX;
                    else secondX = MouseX;
                }
                if (Lines == 2)
                {
                    int x1, x2; //пределы интегрирования в координатах pictureBox
                    if (secondX > firstX)
                    {
                        x1 = firstX;
                        x2 = secondX;
                    }
                    else if (firstX > secondX)
                    {
                        x1 = secondX;
                        x2 = firstX;
                    }
                    else
                    {
                        MessageBox.Show("Недопустимый интервал!");
                        return;
                    }
                    //ValueX1, ValueX2 - пределы интегрирования в прямоугольной системе координат
                    double ValueX1 = Math.Round((x1 - graph.RealCenter.X) * graph.Config.PriceForPointOX / graph.Config.StepOX, 1);
                    double ValueX2 = Math.Round((x2 - graph.RealCenter.X) * graph.Config.PriceForPointOX / graph.Config.StepOX, 1);
                    DialogResult result =
                    MessageBox.Show("Вы действительно хотите расчитать площадь под кривой на интервале от " + ValueX1.ToString() + " до " + ValueX2.ToString() + "?",
                        "Рассчёт площади под кривой", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (graph.GraphCurves.Count == 1)
                        {
                            int n = 5000;
                            Graphics g1 = pictureBox1.CreateGraphics();
                            PointF[] polygon = new PointF[4];
                            double X1Poly, X2Poly, Y1Poly, Y2Poly;
                            double delta = (ValueX2 - ValueX1) / n;
                            double square = 0;
                            double X1 = 0, Y1 = 0, X2 = 0, Y2 = 0;
                            for (int i = 0; i < n; i++)
                            {
                                X1 = ValueX1 + delta * i;
                                X1Poly = graph.RealCenter.X + X1 * graph.Config.StepOX / graph.Config.PriceForPointOX;
                                polygon[0].X = (float)X1Poly; polygon[0].Y = graph.RealCenter.Y;

                                foreach(Curves curve in graph.GraphCurves)
                                {
                                    if (curve.Legend == "sin(x)")
                                    {
                                        for (int j = 0; j < curve.PointsToDraw.Length; j++)
                                        {
                                            if (curve.PointsToDraw[0].X > X1) break;
                                            else if (curve.PointsToDraw[j].X == X1)
                                            {
                                                Y1 = Math.Round(curve.PointsToDraw[j].Y, 2);
                                                Y1Poly = graph.RealCenter.Y - Y1 * graph.Config.StepOY / graph.Config.PriceForPointOY;
                                                polygon[1].X = polygon[0].X; polygon[1].Y = (float)Y1Poly;
                                                break;
                                            }
                                            else if (curve.PointsToDraw[j].X > X1)
                                            {
                                                Y1 = (curve.PointsToDraw[j].Y - curve.PointsToDraw[j - 1].Y) / (curve.PointsToDraw[j].X - curve.PointsToDraw[j - 1].X) *
                                                    (X1 - curve.PointsToDraw[j - 1].X) + curve.PointsToDraw[j - 1].Y;
                                                Y1Poly = graph.RealCenter.Y - Y1 * graph.Config.StepOY / graph.Config.PriceForPointOY;
                                                polygon[1].X = polygon[0].X; polygon[1].Y = (float)Y1Poly;
                                                break;
                                            }
                                        }
                                    }
                                    
                                }
                               
                                X2 = X1 + delta;
                                X2Poly = graph.RealCenter.X + X2 * graph.Config.StepOX / graph.Config.PriceForPointOX;
                                polygon[3].X = (float)X2Poly; polygon[3].Y = graph.RealCenter.Y;
                                
                                foreach (Curves curve in graph.GraphCurves)
                                {
                                    if (curve.Legend == "sin(x)")
                                    {
                                        for (int j = 0; j < curve.PointsToDraw.Length; j++)
                                        {
                                            if (curve.PointsToDraw[0].X > X2) break;
                                            else if (curve.PointsToDraw[j].X == X2)
                                            {
                                                Y2 = Math.Round(curve.PointsToDraw[j].Y, 2);
                                                Y2Poly = graph.RealCenter.Y - Y2 * graph.Config.StepOY / graph.Config.PriceForPointOY;
                                                polygon[1].X = polygon[3].X; polygon[1].Y = (float)Y2Poly;
                                                break;
                                            }
                                            else if (curve.PointsToDraw[j].X > X2)
                                            {
                                                Y2 = (curve.PointsToDraw[j].Y - curve.PointsToDraw[j - 1].Y) / (curve.PointsToDraw[j].X - curve.PointsToDraw[j - 1].X) *
                                                    (X2 - curve.PointsToDraw[j - 1].X) + curve.PointsToDraw[j - 1].Y;
                                                Y2Poly = graph.RealCenter.Y - Y2 * graph.Config.StepOY / graph.Config.PriceForPointOY;
                                                polygon[2].X = polygon[3].X; polygon[2].Y = (float)Y2Poly;
                                                break;
                                            }
                                        }
                                    }

                                }
                                double k = (Y2 + Y1) * delta / 2;
                                square += k;
                                g.FillPolygon(new SolidBrush(Color.Red), polygon);
                            }
                            MessageBox.Show("Square: " + square);
                            Lines = 0;
                            firstX = secondX = 0;
                            рассчитатьПлощадьПодКривойToolStripMenuItem.Checked = false;
                            CountSquare = false;
                            graph.DrawDiagram();
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        Lines = 0;
                        firstX = secondX = 0;
                        рассчитатьПлощадьПодКривойToolStripMenuItem.Checked = false;
                        CountSquare = false;
                        graph.DrawDiagram();
                    }
                }
            }

            //Выризание части графика
            if (CutMode)
            {
                Graphics g = pictureBox1.CreateGraphics();
                int MouseX = e.X;
                //int MouseY = e.Y;
                if (numLines < 2)
                {
                    g.DrawLine(new Pen(Color.Black), MouseX, pictureBox1.Height, MouseX, 0);
                    numLines++;
                    if (numLines == 1) firstX = MouseX;
                    else secondX = MouseX;
                }
                if (numLines == 2)
                {
                    int x1, x2;
                    if (secondX > firstX)
                    {
                        x1 = firstX;
                        x2 = secondX;
                    }
                    else if (firstX > secondX)
                    {
                        x1 = secondX;
                        x2 = firstX;
                    }
                    else
                    {
                        MessageBox.Show("Недопустимый интервал!");
                        return;
                    }
                    g.FillRectangle(new SolidBrush(Color.FromArgb(100, 255, 0, 0)),
                        new RectangleF(x1, 0, Math.Abs(firstX - secondX), pictureBox1.Height));

                    double ValueX1 = Math.Round((x1 - graph.RealCenter.X) * graph.Config.PriceForPointOX / graph.Config.StepOX, 1);
                    double ValueX2 = Math.Round((x2 - graph.RealCenter.X) * graph.Config.PriceForPointOX / graph.Config.StepOX, 1);
                    DialogResult result =
                    MessageBox.Show("Вы действительно хотите удалить участок кривой от " + ValueX1.ToString() + " до " + ValueX2.ToString() + "?",
                        "Удаление промежутка кривой", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        for(int i = 0; i < graph.GraphCurves.Count; i++)
                        {
                            if (graph.GraphCurves[i].Legend == cmb_CutCurveLeg.Text)
                            {
                                //обнуление значений в массиве
                                int ZeroPT = 0;
                                for(int j = 0; j < graph.GraphCurves[i].PointsToDraw.Length; j++)
                                {
                                    if (graph.GraphCurves[i].PointsToDraw[j].X >= ValueX1 && graph.GraphCurves[i].PointsToDraw[j].X <= ValueX2)
                                    {
                                        graph.GraphCurves[i].PointsToDraw[j].X = 0;
                                        graph.GraphCurves[i].PointsToDraw[j].Y = 0;
                                        ZeroPT++;
                                    }
                                }
                                //заполнение нового массива
                                PointF[] temp = new PointF[graph.GraphCurves[i].PointsToDraw.Length - ZeroPT];
                                int CountNotZero = 0;
                                for(int j = 0; j < graph.GraphCurves[i].PointsToDraw.Length; j++)
                                {
                                    if (graph.GraphCurves[i].PointsToDraw[j].X == 0 &&
                                        graph.GraphCurves[i].PointsToDraw[j].Y == 0)
                                    {
                                        
                                    }
                                    else
                                    {
                                        temp[CountNotZero].X = graph.GraphCurves[i].PointsToDraw[j].X;
                                        temp[CountNotZero].Y = graph.GraphCurves[i].PointsToDraw[j].Y;
                                        CountNotZero++;
                                    }
                                }
                                graph.GraphCurves[i] = new Curves(temp, graph.GraphCurves[i].CurveColor,
                                    graph.GraphCurves[i].CurveThickness, graph.GraphCurves[i].Legend);
                                graph.DrawDiagram();
                                x1 = x2 = 0;
                                numLines = 0;
                                CutMode = false;
                                GC.Collect();
                                break;
                            }
                            
                        }
                        
                        
                    }
                    else
                    {
                        x1 = x2 = 0;
                        numLines = 0;
                        CutMode = false;
                        graph.DrawDiagram();
                    }
                }

            }


        }
        #endregion


        private void btn_AddNewGraph_Click(object sender, EventArgs e)
        {
            pnl_Windows.Controls.Clear();
            pnl_Windows.Controls.Add(addGraph);
            addGraph.Parent = pnl_Windows;
        }

        private void btn_MainSettings_Click(object sender, EventArgs e)
        {
            pnl_Windows.Controls.Clear();
            mainSettings = new MainSettings()
            {
                Location = new Point(0, 0),
                Dock = DockStyle.Right
            };
            pnl_Windows.Controls.Add(mainSettings);
            //hi
            mainSettings.Parent = pnl_Windows;
        }

        private void btn_BuildGraph_Click(object sender, EventArgs e)
        {
            
            graph.DrawDiagram();
        }

        private void btn_DeleteCurves_Click(object sender, EventArgs e)
        {
            graph.GraphCurves.Clear();
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(pictureBox1.BackColor);
            g.Dispose();
            g = null;

            addGraph?.ResetParams();
            graph.placeToDraw = pictureBox1;
            graph.SetPlaceToDrawSize(graph.placeToDraw.Width, graph.placeToDraw.Height);
            graph.Config.StepOX = 30;
            graph.Config.StepOY = 25;
            graph.Config.PriceForPointOX = graph.Config.PriceForPointOY = 1;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (graph != null)
            {

                graph.placeToDraw = pictureBox1;
                graph.SetPlaceToDrawSize(graph.placeToDraw.Width, graph.placeToDraw.Height);
                if (graph.GraphCurves.Count != 0)
                {
                    graph.DrawDiagram();
                }

            }
        }

        private void btn_BuildRTGraph_Click(object sender, EventArgs e)
        {
            RT_Graphic rT_Graphic = new RT_Graphic();
            rT_Graphic.Show();
        }

        
        private void btn_OpenRTGraph_Click(object sender, EventArgs e)
        {
            string filePath; DialogResult result;
            using (OpenFileDialog open = new OpenFileDialog())
            {
                result = open.ShowDialog();
                filePath = open.FileName;
            }

            if (result == DialogResult.OK && filePath != "")
            {
                string jsonData = File.ReadAllText(filePath);
                Dictionary<double, double> ptDic = JsonConvert.DeserializeObject<Dictionary<double, double>>(jsonData);

                PointF[] pt = new PointF[ptDic.Count];
                int i = 0;
                foreach(KeyValuePair<double, double> pair in ptDic)
                {
                    pt[i].X = (float)pair.Key;
                    pt[i].Y = (float)pair.Value;
                    i++;
                }
                
                Curves RTcurve = new Curves(pt, Color.Black, Legend: filePath);
                graph.AddCurve(RTcurve);
                
                addGraph.AddGraphToList(filePath, Color.Black);
                MessageBox.Show("Конвертация успешно завершена", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_HideSettings_Click(object sender, EventArgs e)
        {
            if (Hidden == false)
            {
                pnl_Windows.Width = 0;
                btn_HideSettings.Image = Properties.Resources.visible_25px;
                Hidden = true;
                if (graph != null)
                {
                    graph.placeToDraw = pictureBox1;
                    graph.SetPlaceToDrawSize(graph.placeToDraw.Width, graph.placeToDraw.Height);
                    graph.RealCenter = new Point(graph.RealCenter.X + ShiftOX, graph.RealCenter.Y + ShiftOY);
                    graph.DrawDiagram();
                }
            }
            else if (Hidden == true)
            {
                pnl_Windows.Width = this.Width / 3; // 449;
                btn_HideSettings.Image = Properties.Resources.unvisibie_25px;
                Hidden = false;
                if (graph != null)
                {
                    graph.placeToDraw = pictureBox1;
                    graph.SetPlaceToDrawSize(graph.placeToDraw.Width, graph.placeToDraw.Height);
                    graph.RealCenter = new Point(graph.RealCenter.X + ShiftOX, graph.RealCenter.Y + ShiftOY);
                    graph.DrawDiagram();
                }
            }
        }

        private void cmb_PriceOX_Leave(object sender, EventArgs e)
        {
            graph.Config.PriceForPointOX = double.Parse(cmb_PriceOX.Text);
            graph.DrawDiagram();
        }

        private void cmb_PriceOY_Leave(object sender, EventArgs e)
        {
            graph.Config.PriceForPointOY = double.Parse(cmb_PriceOY.Text);
            graph.DrawDiagram();
        }

        private void сохранитьPngкартинкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath; DialogResult result;
            using (SaveFileDialog save = new SaveFileDialog())
            {
                result = save.ShowDialog();
                filePath = save.FileName;
            }
            if (result == DialogResult.OK && filePath != null)
            {
                Thread.Sleep(1000);
                filePath += ".png";
                Bitmap image = DrawControlToBitMap(pictureBox1);
                image.Save(filePath);
                DialogResult res =
                MessageBox.Show("График успешно сохранён!\n" +
                    "Открыть файл?", "Операция заверщена", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (res == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(filePath);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cmb_CutCurveLeg.Items.Clear();
            foreach(Curves curve in graph.GraphCurves)
            {
                cmb_CutCurveLeg.Items.Add(curve.Legend);
            }
            
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void текстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextLabel lb = new TextLabel()
            {
                Location = new Point(0, 0),
                Text = "Новый текст",
                BackColor = System.Drawing.Color.Transparent,
                Cursor = Cursors.SizeAll,
                AutoSize = true,
                Font = new Font("Arial", 9),
                
            };
            lb.MouseClick += new System.Windows.Forms.MouseEventHandler(lbl_MouseClick);
            lb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(lbl_MouseDoubleClick);
            pictureBox1.Controls.Add(lb);
            ControlExtension.Draggable(lb, true);
            
        }

        private void lbl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            pictureBox1.Controls.Remove((Label)sender);
        }
        private void lbl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Label activeLabel = (Label)sender;
            //начальная инициализация параметров
            ChangeLBL.lbl_Text = activeLabel.Text;
            ChangeLBL.lbl_Font = activeLabel.Font;
            ChangeLBL.lbl_Color = activeLabel.ForeColor;    

            ChangeLBL changeLBL = new ChangeLBL();
            changeLBL.textBox1.Text = activeLabel.Text;
            changeLBL.ShowDialog();

            activeLabel.Text = ChangeLBL.lbl_Text;
            activeLabel.Font = ChangeLBL.lbl_Font;
            activeLabel.ForeColor = ChangeLBL.lbl_Color;
        }

        

        private static Bitmap DrawControlToBitMap(Control control)
        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            Graphics g = Graphics.FromImage(bitmap);
            Rectangle rect = control.RectangleToScreen(control.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, control.Size);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            return bitmap;
        }

        
    }
}
