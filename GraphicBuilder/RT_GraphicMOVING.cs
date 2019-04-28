using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDrawing;
using System.IO;

namespace GraphicBuilder
{
    partial class RT_Graphic
    {
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
    }
}
