namespace ComplexNumbers
{
    class Complex
    {
        private double a;
        private double b;

        public Complex(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public Complex(string v)
        {
            int counter = 0;
            int numberA = 0;
            int numberB = 0;
            // daca unul din numere este pozitiv si celalalt este 0
            if ((int)v[0] - (int)'0' > 0 && (int)v[0] - (int)'0' < 10)
            {
                string[] numberOne = v.Split('+', '-');
                if (numberOne.Length == 1)
                {
                    string[] numberi = v.Split('i');
                    if (numberi.Length == 2)
                    {
                        while (counter < numberOne[0].Length && char.IsDigit(v[counter]))
                        {
                            numberB = numberB * 10 + ((int)v[counter] - (int)'0');
                            counter++;
                        }
                        numberA = 0;
                    } else if (numberi.Length == 1)
                    {
                        while (counter < numberOne[0].Length && char.IsDigit(v[counter]))
                        {
                            numberA = numberA * 10 + ((int)v[counter] - (int)'0');
                            counter++;
                        }
                        numberB = 0;
                    }
                }
            }
            this.a = numberA;
            this.b = numberB;
        }
        public override string ToString()
        {
            if (a != 0 && b > 0)
            {
                if (b == 1)
                {
                    return a.ToString() + "+" + "i";
                } else
                return a.ToString() + "+" + b.ToString() + "i";
            }
            else if (a != 0 && b < 0)
            {
                if (b == -1)
                {
                    return a.ToString() + "-" + "i";
                }
                else
                    return a.ToString() + b.ToString() + "i";
            }
            else if (a != 0 && b == 0)
            {
                return a.ToString();

            }
            else if (a == 0 && b != 0)
            {
                if (b != 1 && b != -1)
                    return b.ToString() + "i";
                else if (b == 1)
                    return "i";
                else if (b == -1)
                    return "-i";
            }
            return "";
        }
    }
}