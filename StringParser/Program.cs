using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
  class Program
  {
    static void Main(string[] args)
    {
      bool flag = true;
      while (flag)
      {
        Console.WriteLine("Enter the string:");
        string inputString = Console.ReadLine();
        if (string.IsNullOrEmpty(inputString))
        {
          Console.WriteLine("String is null or empty!");
        }
        else
        {
          string tempStr = inputString.TrimStart();
          Console.WriteLine("Result stirng: " + StringExtention.ToSystemString(tempStr.Take(1)));
        }

        Console.WriteLine("\nPress any key...");
        Console.ReadKey();
      }
    }
  }
}
