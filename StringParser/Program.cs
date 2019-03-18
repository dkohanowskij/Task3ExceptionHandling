﻿using System;

namespace Task1
{
  class Program
  {
    private static readonly bool flag = true;
    static void Main(string[] args)
    {
      while (flag)
      {
        Console.WriteLine("Enter the string:");
        var inputString = Console.ReadLine();
        if (string.IsNullOrEmpty(inputString))
        {
          Console.WriteLine("String is null or empty!");
        }
        else
        {
          var tempStr = inputString.TrimStart();
          Console.WriteLine("Result stirng: " + tempStr.Substring(0, 1));
        }

        Console.WriteLine("\nPress any key...");
        Console.ReadKey();
      }
    }
  }
}
