using System;

namespace Slump
{
  class Program
  {
    static void Main(string[] args)
    {
      Random generator = new Random();
      Random secondGenerator = new Random();


      while (true)
      {
        int tal = generator.Next(-100, 100);
        // int tal2 = secondGenerator.Next(50, 101);

        // int sum = (tal + tal2) / 2;

        Console.WriteLine(tal);
        // Console.WriteLine("Från tvåan: " + tal2);
        Console.ReadLine();
      }




    }
  }
}
