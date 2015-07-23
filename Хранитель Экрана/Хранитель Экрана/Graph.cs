using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Хранитель_Экрана
{
    public struct Pixel
    {
        public int x;
        public int y;
        public Pixel(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Graph
    {
        PictureBox picture;
        Bitmap bmp;
        Bitmap bmpN;
        Graphics graph;
        Graphics graphN;
        Pen penForge;
        public Pen PenBack;
        public Pixel min, max, s, p;
        Random rnd;
        Color col;
        Rectangle fullsize;






        public Graph(PictureBox picture)
        {

            rnd = new Random();
            col = Color.FromArgb(rnd.Next(20, 255), rnd.Next(20, 255), rnd.Next(20, 255));
            this.picture = picture;
            bmp = new Bitmap(picture.Width, picture.Height);
            bmpN = new Bitmap(picture.Width, picture.Height);
            fullsize = Screen.PrimaryScreen.Bounds;

            graph = Graphics.FromImage(bmp);
            graphN = Graphics.FromImage(bmpN);
            graph.CopyFromScreen(fullsize.Left, fullsize.Top, 0, 0, fullsize.Size);
            graphN.CopyFromScreen(fullsize.Left, fullsize.Top, 0, 0, fullsize.Size);
            // graph.Clear(Color.White);
            penForge = new Pen(col, 2.0f);
            PenBack = new Pen(Color.White, 2.0f);
        }

        public void test()
        {


        }
        public void EraseCircle(Figure f)
        {
            graph.DrawEllipse(PenBack, f.p.x, f.p.y, f.d.x, f.d.y);
            picture.Image = bmp;
        }

        public void DrawCircle(Figure f)
        {

            graph.DrawEllipse(f.pen, f.p.x, f.p.y, f.d.x, f.d.y);

            picture.Image = bmpN;
            picture.Image = bmp;
        }

        public void EraseLine(Figure f1, Figure f2)
        {
            graph.DrawLine(PenBack, f1.p.x + (f1.d.x / 2), f1.p.y + (f1.d.y / 2), f2.p.x + (f2.d.x / 2), f2.p.y + (f2.d.y / 2));
            picture.Image = bmp;
            //graph.Clear(Color.White);
        }
        public void DrawLine(Figure f1, Figure f2)
        {
            graph.DrawLine(penForge, f1.p.x + (f1.d.x / 2), f1.p.y + (f1.d.y / 2), f2.p.x + (f2.d.x / 2), f2.p.y + (f2.d.y / 2));
            picture.Image = bmp;
        }
    }
}
