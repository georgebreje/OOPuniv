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
        private int radius;
        private int x;
        private int y;
        private int dirsense;
        private int speed;
        private Color color;
        private string type;
        private Random rnd = new Random();

        public Ball()
        {
            this.radius = rnd.Next(5, 30);
            this.x = rnd.Next(0, 1000);
            this.y = rnd.Next(0, 600);
            this.dirsense = rnd.Next(-180, 181);
            this.speed = rnd.Next(1, 5);
            this.color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
        }

        public int Radius
        {
            get
            {
                return radius;
            }
        }
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return Y;
            }
        }
        public int Dirsense
        {
            get
            {
                return dirsense;
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
        }
        public Color Color
        {
            get
            {
                return color;
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
