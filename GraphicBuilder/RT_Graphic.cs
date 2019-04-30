﻿using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDrawing;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

namespace GraphicBuilder
{
    public partial class RT_Graphic : Form
    {
        PointsGraphic RTgraph;
        PictureBox LastPlot;

        double Time { get; set; } //время, кажется бесполезный..добавить словарь для хранения значений
        int WaitTime { get; set; } //время задержки между получением нового значения
        int Hours { get; set; } //кол-во часов работы приложения
        int Minutes { get; set; } //кол-во минут работы приложения
        int Seconds { get; set; } // кол-во секунд работы приложения
        public string PathTxt { get; set; } //путь к тхт-файлу
        bool ActiveConnection { get; set; } //является ли второй поток активным
         
        public RT_Graphic()
        {
            InitializeComponent();
            
        }


        #region DynamicCameraMoving
        enum Param
        {
            StepOX,
            StepOY,
            IMCenterPos
        }

        Param crrParam; //текущий изменяемый параметр
        int value; //величина, на которую происзодит изменение

        private void ChangeParams(Param param, int value)
        {
            if (param == Param.StepOX) RTgraph.Config.StepOX += value;

            if (param == Param.StepOY) RTgraph.Config.StepOY += value;

            if (param == Param.IMCenterPos)
                RTgraph.ImiganaryCenter = new Point(RTgraph.ImiganaryCenter.X + value, RTgraph.ImiganaryCenter.Y);
        }

        private void tmr_MOVE_Tick(object sender, EventArgs e)
        {
            ChangeParams(crrParam, value);
        }
        //перемещение камеры влево
        private void tls_MoveLeft_MouseDown(object sender, MouseEventArgs e)
        {
            crrParam = Param.IMCenterPos; value = 25;
            tmr_MOVE.Start();
        }
        private void tls_MoveLeft_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_MOVE.Stop();
        }
        //перемещение камеры вправо
        private void tls_MoveRight_MouseDown(object sender, MouseEventArgs e)
        {
            crrParam = Param.IMCenterPos; value = -25;
            tmr_MOVE.Start();
        }
        private void tls_MoveRight_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_MOVE.Stop();
        }
        //увеличение шага между делениями оси абсцисс
        private void tls_IncreaseOX_MouseDown(object sender, MouseEventArgs e)
        {
            crrParam = Param.StepOX; value = 2;
            tmr_MOVE.Start();
        }
        private void tls_IncreaseOX_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_MOVE.Stop();
        }
        //уменьшение шага между делениями оси абсцисс
        private void tls_DecreaseOX_MouseDown(object sender, MouseEventArgs e)
        {
            crrParam = Param.StepOX; value = -2;
            tmr_MOVE.Start();
        }
        private void tls_DecreaseOX_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_MOVE.Stop();
        }
        //увеличение шага между делениями оси ординат
        private void tls_IncreaseOY_MouseDown(object sender, MouseEventArgs e)
        {
            crrParam = Param.StepOY; value = 2;
            tmr_MOVE.Start();
        }
        private void tls_IncreaseOY_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_MOVE.Stop();
        }
        //уменьшение шага между делениями оси ордиант
        private void tls_DecreaseOY_MouseDown(object sender, MouseEventArgs e)
        {
            crrParam = Param.StepOY; value = -2;
            tmr_MOVE.Start();
        }
        private void tls_DecreaseOY_MouseUp(object sender, MouseEventArgs e)
        {
            tmr_MOVE.Stop();
        }
        //Изменение цены деления осей
        private void tls_PriceOX_Leave(object sender, EventArgs e)
        {
            RTgraph.Config.PriceForPointOX = double.Parse(tls_PriceOX.Text);
        }
        private void tls_PriceOY_Leave(object sender, EventArgs e)
        {
            RTgraph.Config.PriceForPointOY = double.Parse(tls_PriceOY.Text);
        }
        #endregion


        private void RT_Graphic_Load(object sender, EventArgs e)
        {
            RTgraph = new PointsGraphic(pc, AxesMode.Dynamic, AxesPosition.AllQuarters);
            //настройки по умолчанию
            PathTxt = null;
            WaitTime = 25;
            RTgraph.Config.PriceForPointOX = 1;
            RTgraph.Config.PriceForPointOY = 1;
            RTgraph.Config.StepOX = 25;
            RTgraph.Config.StepOY = 25;
            RTgraph.Config.Grid = true;
            RTgraph.Config.SmoothAngles = true;
            RTgraph.Config.DrawPoints = true;
            ActiveConnection = false;
            cmb_BaundRate.Text = cmb_BaundRate.Items[4].ToString(); //9600
            cmb_PortName.Text = cmb_PortName.Items[2].ToString(); //COM3
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
            Stopwatch watch = new Stopwatch();
            watch.Start();
            
            Time = 0; //время работы цикла
            string[] el = null; //массив элементов значений
            double value = 0; //последнее значение в массиве
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
                        value = double.Parse(el[el.Length - 1]);
                    }
                }
                else if (PathTxt == null)
                {
                    try
                    {
                        
                        string param = serialPort1.ReadLine().Replace('.', ',');
                        value = double.Parse(param);
                    }
                    catch(IOException) { return; }
                    
                }
                
                double k = Math.Round(RTgraph.Config.StepOX / 40.0, 4);
                double x = RTgraph.ImiganaryCenter.X -  0.1* RTgraph.Config.StepOX / RTgraph.Config.PriceForPointOX;
                RTgraph.ImiganaryCenter = new Point((int)x, RTgraph.ImiganaryCenter.Y);
                RTgraph.ValuePairs.Add(Time, value);
                RTgraph.DrawDiagram();

                Time = watch.Elapsed.TotalMilliseconds / 1000;
                Thread.Sleep(WaitTime);
            }
            watch.Stop();
        }

        private async Task DrawRTGraphAsync()
        {
            await Task.Run(() => DrawRTGraph());
            DialogResult res = 
            MessageBox.Show("Построение завершено!\n" +
                "Желаете сохранить полученные данные?", "Завершение построения", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                string filePath; DialogResult result;
                using (SaveFileDialog save = new SaveFileDialog())
                {
                    result = save.ShowDialog();
                    filePath = save.FileName;
                    filePath += ".json";
                }
                if (File.Exists(filePath))
                    MessageBox.Show("Файл с таким именем уже существует!", "Сохранение данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    using (var newFile = File.Create(filePath)) { }
                    string jsonData = JsonConvert.SerializeObject(RTgraph.ValuePairs, Formatting.Indented);
                    File.WriteAllText(filePath, jsonData);
                    MessageBox.Show("Данные успешно сохранены!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            RTgraph.ValuePairs.Clear();
            lbl_Seconds.Text = lbl_Minutes.Text = lbl_Hours.Text = "00";
            Seconds = Minutes = Hours = 0;
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
                        try
                        {
                            serialPort1.Open();
                        }
                        catch(UnauthorizedAccessException ex)
                        {
                            DialogResult res = 
                            MessageBox.Show(ex.Message, "Ошибка подключения", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            if (res == DialogResult.Retry) goto l1;
                        }
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
                LastPlot = pc;
                RTgraph.SetPlaceToDrawSize(pc.Width, pc.Height);
                btn_Connection.ForeColor = Color.FromArgb(235, 35, 50);
                btn_Connection.Text = "Отключиться";
                Thread.Sleep(1000);
                tmr_WorkingTime.Start();
                DrawRTGraphAsync();
            }
            else
            {
                tmr_WorkingTime.Stop();
                pc.Image = null;
                PathTxt = null;
                txb_FilePath.Text = "";
                ActiveConnection = false;
                serialPort1.Close();
                
                btn_Connection.ForeColor = Color.FromArgb(0, 140, 0);
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
        
        private void btn_ApplyConf_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_WaitTime.Text != "") WaitTime = int.Parse(txb_WaitTime.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcb_FileInfo_MouseHover(object sender, EventArgs e)
        {
            string str = "Читаемый файл должен быть формата .txt.\n" +
                "Данные в файле должны быть записаны в следующем формате: ' 'num";
            ToolTip tt = new ToolTip();
            tt.SetToolTip(pcb_FileInfo, str);
        }

        private void chb_AutoMax_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_AutoMax.Checked) RTgraph.Config.RT_AutoMax = true;
            else RTgraph.Config.RT_AutoMax = false;
        }

        private void tmr_WorkingTime_Tick(object sender, EventArgs e)
        {
            if (lbl_Seconds.Text != "59") lbl_Seconds.Text = string.Format("{0:D2}", ++Seconds);
            else if (lbl_Seconds.Text == "59")
            {
                lbl_Minutes.Text = string.Format("{0:D2}", ++Minutes);
                lbl_Seconds.Text = "00";
                Seconds = 0;
            }
            else if (lbl_Seconds.Text == "59" && lbl_Minutes.Text == "59")
            {
                lbl_Hours.Text = string.Format("{0:D2}", ++Hours);
                lbl_Seconds.Text = "00";
                Seconds = 0;
                lbl_Minutes.Text = "00";
                Minutes = 0;
            }
        }

    }
}
