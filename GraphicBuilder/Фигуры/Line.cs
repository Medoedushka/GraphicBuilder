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
    public class Line : Figure
    {
        bool IsArrow;       //является ли стрелкой
        
        public Line(PointF mouse_begin, PointF mouse_end, Color lineColor, PictureBox place,  bool arrow, string name, int width = 1)
        {
            //Получение координат в прямоугольной системе
            float x = MainForm.graph.ConvertValues(mouse_begin.X, mouse_begin.Y, CoordType.GetRectangleCoord).X;
            float y = MainForm.graph.ConvertValues(mouse_begin.X, mouse_begin.Y, CoordType.GetRectangleCoord).Y;
            Begin = new PointF(x, y);

            x = MainForm.graph.ConvertValues(mouse_end.X, mouse_end.Y, CoordType.GetRectangleCoord).X;
            y = MainForm.graph.ConvertValues(mouse_end.X, mouse_end.Y, CoordType.GetRectangleCoord).Y;
            End = new PointF(x, y);

            placeToDraw = place;
            FigureColor = lineColor;
            IsArrow = arrow;
            Name = name;
            Width = width;

            DrawFigure();
        }

        public override void DrawFigure()
        {
            Graphics g;
            Bitmap bm = (Bitmap)placeToDraw.Image;
            using (g = Graphics.FromImage(bm))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                PointF pt1 = new PointF(0, 0), pt2 = new PointF(0, 0);

                pt1.X = MainForm.graph.ConvertValues(Begin.X, Begin.Y, CoordType.GetControlCoord).X;
                pt1.Y = MainForm.graph.ConvertValues(Begin.X, Begin.Y, CoordType.GetControlCoord).Y;

                pt2.X = MainForm.graph.ConvertValues(End.X, End.Y, CoordType.GetControlCoord).X;
                pt2.Y = MainForm.graph.ConvertValues(End.X, End.Y, CoordType.GetControlCoord).Y;

                g.DrawLine(new Pen(Color.Red, Width), pt1, pt2);

            }
            placeToDraw.Image = bm;
        }
        public override bool BelongsToFigure(double x, double y)
        {
            bool result = false;
            if (Math.Abs(y - Begin.Y - (x - Begin.X) * (End.Y - Begin.Y) / (End.X - Begin.X)) < 0.1) result = true;
            if (Math.Abs(x - Begin.X - (y - Begin.Y) * (End.X - Begin.X) / (End.Y - Begin.Y)) < 0.1) result = true;
            return result;
        }
        public override void SelectedFigure()
        {
            Graphics g; int r = 3;
            Bitmap bm = (Bitmap)placeToDraw.Image;
            using (g = Graphics.FromImage(bm))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                PointF pt1 = new PointF(0, 0), pt2 = new PointF(0, 0);

                pt1 = MainForm.graph.ConvertValues(Begin.X, Begin.Y, CoordType.GetControlCoord);
                pt2 = MainForm.graph.ConvertValues(End.X, End.Y, CoordType.GetControlCoord);
                
                g.FillEllipse(new SolidBrush(Color.Black), pt1.X - r, pt1.Y - r, 2*r, 2*r);
                g.FillEllipse(new SolidBrush(Color.Black), pt2.X - r, pt2.Y - r, 2*r, 2*r);
                

            }
            placeToDraw.Image = bm;
        }
    }
}
