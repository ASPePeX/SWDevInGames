using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        [DllImport("kernel32.dll")]
        private static extern int GetCurrentProcessorNumber();

        static void Main(string[] args)
        {
            Thread worker = new Thread(Blub);
            worker.Start();

            Console.WriteLine(GetCurrentProcessorNumber());

        }

        public static void Blub()
        {
            Console.WriteLine(GetCurrentProcessorNumber());
        }

    }
}
