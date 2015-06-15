using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegate
{
    // <Game Input Library>
    internal delegate void PlayerMovedDelegate();

    class InputHandler
    {
        public PlayerMovedDelegate OnUp;
        public PlayerMovedDelegate OnDown;
        public PlayerMovedDelegate OnLeft;
        public PlayerMovedDelegate OnRight;

        public InputHandler()
        {
        }

        public void Run()
        {
            for (;;)
            {
                switch (Console.ReadKey().KeyChar)
                {
                    case 'w':
                        OnUp();
                        break;
                    case 'a':
                        OnLeft();
                        break;
                    case 's':
                        OnDown();
                        break;
                    case 'd':
                        OnRight();
                        break;

                }
            }
        }
    }
    // </Game Input Library>

    class Program
    {
        static void Main(string[] args)
        {
            InputHandler myInputHandler = new InputHandler();
            
            myInputHandler.OnDown = DoTheDown;

            myInputHandler.OnUp = delegate()
            {
                Console.WriteLine("UP!");
            };

            myInputHandler.OnLeft = () =>
            {
                Console.WriteLine("Left!");
            };

            myInputHandler.OnRight = delegate
            {
                Console.WriteLine("Reight!");
            };

            myInputHandler.Run();
        }

        private static void DoTheDown()
        {
            Console.WriteLine("Down!");
        }
    }
}
