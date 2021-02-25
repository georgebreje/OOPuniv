namespace bars
{
    class Frame
    {
        HorzBar h1,h2;
        VertBar v1;

        public Frame(int width, int height)
        {
            h1 = new HorzBar(width);
            v1 = new VertBar(height, width);
        }
    }
}