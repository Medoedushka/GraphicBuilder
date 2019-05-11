using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicBuilder
{
    class TextLabel : Label
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            float x = ClientRectangle.Left;
            float y = ClientRectangle.Top + ClientSize.Height / 2f - Font.Height / 2f;

            char prev = ' ';

            using (var brush = new SolidBrush(ForeColor))
            using (var smallFont = new Font(Font.FontFamily, Font.Size * 0.9f))
                foreach (var c in Text)
                {
                    if (c != '_' && c != '^')
                    {
                        var yy = y;
                        var font = Font;

                        switch (prev)
                        {
                            case '_':
                                font = smallFont;
                                yy += Font.Height / 4;
                                break;
                            case '^':
                                font = smallFont;
                                yy -= Font.Height / 4;
                                break;
                        }

                        var s = c.ToString();
                        var size = e.Graphics.MeasureString(s == " " ? "." : s, font, 100, StringFormat.GenericTypographic);
                        e.Graphics.DrawString(s, font, brush, x, yy, StringFormat.GenericTypographic);
                        x += size.Width;
                    }
                    prev = c;
                }
        }
    }
}
