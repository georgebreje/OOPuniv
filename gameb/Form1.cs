using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameb
{
    public partial class Form1 : Form
    {
        private const double PI = Math.PI;
        private Bitmap bmp;
        private Graphics grp;
        private List<Ball> list;
        private int dx = 3, dy = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(1200, 600);
            grp = Graphics.FromImage(bmp);
            int rep = 3, mon = 1, reg = 4;
            list = new List<Ball>();
            int localId = 0;
            for (int i = 0; i < rep; i++)
            {
                list.Add(new Ball(localId, "rep"));
                localId++;
            }
            for (int i = 0; i < mon; i++)
            {
                list.Add(new Ball(localId, "mon"));
                localId++;
            }
            for (int i = 0; i < reg; i++)
            {
                list.Add(new Ball(localId, "reg"));
                localId++;
            }
            //foreach (Ball b in list)
            //{
            //    SolidBrush brush = new SolidBrush(b.Color);
            //    grp.FillEllipse(brush, (float)b.X, (float)b.Y, (float)b.Radius, (float)b.Radius);
            //    using (Font myFont = new Font("Arial", 10))
            //    {
            //        grp.DrawString(b.Type, myFont, Brushes.Black, new PointF((float)b.X, (float)b.Y));
            //    }
            //}
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Ball b in list) 
            {
                b.Move();
                SolidBrush brush = new SolidBrush(b.Color);
                grp.FillEllipse(brush, (float)b.X, (float)b.Y, (float)b.Radius, (float)b.Radius);
                using (Font myFont = new Font("Arial", 10))
                {
                    grp.DrawString(b.Type, myFont, Brushes.Black, new PointF((float)b.X, (float)b.Y));
                }
            }
            pictureBox1.Refresh();
            pictureBox1.Image = bmp;

        }
    }
}
