namespace RationalNumbers
{
    class Rational
    {
        private int a;
        private int b;
        public Rational(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Simplify()
        {
            int acpy = a;
            int bcpy = b;
            if (a % b != 0)
            {
                if (cmmdc(a, b) != 1)
                {
                    acpy = acpy / cmmdc(a, b);
                    bcpy = bcpy / cmmdc(a, b);
                }
                /*else if (cmmdc(a,b) == 1)
                {
                    System.Console.WriteLine("can not be simplified");
                }*/
            }
            else
            {
                a = a / b;
                b = 1;
            }
            a = acpy;
            b = bcpy;
        }
        public Rational Add(Rational c)
        {
            Rational sum;
            if (b == c.b)
                sum = new Rational(a + c.a, b);
            else
                sum = new Rational(a * c.b + c.a * b, b * c.b);
            return sum;
        }
        public Rational Substraction(Rational c)
        {
            Rational sub;
            if (b == c.b)
                sub = new Rational(a + c.a, b);
            else
                sub = new Rational(a * c.b + c.a * b, b * c.b);
            return sub;
        }
        public Rational Multiply(Rational c)
        {
            Rational mult = new Rational(a*c.a,b*c.b);
            return mult;
        }
        public Rational Division(Rational c)
        {
            Rational div = new Rational(a * c.b, b * c.a);
            return div;
        }
        public static Rational operator + (Rational r1, Rational r2)
        {
            Rational sum;
            if (r1.b == r2.b)
                sum = new Rational(r1.a + r2.a, r1.b);
            else
                sum = new Rational(r1.a * r2.b + r2.a * r1.b, r1.b * r2.b);
            return sum;
        }
        public static Rational operator - (Rational r1, Rational r2)
        {
            Rational sub;
            if (r1.b == r2.b)
                sub = new Rational(r1.a + r2.a, r1.b);
            else
                sub = new Rational(r1.a * r2.b + r2.a * r1.b, r1.b * r2.b);
            return sub;
        }
        public static Rational operator * (Rational r1, Rational r2)
        {
            Rational mult = new Rational(r1.a * r2.a, r1.b * r2.b);
            return mult;
        }
        public static Rational operator / (Rational r1, Rational r2)
        {
            Rational div = new Rational(r1.a * r2.b, r1.b * r2.a);
            return div;
        }
        private int cmmdc(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
        public override string ToString()
        {
            if (b != 1)
                return a.ToString() + "/" + b.ToString();
            else if (b == 1)
                return a.ToString();
            return "";
        }
    }
}