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
    public struct Line
    {
        int Width;
        PointF Begin, End;
        Color LineColor;
        bool IsArrow;
        PictureBox LinePictureBox;

        public Line(PointF begin, PointF end, Color lineColor, bool arrow, int width = 1)
        {
            Begin = begin;
            End = end;
            LineColor = lineColor;
            IsArrow = arrow;
            Width = width;

            LinePictureBox = new PictureBox()
            {
                Location = new Point(0, 0),
                BackColor = Color.Transparent,
                Size = new Size((int)Math.Abs(End.X - Begin.Y) + 10, (int)Math.Abs(End.Y - Begin.Y) + 10),
                Cursor = Cursors.SizeAll
            };
            ControlExtension.Draggable(LinePictureBox, true);
            Graphics g = LinePictureBox.CreateGraphics();
            g.DrawLine(new Pen(LineColor, Width), Begin, End);
            g.Dispose();
            Figure.placeToDraw.Controls.Add(LinePictureBox);
        }

        //public void DrawLine()
        //{
            
        //}
    }
}
