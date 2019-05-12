using System;
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

        bool CutMode { get; set; } = true;
        byte numLines = 0;
        int firstX, secondX;

        private void вырезатьОбластьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CutMode = !CutMode;
            if (!CutMode)// && cmb_CutCurveLeg.Text != "")
            {
                вырезатьОбластьToolStripMenuItem.Checked = true;
                Graphics g = pictureBox1.CreateGraphics();
                g.FillRectangle(new SolidBrush(Color.FromArgb(100, 120, 120, 120)), new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                g.Dispose();
            }
            else
            {
                вырезатьОбластьToolStripMenuItem.Checked = false;
                //CutMode = false;
                graph.DrawDiagram();
            }

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //Выризание части графика
            if (!CutMode)
            {
                
                Graphics g = pictureBox1.CreateGraphics();
                int MouseX = e.X;
                //int MouseY = e.Y;
                if (numLines % 2 == 0)
                {
                    g.DrawLine(new Pen(Color.Black), MouseX, pictureBox1.Height, MouseX, 0);

                    firstX = MouseX;
                }
                if (numLines % 2 != 0 && numLines != 0)
                {
                    secondX = MouseX;
                    //CutMode = !CutMode;
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
                        // строка названий кривых для формы
                        string[] a = new string[graph.GraphCurves.Count];
                        for (int k = 0; k < graph.GraphCurves.Count; k++) a[k] = graph.GraphCurves[k].Legend;
                        AskingForm af = new AskingForm(a);
                        af.ShowDialog();

                        // маска на факт обрезания кривой
                        bool[] Answ = new bool[0];
                        if (af.DialogResult == DialogResult.OK) Answ = AskingForm.Answer;

                        //  количество кривых, получившихся в результате раздвоение
                        int numA = 0;
                        for (int i = 0; i < Answ.Length; i++)
                        {
                            for (int j = 0; j < graph.GraphCurves.Count; j++)
                                if (Answ[i] && graph.GraphCurves[i].Legend == graph.GraphCurves[j].Legend) numA++;
                        }

                        bool[] Pre_RealAnswer = new bool[graph.GraphCurves.Count];
                        for (int i = 0; i < AskingForm.Number; i++)
                        {
                            for (int j = i; j < graph.GraphCurves.Count; j++) if (graph.GraphCurves[j].Legend == graph.GraphCurves[i].Legend) Pre_RealAnswer[j] = Answ[i];
                        }
                        // новая маска на основании количества итоговых кривых
                        bool[] RealAnsw = new bool[graph.GraphCurves.Count + numA];
                        for (int i = 0; i < RealAnsw.Length; i++)
                        {
                            if (i < Pre_RealAnswer.Length) RealAnsw[i] = Pre_RealAnswer[i];
                            else RealAnsw[i] = false;
                        }

                        for (int i = 0; i < graph.GraphCurves.Count; i++)
                        {
                            // если маска пустая - ничего не делаем, а если не пустая - проверяем на факт обрезания итую курву
                            if (RealAnsw.Length != 0) if (!RealAnsw[i]) continue;

                            int ZeroPT = 0;
                            int CountNotZero = 0;
                            if (ValueX1 <= graph.GraphCurves[i].PointsToDraw[0].X && ValueX2 >= graph.GraphCurves[i].PointsToDraw[graph.GraphCurves[i].PointsToDraw.Length - 1].X)
                            {
                                //обнуляет полностью вырезанную кривую, все равно потом удалится из-за обнуления
                                graph.GraphCurves[i] = new Curves(new PointF[0], graph.GraphCurves[i].CurveColor,
                                        graph.GraphCurves[i].CurveThickness, graph.GraphCurves[i].Legend);
                                //graph.DrawDiagram();
                                continue;
                            }
                            if (ValueX1 > graph.GraphCurves[i].PointsToDraw[0].X 
                                == ValueX2 > graph.GraphCurves[i].PointsToDraw[graph.GraphCurves[i].PointsToDraw.Length - 1].X)
                                         continue;
                            
                            //hi there, honey budger. I hope, you'll like this algorythm
                            int FirstZeroPosition = 0, LastZeroPosition = 0;
                            //
                            for (int j = 0; j < graph.GraphCurves[i].PointsToDraw.Length; j++)
                            {
                                if (graph.GraphCurves[i].PointsToDraw[j].X >= ValueX1 && graph.GraphCurves[i].PointsToDraw[j].X <= ValueX2)
                                {
                                    if (FirstZeroPosition == 0) FirstZeroPosition = j;
                                    LastZeroPosition = j;
                                    ZeroPT++;
                                }
                            }
                            if (ValueX1 <= graph.GraphCurves[i].PointsToDraw[0].X)
                                FirstZeroPosition = 0;
                            if (ValueX2 >= graph.GraphCurves[i].PointsToDraw[graph.GraphCurves[i].PointsToDraw.Length - 1].X)
                                LastZeroPosition = graph.GraphCurves[i].PointsToDraw.Length - 1;
                            PointF[] temp2 = new PointF[graph.GraphCurves[i].PointsToDraw.Length - LastZeroPosition - 1];
                            PointF[] temp1 = new PointF[FirstZeroPosition];

                            for (int j = 0; j < graph.GraphCurves[i].PointsToDraw.Length; j++)
                            {
                                if (j < FirstZeroPosition)
                                {
                                    temp1[CountNotZero].X = graph.GraphCurves[i].PointsToDraw[j].X;
                                    temp1[CountNotZero].Y = graph.GraphCurves[i].PointsToDraw[j].Y;

                                    CountNotZero++;
                                }
                                else if (j > LastZeroPosition)
                                {
                                    temp2[CountNotZero].X = graph.GraphCurves[i].PointsToDraw[j].X;
                                    temp2[CountNotZero].Y = graph.GraphCurves[i].PointsToDraw[j].Y;

                                    CountNotZero++;
                                }
                                else CountNotZero = 0;
                            }

                            // изменяет текущую кривую (левая часть) и добавляет новую (правая часть)
                            graph.GraphCurves[i] = new Curves(temp1, graph.GraphCurves[i].CurveColor,
                                graph.GraphCurves[i].CurveThickness, graph.GraphCurves[i].Legend);
                            graph.GraphCurves.Add(new Curves(temp2, graph.GraphCurves[i].CurveColor,
                                graph.GraphCurves[i].CurveThickness, graph.GraphCurves[i].Legend));

                        }

                        // удаляет кривые с нулевым количеством точек
                        for (int i = 0; i < graph.GraphCurves.Count; i++)
                        {
                            if (graph.GraphCurves[i].PointsToDraw.Length == 0) { graph.GraphCurves.RemoveAt(i); i--; }
                        }

                        graph.DrawDiagram();
                        CutMode = false;
                        GC.Collect();
                    }
                    else
                    {

                        CutMode = false;
                        graph.DrawDiagram();
                    }
                }

                numLines++;
                Graphics gi = pictureBox1.CreateGraphics();
                gi.FillRectangle(new SolidBrush(Color.FromArgb(100, 120, 120, 120)), new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                // gi.Dispose();
            }

        }


        // I bet you'll never seen it, don't you?)   
        public class AskingForm : System.Windows.Forms.Form
        {
            private const int WM_NCHITTEST = 0x84;
            private const int HT_CLIENT = 0x1;
            private const int HT_CAPTION = 0x2;
            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);
                if (m.Msg == WM_NCHITTEST) m.Result = (IntPtr)(HT_CAPTION);
            }

            private static string[] Curves = { };
            public static int Number = 0; 
            private List<string> Curve2 = new List<string>();
            private Button OK = new Button();
            private Button Cancel = new Button();
            private Label lblCount = new Label();
            public static bool[] Answer = new bool[Curves.Length];
            public AskingForm(string[] a)
            {
                Curves = a;
                InitializeComponent();
            }
            private void Ask_Load(object sender, EventArgs e)
            {
                int i = 0;
                CheckBox ch;

                Answer = new bool[Curves.Length];
                foreach (string str in Curves)
                {
                    if (!Curve2.Contains(str))
                    {
                        Curve2.Add(str);
                        ch = new CheckBox(); ch.Text = str;
                        ch.Name = "ch" + i;
                        ch.Parent = this; ch.Location = new Point(2, i * 20 + 15);
                        ch.TabIndex = i;
                        ch.Visible = true; ch.Checked = false;
                        this.Controls.Add(ch);
                        i++;
                    }

                }

            }

            private void OK_Click(object sender, EventArgs e)
            {
                for (int i = 0; i < Curves.Length; i++)
                {
                    if (i < Curve2.Count)
                        if ((this.Controls["ch" + i] as CheckBox).Checked == true) Answer[i] = true;
                        else { if (Curve2.Contains(Curves[i])) Answer[i] = Answer[Curve2.IndexOf(Curves[i])]; }
                    else Answer[i] = false;
                }
                Number = Curve2.Count;
                this.DialogResult = DialogResult.OK;
            }

            private void Cancel_Click(object sender, EventArgs e)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            private void InitializeComponent()
            {

                this.label1 = new System.Windows.Forms.Label();

                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Font = new System.Drawing.Font("Arial", 10F);
                this.label1.Location = new System.Drawing.Point(0, 0);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(183, 16);
                this.label1.TabIndex = 5;
                this.label1.Text = "Выберите кривые для вырезания";
                //
                //button OK
                //
                this.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                this.OK.Location = new System.Drawing.Point(0, Curves.Length * 20 + 10);
                this.OK.Name = "OK";
                this.OK.Size = new System.Drawing.Size(50, 20);
                this.OK.TabIndex = 2;
                this.OK.Text = "OK";
                this.OK.UseVisualStyleBackColor = true;
                this.OK.Click += new System.EventHandler(this.OK_Click);
                this.OK.Visible = true;
                OK.TabIndex = Curves.Length;
                //
                //cancel 
                //
                this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Cancel.Location = new System.Drawing.Point(5 + OK.Width, Curves.Length * 20 + 10);
                this.Cancel.Name = "Cancel";
                this.Cancel.Size = new System.Drawing.Size(75, 20);
                this.Cancel.TabIndex = 3;
                this.Cancel.Text = "Отмена";
                this.Cancel.UseVisualStyleBackColor = true;
                this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
                this.Cancel.Visible = true;
                this.Cancel.TabIndex = OK.TabIndex + 1;
                // 
                // MainSettings
                // 
                this.StartPosition = FormStartPosition.CenterScreen;
                this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
                this.BackColor = System.Drawing.SystemColors.Control;
                this.Controls.Add(this.label1);
                this.Controls.Add(this.OK);
                this.Controls.Add(this.Cancel);
                this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
                this.Name = "";
                this.Size = new System.Drawing.Size(label1.Width, Curves.Length * 40 + OK.Height + Cancel.Height - 25);
                this.Load += new System.EventHandler(this.Ask_Load);
                this.ResumeLayout(false);
                this.PerformLayout();
                this.FormBorderStyle = FormBorderStyle.None;
            }


            private System.Windows.Forms.Label label1;
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
                  //  graph.DrawDiagram();
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
            Label lb = new Label()
            {
                Location = new Point(0, 0),
                Text = "Meow",
                BackColor = System.Drawing.Color.Transparent,
                Cursor = Cursors.SizeAll,
                AutoSize = true
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
            ChangeLBL changeLBL = new ChangeLBL();
            changeLBL.ShowDialog();
            activeLabel.Text = TextValue;
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

