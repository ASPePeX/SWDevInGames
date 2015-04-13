using System;

namespace A3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(bla(10));

            Console.ReadKey();
        }

        static int bla(int x)
        {
            if (x <= 1)
                return 1;
            return bla(x - 1) + bla(x - 2);
        }
    }
}
