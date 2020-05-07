using System;

namespace BlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while(cont)
            {
                Blockbuster b = new Blockbuster();
                b.CheckOut();
            }
        }
    }
}
