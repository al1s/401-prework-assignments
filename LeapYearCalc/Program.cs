using System;

namespace LeapYearCalc
{
  class Program
  {
    public static bool isLeap(string year)
    {
      return (Int32.Parse(year) % 4 == 0 && Int32.Parse(year) % 100 != 0) ||
              Int32.Parse(year) % 400 == 0;
    }
    static void Main(string[] args)
    {
      Console.WriteLine($"Is 1997 leap: {isLeap("1997")}");
      Console.WriteLine($"Is 1996 leap: {isLeap("1996")}");
      Console.WriteLine($"Is 1900 leap: {isLeap("1900")}");
      Console.WriteLine($"Is 2000 leap: {isLeap("2000")}");
    }
  }
}
