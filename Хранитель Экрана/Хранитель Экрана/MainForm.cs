using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Хранитель_Экрана
{

    public partial class MainForm : Form
    {
        Graph graph;
        List<Figure> FigVam = new List<Figure>();
        Figure f, f1, f2, f3, f4, f5;

        public MainForm()
        {
            InitializeComponent();
            this.Width = SystemInformation.PrimaryMonitorSize.Width;
            this.Height = SystemInformation.PrimaryMonitorSize.Height;

            graph = new Graph(picture);

            initfigure();
            tm.Enabled = true;
        }
        void initfigure()
        {


            f = new Figure(50, 50, 80, 80, 3, 2);
            f1 = new Figure(150, 150, 30, 30, -6, -7);
            f2 = new Figure(190, 190, 50, 50, -6, -3);
            f3 = new Figure(160, 160, 90, 90, 6, 2);
            f4 = new Figure(180, 180, 60, 60, -6, -4);
            f5 = new Figure(250, 250, 50, 50, -4, -6);
            FigVam.Add(f);
            FigVam.Add(f1);
            FigVam.Add(f2);
            //  FigVam.Add(f3);
            //  FigVam.Add(f4);
            //  FigVam.Add(f5);
            f.setMinMax(0, 0, picture.Width, picture.Height);
        }

        private void tm_Tick(object sender, EventArgs e)
        {

            graph.EraseLine(f, f1);
            graph.EraseLine(f1, f2);
            graph.EraseLine(f2, f);
            // graph.EraseLine(f2, f3);
            //  graph.EraseLine(f3, f4);
            // graph.EraseLine(f4, f5);
            // graph.EraseLine(f5, f);
            //
            foreach (var figura in FigVam)
            {
                graph.EraseCircle(figura);
            }

            foreach (var figura in FigVam)
            {
                figura.move();
            }

            foreach (var figura in FigVam)
            {
                graph.DrawCircle(figura);
            }

            graph.DrawLine(f, f1);
            graph.DrawLine(f1, f2);
            graph.DrawLine(f2, f);
            //  graph.DrawLine(f2, f3);
            //  graph.DrawLine(f3, f4);
            //  graph.DrawLine(f4, f5);
            //  graph.DrawLine(f5, f);

        }

        private void picture_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
