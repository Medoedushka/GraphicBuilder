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
    public enum Collection
    {
        Lines,
        Ellipses
    }
    public abstract class Figure
    {
        public PictureBox placeToDraw { get; set; }  //контрол для отрисовки фигуры
        public Color FigureColor { get; set; }     // цвет создаваемой фигуры
        public Color FigureInterior { get; set; } //цвет заливки фигуры
        public PointF Begin { get; set; }
        public PointF End { get; set; }
        public PointF Center { get; set; }

        public string Name { get; set; }           //рабочие имя фигуры
        public int Width { get; set; }             //толщина фигуры

        public static List<Line> Lines = new List<Line>(); //коллекция созданных прямых
        public static List<Ellipse> Ellipses = new List<Ellipse>(); //коллекция созданных эллипсов

        public Figure(PointF mouseBegin, PointF mouseEnd, Color color,  PictureBox place, string name, int width = 1)
        {
            Begin = MainForm.graph.ConvertValues(mouseBegin, CoordType.GetRectangleCoord);
            End = MainForm.graph.ConvertValues(mouseEnd, CoordType.GetRectangleCoord);
            placeToDraw = place;
            FigureColor = color;
            FigureInterior = Color.FromArgb(91, 155, 213);
            Name = name;
            Width = width;
        }
        
        //Нарисовать фигуру
        public abstract void DrawFigure();
        //Находится ли курсор мыши поблизости от фигуры или на ней
        public abstract bool BelongsToFigure(double x, double y);
        //выделение фигуры
        public abstract void SelectedFigure();
        //рисует все фигуры коллекции
        public static void DrawAllFigures()
        {
            foreach (Line ln in Lines) ln.DrawFigure();
            foreach (Ellipse el in Ellipses) el.DrawFigure();
        }
    }
}
