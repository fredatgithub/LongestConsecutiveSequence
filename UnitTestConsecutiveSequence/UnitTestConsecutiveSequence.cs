using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolsLibrary;
using System.Collections.Generic;

namespace UnitTestConsecutiveSequence
{
  [TestClass]
  public class UnitTestConsecutiveSequence
  {
    [TestMethod]
    public void TestMethod_list_2_elements()
    {
      int[] source = { 15, 4, 3, 12, 111 };
      List<string> expected = new List<string> { "3-4" };
      List<string> result = Tools.GetConsecutiveSequences(source);
      Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_list_3_elements()
    {
      int[] source = { 15, 4, 3, 12, 111, 5 };
      List<string> expected = new List<string> { "3-4-5" };
      List<string> result = Tools.GetConsecutiveSequences(source);
      Assert.IsTrue(AssertListAreEqualed(result, expected));
    }

    public static bool AssertListAreEqualed(List<string> list1, List<string> list2)
    {
      if (list1.Count != list2.Count)
      {
        return false;
      }

      bool result = true;
      for (int i = 0; i < list1.Count; i++)
      {
        if (list1[i] != list2[i])
        {
          result = false;
          break;
        }
      }

      return result;
    }
  }
}
