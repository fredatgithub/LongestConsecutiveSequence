using System;
using System.Collections.Generic;
using ToolsLibrary;

namespace LongestConsecutiveSequence
{
  class Program
  {
    static void Main()
    {
      Action<string> display = Console.WriteLine;
      display("Longest consecutive Sequence");
      int[] array1 = new int[55];
      array1 = Tools.GenerateRandomNumbers(array1.Length);
      List<string> consecutiveSequence = new List<string>();
      consecutiveSequence = Tools.GetConsecutiveSequences(array1);
      if (consecutiveSequence.Count == 0)
      {
        display("no consecutive sequence found");
      }
      else
      {
        display($"consecutive sequence found in result list for {consecutiveSequence.Count} elements");
        foreach (var item in consecutiveSequence)
        {
          display(item);
        }
      }

      display("Press any key to exit:");
      Console.ReadKey();
    }
  }
}