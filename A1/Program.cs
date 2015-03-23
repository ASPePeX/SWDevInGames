using System;

namespace A1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Welchen Inhalt haben foo und bar am Ende von DoSomething?
            Console.WriteLine("Struct (Value) vs. Class (Reference)");
            DoSomething();

            //Wie könnte man erreichen, dass TakeFoo sich so verhält wie TakeBar, ohne die Deklaration von Foo zu ändern?
            Console.WriteLine("Passing the Struct as reference.");
            DoSomething2();

            //Wie würden sich analoge Versionen von TakeInt(int i), TakeString(string s) und TakeArray(int[] a) verhalten?
            // int => wie struct, weil value type
            // sing / array => wie class, weil referece type

            Console.ReadKey();
        }

        public struct Foo
        {
            public int a;
        }

        public class Bar
        {
            public int b;
        }

        private static void TakeFoo(Foo f)
        {
            f.a = 12;
        }
        private static void TakeFoo2(ref Foo f)
        {
            f.a = 12;
        }

        private static void TakeBar(Bar b)
        {
            b.b = 12;
        }

        private static void DoSomething()
        {
            var foo = new Foo {a = 3};
            var bar = new Bar {b = 3};
            TakeFoo(foo);
            TakeBar(bar); // foo.a = 3 // bar.b = 12

            Console.WriteLine("foo.a = " + foo.a);
            Console.WriteLine("bar.b = " + bar.b);
        }

        private static void DoSomething2()
        {
            var foo = new Foo { a = 3 };
            var bar = new Bar { b = 3 };

            TakeFoo2(ref foo);
            TakeBar(bar); // foo.a = 12 // bar.b = 12

            Console.WriteLine("foo.a = " + foo.a);
            Console.WriteLine("bar.b = " + bar.b);
        }
    }
}
