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
        bool Hidden { get; set; }
       

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            graph = new PointsGraphic(pictureBox1, AxesMode.Static, AxesPosition.AllQuarters);
            Hidden = false;
            cmb_PriceOX.Text = graph.Config.PriceForPointOX.ToString();
            cmb_PriceOY.Text = graph.Config.PriceForPointOY.ToString();
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
                graph.RealCenter = new Point(graph.RealCenter.X + value, graph.RealCenter.Y);

            if (param == Param.RCenterPosY)
                graph.RealCenter = new Point(graph.RealCenter.X, graph.RealCenter.Y + value);
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
        #endregion


        private void btn_AddNewGraph_Click(object sender, EventArgs e)
        {
            pnl_Windows.Controls.Clear();
            addGraph = new AddGraph()
            {
                Location = new Point(0,0),
                Dock = DockStyle.Right
            };
            pnl_Windows.Controls.Add(addGraph);
            
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
        }

        private void btn_BuildGraph_Click(object sender, EventArgs e)
        {
            graph.Config.Grid = true;
            graph.Config.SmoothAngles = true;

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
                Curves RTcurve = new Curves(pt, Color.Red);
                graph.AddCurve(RTcurve);
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
                    graph.DrawDiagram();
                }
            }
            else if (Hidden == true)
            {
                pnl_Windows.Width = 449;
                btn_HideSettings.Image = Properties.Resources.unvisibie_25px;
                Hidden = false;
                if (graph != null)
                {
                    graph.placeToDraw = pictureBox1;
                    graph.SetPlaceToDrawSize(graph.placeToDraw.Width, graph.placeToDraw.Height);
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

        private static Bitmap DrawControlToBitMap(Control control)
        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            Graphics g = Graphics.FromImage(bitmap);
            Rectangle rect = control.RectangleToScreen(control.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, control.Size);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            return bitmap;
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
