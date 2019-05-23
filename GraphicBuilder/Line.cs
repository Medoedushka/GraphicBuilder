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
        string Name;
        //public Panel LinePictureBox;

        public Line(PointF begin, PointF end, Color lineColor, bool arrow, string name, int width = 5)
        {
            Begin = begin;
            End = end;
            LineColor = lineColor;
            IsArrow = arrow;
            Name = name;
            Width = width;

            //LinePictureBox = new Panel()
            //{
            //    Location = new Point((int)Begin.X, (int)Begin.Y),
            //    BackColor = Color.Transparent,
            //    Size = new Size((int)Math.Abs(Begin.X - End.X) + 10, (int)Math.Abs(Begin.Y - End.Y) + 10),
            //    Cursor = Cursors.SizeAll

            //};
            //ControlExtension.Draggable(LinePictureBox, true);
            //LinePictureBox.MouseClick += new MouseEventHandler(LinesPictureBox_MouseClick);
            //LinePictureBox.Paint += new PaintEventHandler(DrawLine);
            //Figure.placeToDraw.Controls.Add(LinePictureBox);
            //LinePictureBox.Refresh();
            Graphics g = Figure.placeToDraw.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.DrawLine(new Pen(Color.Red, Width), Begin, End);
            g.Dispose();
        }

        //private void LinesPictureBox_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Middle)
        //        Figure.placeToDraw.Controls.Remove(LinePictureBox);
           
        //}
        //public void DrawLine(object sender, PaintEventArgs e)
        //{
        //    Graphics g = LinePictureBox.CreateGraphics();
        //    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        //    g.DrawLine(new Pen(Color.Red), Begin.X, Begin.Y, End.X - Begin.X, End.Y - Begin.Y);
        //    g.Dispose();
        //}
    }
}
