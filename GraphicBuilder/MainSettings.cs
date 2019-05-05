using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicBuilder
{
    public partial class MainSettings : UserControl
    {
        public MainSettings()
        {
            InitializeComponent();
        }

        private void InitBaseConf()
        {
            //установление начальных значений чекбоксов
            if (MainForm.graph.Config.Grid == true)
                chb_Grid.Checked = true;
            if (MainForm.graph.Config.DrawPoints == true)
                chb_ShowPoints.Checked = true;
            if (MainForm.graph.Config.SmoothAngles == true)
                chb_SmoothAngles.Checked = true;
            //установление начального значения цвета области построения
            pcb_PlotColor.BackColor = MainForm.graph.placeToDraw.BackColor;
            txb_CurrentFont.Text = MainForm.graph.Config.DrawFont.Name + "; " +
                MainForm.graph.Config.DrawFont.Size + "pt";
            
        }

        private void chb_Grid_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Grid.Checked)
                MainForm.graph.Config.Grid = true;
            else MainForm.graph.Config.Grid = false;
            MainForm.graph.DrawDiagram();
        }

        private void chb_ShowPoints_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_ShowPoints.Checked)
                MainForm.graph.Config.DrawPoints = true;
            else MainForm.graph.Config.DrawPoints = false;
            MainForm.graph.DrawDiagram();
        }

        private void chb_SmoothAngles_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_SmoothAngles.Checked)
                MainForm.graph.Config.SmoothAngles = true;
            else MainForm.graph.Config.SmoothAngles = false;
            MainForm.graph.DrawDiagram();
        }

        private void MainSettings_Load(object sender, EventArgs e)
        {
            //hello, honey budger
            this.Width = this.Parent.Width;
            InitBaseConf();
        }

        private void btn_ChangePlotColor_Click(object sender, EventArgs e)
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
                MainForm.graph.placeToDraw.BackColor = colorDialog.Color;
                pcb_PlotColor.BackColor = colorDialog.Color;
                MainForm.graph.DrawDiagram();
            }
        }

        private void btn_ChangeTextFont_Click(object sender, EventArgs e)
        {
            DialogResult result; FontDialog fontDialog;
            using (fontDialog = new FontDialog())
            {
                fontDialog.Font = MainForm.graph.Config.DrawFont;
                result = fontDialog.ShowDialog();
            }

            if (result == DialogResult.OK)
            {
                MainForm.graph.Config.DrawFont = fontDialog.Font;
                txb_CurrentFont.Text = fontDialog.Font.Name + "; " + fontDialog.Font.Size + "pt";
                MainForm.graph.DrawDiagram();
            }
        }
    }
}
