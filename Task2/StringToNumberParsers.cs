using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
  public static class StringToNumberParsers
  {
    public static int ParseInt(this string numString)
    {
      if (string.IsNullOrWhiteSpace(numString))
      {
        throw new ArgumentException($"{nameof(numString)} is null, empty or whitespace");
      }

      (int startPos, int sign) = ProcessFirstSymbol(numString[0]);

      int result;
      try
      {
        checked
        {
          result = numString.Substring(startPos)
            .Aggregate(0, (res, symbol) => res * 10 + GetNumber(symbol) * sign);
        }
      }
      catch (OverflowException oex)
      {
        throw new OverflowException($"{numString} is too big and cannot be stored in int type", oex);
      }

      return result;
    }

    private static int GetNumber(char charNumber)
    {
      int value = charNumber - '0';
      if (value < 0 || value > 9)
      {
        throw new FormatException($"input string contains incorrect symbol {charNumber}");
      }

      return value;
    }

    private static (int startPos, int sign) ProcessFirstSymbol(char firstSymbol)
    {
      if (firstSymbol == '-')
      {
        return (startPos: 1, sign: -1);
      }
      if (firstSymbol == '+')
      {
        return (startPos: 1, sign: 1);
      }

      return (startPos: 0, sign: 1);
    }
  }
}
