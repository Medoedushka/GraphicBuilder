using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDrawing;
using System.IO;


namespace GraphicBuilder
{
    public partial class RT_Graphic : Form
    {
        PointsGraphic RTgraph;
        public List<double> YValues = new List<double>();

        int Time { get; set; }
        public string PathTxt { get; set; }
        bool ActiveConnection { get; set; }

        public RT_Graphic()
        {
            InitializeComponent();
            
        }

        private void RT_Graphic_Load(object sender, EventArgs e)
        {
            RTgraph = new PointsGraphic(pictureBox1, AxesMode.Dynamic, AxesPosition.AllQuarters);
            RTgraph.Config.Grid = true;
            RTgraph.Config.SmoothAngles = true;
            RTgraph.Config.PriceForPointOX = 1;
            RTgraph.Config.PriceForPointOY = 1;
            
            lbl_Status.Visible = true;
            ActiveConnection = false;
            
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            string pathFile; DialogResult result;

            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                result = openFile.ShowDialog();
                pathFile = openFile.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(pathFile) == ".txt")
                {
                    lbl_Status.ForeColor = Color.Green;
                    lbl_Status.Text = "P";
                    txb_FilePath.Text = pathFile;
                    PathTxt = pathFile;
                }
                else
                {
                    lbl_Status.ForeColor = Color.Red;
                    lbl_Status.Text = "O";
                }
            }
        }

        private void DrawRTGraph()
        {
            Time = 0;
            while (ActiveConnection)
            {
                FileStream input = new FileStream(PathTxt, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
                using (StreamReader reader = new StreamReader(input))
                {
                    string[] el = reader.ReadToEnd().Split(' ');
                    double value = double.Parse(el[el.Length - 1]);
                    YValues.Add(value);
                    double x = RTgraph.ImiganaryCenter.X - 1 * RTgraph.Config.StepOX / RTgraph.Config.PriceForPointOX;
                    
                    RTgraph.ImiganaryCenter = new Point((int)x, RTgraph.ImiganaryCenter.Y);
                    
                    RTgraph.DrawRTGraph(YValues);
                    Time++;
                    Thread.Sleep(50);
                }
            }
        }

        private async Task DrawRTGraphAsync()
        {
            await Task.Run(() => DrawRTGraph());
            MessageBox.Show("Done!");
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            ActiveConnection = true;
            RTgraph.DrawAxes();
            Thread.Sleep(1000);
            DrawRTGraphAsync();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveConnection = false;
            GC.Collect(2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
