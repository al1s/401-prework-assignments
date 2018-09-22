using System;

namespace ArrayMax
{
  class Program
  {
    static int getInputNumber(string userMessage)
    {
      bool isInputNumber = default(bool);
      int inpNumber = default(int);
      do
      {
        Console.WriteLine(userMessage);
        isInputNumber = Int32.TryParse(Console.ReadLine(), out inpNumber);
      } while (isInputNumber);
      return inpNumber;
    }
    static int getCountIndexes(int[] arr, int number)
    {
      int elmIndex = default(int);
      int elmCounter = default(int);
      do
      {
        elmIndex = Array.IndexOf(arr, number);
        elmCounter += 1;
      } while (elmIndex != -1);
      return elmCounter;
    }

    public static int GetArrayMax()
    {
      int[] inpArr = new int[5];
      int inpNumber = default(int);
      for (int i = 0; i < 5; i++)
      {
        inpArr[i] = getInputNumber($"Enter a number ({i + 1} of 5)");
      }
      inpNumber = getInputNumber(
        $"Choose a number from {String.Join(" ", inpArr)}"
      );
      return inpNumber ^ getCountIndexes(inpArr, inpNumber);
    }
    static void Main(string[] args)
    {
      Console.WriteLine($"Score is: {GetArrayMax()}");
    }
  }
}
