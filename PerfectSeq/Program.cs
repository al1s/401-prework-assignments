using System;

namespace PerfectSeq
{
  using System.Linq;
  class Program
  {
    public static string getPerfectSequenceSharply(int[] arr)
    {
      return arr.Aggregate(0, (res, elm) => res + elm) ==
             arr.Aggregate(1, (res, elm) => res * elm)
              ? "Yes"
              : "No";
    }
    public static string getPerfectSequence(int[] arr)
    {
      string result = default(string);
      int sum = default(int);
      int product = 1;
      foreach (int item in arr)
      {
        sum += item;
        product *= item;
      }
      if (product == sum) result = "Yes";
      else result = "No";
      return result;
    }
    static void Main(string[] args)
    {
      int[] arr = new int[] { 1, 2, 3 };
      Console.WriteLine($"Is '{String.Join(" ", arr)}' perfect: {getPerfectSequence(arr)}");
      Console.WriteLine($"Is '{String.Join(" ", arr)}' sharply perfect: {getPerfectSequenceSharply(arr)}");
      arr = new int[] { 0, 0 };
      Console.WriteLine($"Is '{String.Join(" ", arr)}' perfect: {getPerfectSequence(arr)}");
      Console.WriteLine($"Is '{String.Join(" ", arr)}' sharply perfect: {getPerfectSequenceSharply(arr)}");
      arr = new int[] { 2, 2 };
      Console.WriteLine($"Is '{String.Join(" ", arr)}' perfect: {getPerfectSequence(arr)}");
      Console.WriteLine($"Is '{String.Join(" ", arr)}' sharply perfect: {getPerfectSequenceSharply(arr)}");
      arr = new int[] { 2, 2, 3 };
      Console.WriteLine($"Is '{String.Join(" ", arr)}' perfect: {getPerfectSequence(arr)}");
      Console.WriteLine($"Is '{String.Join(" ", arr)}' sharply perfect: {getPerfectSequenceSharply(arr)}");
    }
  }
}
