// Decompiled with JetBrains decompiler
// Type: A3.Program
// Assembly: A3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE3259C1-F225-4879-921F-C315F4C36213
// Assembly location: D:\A3.exe

using System;

namespace A3
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine(Program.Fib(10));
      Console.ReadKey();
    }

    private static int Fib(int x)
    {
      if (x <= 1)
        return 1;
      return Program.Fib(x - 1) + Program.Fib(x - 2);
    }
  }
}
