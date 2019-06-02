using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyDrawing;
using System.IO;
using System.Threading;

namespace GraphicBuilder
{
    public class Ellipse : Figure
    {
        
        float A, B; //полуоси эллипса
       

        public Ellipse(PointF mouseBegin, PointF mouseEnd, Color color, PictureBox place, string name, int width = 1)
            : base(mouseBegin, mouseEnd, color, place, name, width)
        {
            
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
                A = (End.X - Begin.X) / 2;
                B = (End.Y - Begin.Y) / 2;
                Center = new PointF(Begin.X + A, Begin.Y + B);

                PointF pt1 = MainForm.graph.ConvertValues(Begin, CoordType.GetControlCoord);
                PointF pt2 = MainForm.graph.ConvertValues(End, CoordType.GetControlCoord);
                g.FillEllipse(new SolidBrush(FigureInterior), pt1.X, pt1.Y, pt2.X - pt1.X, pt2.Y - pt1.Y);
                g.DrawEllipse(new Pen(FigureColor), pt1.X, pt1.Y, pt2.X - pt1.X, pt2.Y - pt1.Y);
                
                
            }
            placeToDraw.Image = bm;
        }

        public override bool BelongsToFigure(double x, double y)
        {
            if (x >= Begin.X && x <= End.X && y <= Begin.Y && y >= End.Y) return true;
            else return false;
        }

        public override void SelectedFigure()
        {
            Graphics g; int r = 3;
            Bitmap bm = (Bitmap)placeToDraw.Image;
            using (g = Graphics.FromImage(bm))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                PointF pt1 = MainForm.graph.ConvertValues(Begin, CoordType.GetControlCoord);
                PointF pt2 = MainForm.graph.ConvertValues(End, CoordType.GetControlCoord);
                PointF pt3 = MainForm.graph.ConvertValues(Center, CoordType.GetControlCoord);
                g.DrawRectangle(new Pen(Color.Gray), pt1.X, pt1.Y, pt2.X - pt1.X, pt2.Y - pt1.Y);
                g.FillEllipse(new SolidBrush(Color.Black), pt1.X - r, pt1.Y - r, 2 * r, 2 * r);
                g.FillEllipse(new SolidBrush(Color.Black), pt2.X - r, pt2.Y - r, 2 * r, 2 * r);
                g.FillEllipse(new SolidBrush(Color.Black), pt3.X - r, pt3.Y - r, 2 * r, 2 * r);
            }
            placeToDraw.Image = bm;
        }
    }
}
