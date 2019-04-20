using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyDrawing;
using Mathos;

namespace GraphicBuilder
{
    public partial class MainForm : Form
    {
        public static PointsGraphic graph;
        AddGraph addGraph;

        public MainForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            graph = new PointsGraphic(pictureBox1, AxesMode.Static, AxesPosition.AllQuarters);
        }

        private void btn_AddNewGraph_Click(object sender, EventArgs e)
        {
            pnl_Windows.Controls.Clear();
            addGraph = new AddGraph()
            {
                Location = new Point(0,0),
                BackColor = Color.White,
                Dock = DockStyle.Right
        };
            pnl_Windows.Controls.Add(addGraph);
            
        }

        private void btn_BuildGraph_Click(object sender, EventArgs e)
        {
            graph.Config.Grid = true;
            graph.Config.SmoothAngles = true;

            lbl_StepOX.Visible = lbl_StepOY.Visible = true;
            lbl_StepOX.Text = graph.Config.StepOX.ToString();
            lbl_StepOY.Text = graph.Config.StepOY.ToString();
           

            graph.DrawDiagram();
        }

        private void btn_DeleteCurves_Click(object sender, EventArgs e)
        {
            graph.GraphCurves.Clear();
            graph.g?.Clear(pictureBox1.BackColor);
            addGraph.ResetParams();
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
    }
}
