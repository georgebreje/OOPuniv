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
            int counter1 = 0, counter2 = 0;
            int numberA = 0;
            int numberB = 0;
            // parte reala != 0 si parte imaginara 0
            // parte reala 0 si parte imaginara != 0
            // parte reala > 0 si parte imaginara != 0 (parte im. poz sau neg)
            if ((int)v[0] - (int)'0' > 0 && (int)v[0] - (int)'0' < 10)
            {
                // verificare daca este un numar complex cu parte reala pozitiva si parte imaginara pozitiva
                string[] imaginaryPositive = v.Split('+');
                string[] imaginaryNegative = v.Split('-');

                if (imaginaryPositive.Length == 1 && imaginaryNegative.Length == 1)
                {
                    string[] numberi = v.Split('i');
                    if (numberi.Length == 2)
                    {
                        while (counter < imaginaryPositive[0].Length && char.IsDigit(v[counter]))
                        {
                            numberB = numberB * 10 + ((int)v[counter] - (int)'0');
                            counter++;
                        }
                        numberA = 0;
                    } else if (numberi.Length == 1)
                    {
                        while (counter < imaginaryPositive[0].Length && char.IsDigit(v[counter]))
                        {
                            numberA = numberA * 10 + ((int)v[counter] - (int)'0');
                            counter++;
                        }
                        numberB = 0;
                    }
                } else
                {
                    //daca partea imaginara este pozitiva
                    if (imaginaryPositive.Length == 2)
                    {
                        while (counter1 < imaginaryPositive[0].Length && char.IsDigit(v[counter1]))
                        {
                            numberA = numberA * 10 + ((int)v[counter1] - (int)'0');
                            counter1++;
                        }
                        while (counter2 < imaginaryPositive[1].Length && counter1 < imaginaryPositive[1].Length + imaginaryPositive[0].Length)
                        {
                            if (char.IsDigit(v[counter1]))
                            {
                                numberB = numberB * 10 + ((int)v[counter1] - (int)'0');
                                counter2++;
                            }
                            counter1++;
                        }
                    }
                    else if (imaginaryNegative.Length == 2)  // daca partea imaginara este negativa
                    {
                        while (counter1 < imaginaryNegative[0].Length && char.IsDigit(v[counter1]))
                        {
                            numberA = numberA * 10 + ((int)v[counter1] - (int)'0');
                            counter1++;
                        }
                        while (counter2 < imaginaryNegative[1].Length && counter1 < imaginaryNegative[1].Length + imaginaryNegative[0].Length)
                        {
                            if (char.IsDigit(v[counter1]))
                            {
                                numberB = numberB * 10 + ((int)v[counter1] - (int)'0');
                                counter2++;
                            }
                            counter1++;
                        }
                        numberB = 0 - numberB;
                    }  

                }
            }
            // parte reala negativa && parte im = 0
            // parte reala = 0 && parte im negativa
            // parte reala negativa && parte im ! = 0
            else 
            {
                string[] negative = v.Split('-');
                string[] realNegative = v.Split('-', '+');
                if (negative.Length == 2 && realNegative.Length == 2)
                {
                    string[] numberi = v.Split('i');
                    if(numberi.Length == 2)
                    {
                        while (counter < negative[0].Length && char.IsDigit(v[counter]))
                        {
                            numberB = numberB * 10 + ((int)v[counter] - (int)'0');
                            counter++;
                        }
                        numberA = 0;
                    } else
                    {
                        while (counter < negative[0].Length && char.IsDigit(v[counter]))
                        {
                            numberA = numberA * 10 + ((int)v[counter] - (int)'0');
                            counter++;
                        }
                        numberB = 0;
                    }
                }
                if (realNegative.Length == 3 && negative.Length == 2)
                {
                    while (counter <= realNegative[1].Length && counter1 <= realNegative[0].Length+realNegative[1].Length)
                    {
                        if(char.IsDigit(v[counter1]))
                        {
                            numberA = numberA * 10 + ((int)v[counter1] - (int)'0');
                            counter++;
                        }
                        counter1++;
                    }
                    numberA = 0 - numberA;
                    while(counter2 <= realNegative[2].Length && counter1 < v.Length)
                    {
                        if (char.IsDigit(v[counter1]))
                        {
                            numberB = numberB * 10 + ((int)v[counter1] - (int)'0');
                            counter2++;
                        }
                        counter1++;
                    }
                }
                if(negative.Length == 3)
                {
                    while (counter <= negative[1].Length && counter1 <= negative[0].Length + negative[1].Length)
                    {
                        if (char.IsDigit(v[counter1]))
                        {
                            numberA = numberA * 10 + ((int)v[counter1] - (int)'0');
                            counter++;
                        }
                        counter1++;
                    }
                    numberA = 0 - numberA;
                    while(counter2 <= negative[2].Length && counter1 < v.Length)
                    {
                        if (char.IsDigit(v[counter1]))
                        {
                            numberB = numberB * 10 + ((int)v[counter1] - (int)'0');
                            counter2++;
                        }
                        counter1++;
                    }
                    numberB = 0 - numberB;
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