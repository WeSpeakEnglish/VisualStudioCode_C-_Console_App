using System;
using Library;

namespace console_app
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine($"The answer is {new CalcUs().Get(40, 3)}");
    }
  }
}