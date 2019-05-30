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
        Lines
    }
    public abstract class Figure
    {
        public PictureBox placeToDraw { get; set; }  //контрол для отрисовки фигуры
        public Color FigureColor { get; set; }     // цвет создаваемой фигуры
        public string Name { get; set; }    //рабочие имя фигуры
        public int Width { get; set; }             //толщина фигуры

        public static List<Line> Lines = new List<Line>(); //коллекция созданных прямых
        
        //Нарисовать фигуру
        public abstract void DrawFigure();
        //Находится ли курсор мыши поблизости от фигуры или на ней
        public abstract bool BelongsToFigure(double x, double y);
        //выделение фигуры
        public abstract void SelectedFigure();
        //рисует все фигуры коллекции
        public static void DrawAllFigures(Collection col)
        {
            if (col == Collection.Lines)
            {
                foreach (Line ln in Lines) ln.DrawFigure();
            }
        }
    }
}
