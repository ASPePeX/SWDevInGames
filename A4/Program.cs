﻿using System;

namespace A4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ParentA a = new ChildA();
            a.DoSomething();

            ParentB b = new ChildB();
            b.DoSomething();

            Console.ReadKey();
        }

        public class ParentA
        {
            public virtual void DoSomething()
            {
                Console.WriteLine("I’m a type A Parent");
            }
        }

        public class ChildA : ParentA
        {
            public override void DoSomething()
            {
                Console.WriteLine("I’m a type A child");
            }
        }

        public class ParentB
        {
            public void DoSomething()
            {
                Console.WriteLine("I’m a type B Parent");
            }
        }

        public class ChildB : ParentB
        {
            public new void DoSomething()
            {
                Console.WriteLine("I’m a type B child");
            }
        }
    }
}
