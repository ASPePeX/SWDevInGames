using System;

namespace A3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Fib(10));

            Console.ReadKey();
        }

        static int Fib(int x)
        {
            if (x <= 1)
                return 1;
            return Fib(x - 1) + Fib(x - 2);
        }
    }
}
