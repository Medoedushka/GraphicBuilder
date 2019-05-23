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
    public class Figure
    {
        public List<Line> Lines = new List<Line>();

        public static PictureBox placeToDraw;

        public Figure(PictureBox place)
        {
            placeToDraw = place;
        }
        
    }
}
