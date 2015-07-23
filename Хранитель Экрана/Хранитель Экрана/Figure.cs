using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Хранитель_Экрана
{
    public class Figure
    {
        static Pixel min, max;

        public Pixel p, s, d;

        Random rnd = new Random(DateTime.Now.Millisecond);
        Color col;
        public Pen pen;
        public Figure(int x, int y, int dw, int dh, int sx, int sy)
        {
            p = new Pixel(x, y);
            s.x = sx;
            s.y = sy;
            d.x = dw - 5;
            d.y = dh - 5;
            col = Color.FromArgb(rnd.Next( 50, 256), rnd.Next(50, 256), rnd.Next(50, 256));
            pen = new Pen(col, 2.0f);

        }
        public void setMinMax(int minx, int miny, int maxx, int maxy)
        {
            min.x = minx;
            min.y = miny;
            max.x = maxx;
            max.y = maxy;
        }

        public void move()
        {
            if (p.x < min.x) { s.x = -s.x; p.x = -p.x; }
            if (p.x > max.x - d.x) { s.x = -s.x; p.x = max.x - d.x; }
            if (p.y < min.y) { s.y = -s.y; p.y = -p.y; }
            if (p.y > max.y - d.y) { s.y = -s.y; p.y = max.y - d.y; }
            p.x += s.x;
            p.y += s.y;
        }
    }
}
