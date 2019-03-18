using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
  public static class StringExtention
  {
    public static string ToSystemString(this IEnumerable<char> source)
    {
      return new string(source.ToArray());
    }
  }
}
