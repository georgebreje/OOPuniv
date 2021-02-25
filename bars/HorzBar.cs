namespace bars
{
    class HorzBar
    {
        private int width;
        public HorzBar(int width)
        {
            this.width = width;
            System.Console.Write("+");
            for (int i = 0; i < width; i++)
            {
                System.Console.Write("-");
            }
            System.Console.Write("+");
            System.Console.WriteLine();
        }
    }
}