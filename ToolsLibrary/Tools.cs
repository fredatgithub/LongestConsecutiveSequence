using System;
using System.Collections.Generic;
using System.Linq;

namespace ToolsLibrary
{
  public static class Tools
  {
    public static List<string> GetConsecutiveSequences(int[] array1)
    {
      int[] tmpArray = new int[array1.Length];
      tmpArray = array1;
      List<int> tmp = tmpArray.Select(number => number).ToList();
      tmp.Sort();
      List<string> result = new List<string>();
      for (int i = 0; i < tmp.Count; i++)
      {
        if (i + 1 <= tmp.Count)
        {
          if (tmp[i + 1] == tmp[i] + 1)
          {
            for (int j = i + 1; j < tmp.Count; j++)
            {
              if (j + 1 < tmp.Count)
              {
                if (tmp[j + 1] == tmp[j + 1] + 1)
                {
                  result.Add(tmp[i].ToString() + "-" + tmp[i + 1].ToString());
                }
              }
            }
          }
        }
      }

      return result;
    }

    public static List<string> GetConsecutiveSequenceWithLinq(int[] array1)
    {
      int[] tmpArray = new int[array1.Length];
      tmpArray = array1;
      List<int> tmp = tmpArray.Select(number => number).ToList();
      tmp.Sort();
      List<string> result = new List<string>();
      //result = tmp.Aggregate<int>((n, p) => n == p + 1);
      return result;
    }

    public static int[] GenerateRandomNumbers(int length)
    {
      var rnd = new Random();
      int[] result = new int[length];
      for (int i = 0; i < length; i++)
      {
        result[i] = rnd.Next(999);
      }

      return result;
    }
  }
}