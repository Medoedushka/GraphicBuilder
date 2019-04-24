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
        

        double Time { get; set; } //время, кажется бесполезный..добавить словарь для хранения значений
        public string PathTxt { get; set; } //путь к тхт-файлу
        bool ActiveConnection { get; set; } //является ли второй поток активным
         
        public RT_Graphic()
        {
            InitializeComponent();
            
        }

        private void RT_Graphic_Load(object sender, EventArgs e)
        {
            RTgraph = new PointsGraphic(pc, AxesMode.Dynamic, AxesPosition.AllQuarters);
            //начальный настройки
            //RTgraph.Config.Grid = true;
            //RTgraph.Config.SmoothAngles = true;
            RTgraph.Config.PriceForPointOX = 0.5;
            RTgraph.Config.PriceForPointOY = 1;
            RTgraph.Config.DrawPoints = true;
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
                    lbl_Status.ForeColor = Color.FromArgb(0, 217, 0);
                    lbl_Status.Text = "P";
                    txb_FilePath.Text = pathFile;
                    PathTxt = pathFile;
                }
                else
                {
                    txb_FilePath.Text = pathFile;
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
                    if (el[el.Length - 1] == " " || el[el.Length - 1] == string.Empty) 
                    {
                        MessageBox.Show("Ошибка формата передачи данных: \" \"num", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    double value = double.Parse(el[el.Length - 1]);
                    double x = RTgraph.ImiganaryCenter.X -  0.1 * RTgraph.Config.StepOX / RTgraph.Config.PriceForPointOX;
                    RTgraph.ImiganaryCenter = new Point((int)x, RTgraph.ImiganaryCenter.Y);
                    RTgraph.ValuePairs.Add(Time, value);
                    RTgraph.DrawRTGraph();
                    
                    Time += 0.1;
                    Thread.Sleep(100);
                }
            }
        }

        private async Task DrawRTGraphAsync()
        {
            await Task.Run(() => DrawRTGraph());
            
            MessageBox.Show("Done!");
        }

        private void btn_Connection_Click(object sender, EventArgs e)
        {
            if (!ActiveConnection)
            {
                ActiveConnection = true;
                RTgraph.placeToDraw = pc;
                RTgraph.SetPlaceToDrawSize(pc.Width, pc.Height);
                btn_Connection.ForeColor = Color.FromArgb(235, 35, 50);
                btn_Connection.Text = "Отключиться";
                Thread.Sleep(1000);
                DrawRTGraphAsync();
            }
            else
            {
                ActiveConnection = false;
                RTgraph.ValuePairs.Clear();
                btn_Connection.ForeColor = Color.FromArgb(0, 217, 0);
                btn_Connection.Text = "Подключиться";
                pc.Image = null;
                pc.BackColor = Color.FromArgb(135, 206, 250);
                GC.Collect(2);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            ActiveConnection = true;
            Thread.Sleep(1000);
            DrawRTGraphAsync();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ActiveConnection = false;
            GC.Collect(2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RT_Graphic_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ActiveConnection == true)
            {
                ActiveConnection = false;
                GC.Collect(2);
            }
        }

        private void RT_Graphic_Resize(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RTgraph.ImiganaryCenter = new Point(RTgraph.ImiganaryCenter.X - 25, RTgraph.ImiganaryCenter.Y);
        }

        private void tls_MoveLeft_Click(object sender, EventArgs e)
        {
            RTgraph.ImiganaryCenter = new Point(RTgraph.ImiganaryCenter.X - 25, RTgraph.ImiganaryCenter.Y);
        }

        private void tls_MoveRight_Click(object sender, EventArgs e)
        {
            RTgraph.ImiganaryCenter = new Point(RTgraph.ImiganaryCenter.X + 25, RTgraph.ImiganaryCenter.Y);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RTgraph.Config.PriceForPointOY += 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RTgraph.Config.StepOY = 25;
        }
    }
}
