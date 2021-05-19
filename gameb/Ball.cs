using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace gameb
{
    class Ball
    {
        private int id;
        private double radius;
        private double x;
        private double y;
        private double dx,dy;
        private double speed;
        private Color color;
        private string type;
        private static Random rnd = new Random();

        public Ball()
        {
            this.radius = rnd.Next(5, 30);
            this.x = rnd.Next(0, 1000);
            this.y = rnd.Next(0, 600);
            this.dx = rnd.Next(-180, 181);
            this.dy = rnd.Next(-180, 181);
            this.speed = rnd.Next(20, 30);
            this.color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
        }
        public Ball(int id, string type)
        {
            this.type = type;
            this.id = id;
            this.radius = rnd.Next(15, 30);
            this.x = rnd.Next(0, 1000);
            this.y = rnd.Next(0, 600);
            this.dx = rnd.Next(-180, 181);
            this.dy = rnd.Next(-180, 181);
            this.speed = rnd.Next(1, 5);
            this.color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
        }

        public void Draw(List<Ball> list, Graphics grp, Bitmap bmp)
        {
            foreach (Ball b in list)
            {
                SolidBrush brush = new SolidBrush(b.Color);
                grp.FillEllipse(brush, (float)b.X, (float)b.Y, (float)b.Radius, (float)b.Radius);
                using (Font myFont = new Font("Arial", 10))
                {
                    grp.DrawString(b.Type, myFont, Brushes.Black, new PointF((float)b.X, (float)b.Y));
                }
            }
        }

        public void Move()
        {
            this.x += -180;
            this.y += -180;
        }  

        public int Id
        {
            get
            {
                return Id;
            }
            
            set
            {
                id = value;
            }
        }
        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set { y = value; }
        }
        
        public double Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }
        public Color Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
    }
}
