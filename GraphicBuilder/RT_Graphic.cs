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
using System.IO.Ports;


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
            PathTxt = null;
            RTgraph.Config.PriceForPointOX = 1;
            RTgraph.Config.PriceForPointOY = 100;
            RTgraph.Config.StepOX = 25;
            RTgraph.Config.StepOY = 100;
            RTgraph.Config.Grid = true;
            RTgraph.Config.SmoothAngles = true;
            RTgraph.Config.DrawPoints = true;
            ActiveConnection = false;
            cmb_BaundRate.Text = cmb_BaundRate.Items[4].ToString();
            cmb_PortName.Text = cmb_PortName.Items[2].ToString();
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
            Time = 0; //время работы цикла
            string[] el = null; //массив элементов значений
            double value; //последнее значение в массиве
            while (ActiveConnection)
            {
                if (PathTxt != null)
                {
                    FileStream input = new FileStream(PathTxt, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
                    using (StreamReader reader = new StreamReader(input))
                    {
                        el = reader.ReadToEnd().Split(' ');
                        if (el[el.Length - 1] == " " || el[el.Length - 1] == string.Empty)
                        {
                            MessageBox.Show("Ошибка формата передачи данных: \" \"num", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else if (PathTxt == null)
                {
                    try
                    {
                        el = serialPort1.ReadLine().Split(' ');
                    }
                    catch(IOException) { return; }
                        if (el[el.Length - 1] == " " || el[el.Length - 1] == string.Empty)
                    {
                        MessageBox.Show("Ошибка формата передачи данных: \" \"num", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                value = double.Parse(el[el.Length - 1]);
                double k = Math.Round(RTgraph.Config.StepOX / 2400.0, 4);
                double x = RTgraph.ImiganaryCenter.X -  0.0004* RTgraph.Config.StepOX / RTgraph.Config.PriceForPointOX;
                RTgraph.ImiganaryCenter = new Point((int)x, RTgraph.ImiganaryCenter.Y);
                RTgraph.ValuePairs.Add(Time, value);
                RTgraph.DrawRTGraph();

                Time += 0.1 / 60.0;
                Thread.Sleep(25);
            }
        }

        private async Task DrawRTGraphAsync()
        {
            await Task.Run(() => DrawRTGraph());
            
            MessageBox.Show("Done!");
        }

        private void btn_Connection_Click(object sender, EventArgs e)
        {
            l1:
          if (!ActiveConnection)
            {
                if (PathTxt == null)
                {
                    try
                    {
                        serialPort1.BaudRate = int.Parse(cmb_BaundRate.Text);
                        serialPort1.PortName = cmb_PortName.Text;
                        serialPort1.Open();
                    }
                    catch (IOException ex)
                    {
                        DialogResult res = 
                        MessageBox.Show(ex.Message, "Ошибка подключения к порту", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                        if (res == DialogResult.Retry) goto l1;
                        else return;

                    }
                }
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
                pc.Image = null;
                PathTxt = null;
                txb_FilePath.Text = "";
                ActiveConnection = false;
                serialPort1.Close();
                RTgraph.ValuePairs.Clear();
                btn_Connection.ForeColor = Color.FromArgb(0, 217, 0);
                btn_Connection.Text = "Подключиться";
                pc.BackColor = Color.FromArgb(135, 206, 250);
                GC.Collect(2);
            }
              
        }

        private void RT_Graphic_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ActiveConnection == true)
            {
                ActiveConnection = false;
                GC.Collect(2);
            }
            if (serialPort1.IsOpen) serialPort1.Close();
        }
        
        private void tls_MoveLeft_Click(object sender, EventArgs e)
        {
            RTgraph.ImiganaryCenter = new Point(RTgraph.ImiganaryCenter.X - 25, RTgraph.ImiganaryCenter.Y);
        }

        private void tls_MoveRight_Click(object sender, EventArgs e)
        {
            RTgraph.ImiganaryCenter = new Point(RTgraph.ImiganaryCenter.X + 25, RTgraph.ImiganaryCenter.Y);
        }

        private void tls_IncreaseOX_Click(object sender, EventArgs e)
        {
            RTgraph.Config.StepOX += 2;
        }

        private void tls_DecreaseOX_Click(object sender, EventArgs e)
        {
            RTgraph.Config.StepOX -= 2;
        }

        private void RT_Graphic_StyleChanged(object sender, EventArgs e)
        {
            if (RTgraph != null)
            RTgraph.placeToDraw = pc;
        }
    }
}
