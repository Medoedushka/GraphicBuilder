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
    public class Line
    {
        PointF Begin, End;  // начало и конец отрезка
        Color LineColor;    //цвета отрезка
        bool IsArrow;       //является ли стрелкой
        public string Name; // название 
        int Width;          //толщина

        public Line(PointF mouse_begin, PointF mouse_end, Color lineColor, bool arrow, string name, int width = 1)
        {
            //Получение координат в прямоугольной системе
            float x = MainForm.graph.ConvertValues(mouse_begin.X, mouse_begin.Y, CoordType.GetRectangleCoord).X;
            float y = MainForm.graph.ConvertValues(mouse_begin.X, mouse_begin.Y, CoordType.GetRectangleCoord).Y;
            Begin = new PointF(x, y);

            x = MainForm.graph.ConvertValues(mouse_end.X, mouse_end.Y, CoordType.GetRectangleCoord).X;
            y = MainForm.graph.ConvertValues(mouse_end.X, mouse_end.Y, CoordType.GetRectangleCoord).Y;
            End = new PointF(x, y);
                        
            LineColor = lineColor;
            IsArrow = arrow;
            Name = name;
            Width = width;

            DrawLine();
        }

        public void DrawLine()
        {

            Graphics g;
            Bitmap bm = (Bitmap)Figure.placeToDraw.Image;
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
            Figure.placeToDraw.Image = bm;
            //MainForm.graph.DrawDiagram();
        }

        public bool BelongsToSegment(double x, double y, Line line)
        {
            bool result = false;
            if (Math.Abs(y - Begin.Y - (x - Begin.X) * (End.Y - Begin.Y) / (End.X - Begin.X)) < 0.5) result = true;
            if (Math.Abs(x - Begin.X - (y - Begin.Y) * (End.X - Begin.X) / (End.Y - Begin.Y)) < 0.5) result = true;
            return result;
        }
    }
}
