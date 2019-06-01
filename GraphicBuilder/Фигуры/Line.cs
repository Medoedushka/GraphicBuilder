﻿using System;
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

            Begin = MainForm.graph.ConvertValues(mouse_begin.X, mouse_begin.Y, CoordType.GetRectangleCoord);
            
            End = MainForm.graph.ConvertValues(mouse_end.X, mouse_end.Y, CoordType.GetRectangleCoord);

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

                g.DrawLine(new Pen(FigureColor, Width), pt1, pt2);

                if (IsArrow)
                {
                    double angle = 15 * Math.PI / 180;
                    double ArrowLength = 1;
                    double LineLength = Math.Sqrt(Math.Pow(End.X - Begin.X, 2) + Math.Pow(End.Y - Begin.Y, 2));
                    double k = ArrowLength / LineLength;
                    
                    PointF vector = new PointF((float)(-k * End.X + k * Begin.X), (float)(-k * End.Y + k * Begin.Y));

                    PointF FirstPt = new PointF((float)(vector.X * Math.Cos(angle) - vector.Y * Math.Sin(angle)),
                        (float)(vector.X * Math.Sin(angle) + vector.Y * Math.Cos(angle)));
                    PointF SecondPt = new PointF((float)(vector.X * Math.Cos(angle) + vector.Y * Math.Sin(angle)),
                        (float)(-vector.X * Math.Sin(angle) + vector.Y * Math.Cos(angle)));

                    g.DrawLine(new Pen(FigureColor), pt2, MainForm.graph.ConvertValues(ConvertVecors(FirstPt, true, End), CoordType.GetControlCoord));
                    g.DrawLine(new Pen(FigureColor), pt2, MainForm.graph.ConvertValues(ConvertVecors(SecondPt, true, End), CoordType.GetControlCoord));
                }

            }
            placeToDraw.Image = bm;
        }

        private PointF ConvertVecors(PointF vector, bool makegeom, PointF beginPoint)
        {
            
            if (makegeom)
            {
                return new PointF(vector.X + beginPoint.X, vector.Y + beginPoint.Y);
            }
            else return new PointF(vector.X - beginPoint.X, vector.Y - beginPoint.Y);
            
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
