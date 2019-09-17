using System;
namespace LongestConsecutiveSequence
{
  class Program
  {
    static void Main()
    {
      Action<string> display = Console.WriteLine;
      display("Longest consecutive Sequence");
      int[] array1 = new int[55];
      array1 = GenerateRandomNumbers(array1.Length);

      display("Press any key to exit:");
      Console.ReadKey();
    }

    private static int[] GenerateRandomNumbers(int length)
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
