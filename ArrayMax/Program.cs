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
      } while (!isInputNumber);
      return inpNumber;
    }
    static int getCountIndexes(int[] arr, int number)
    {
      int elmCounter = default(int);
      int startPos = -1;
      do
      {
        startPos = Array.IndexOf(arr, number, startPos + 1);
        elmCounter += 1;
      } while (startPos != -1);
      return elmCounter - 1;
    }
    public static int GetArrayMax()
    {
      int[] inpArr = new int[5];
      // int[] inpArr = new int[5] { 2, 3, 4, 5, 2 };
      int inpNumber = default(int);
      for (int i = 0; i < 5; i++)
      {
        inpArr[i] = getInputNumber($"Enter a number ({i + 1} of 5)");
      }
      inpNumber = getInputNumber(
        $"Choose a number from {String.Join(" ", inpArr)}"
      );
      return (int)Math.Pow(inpNumber, getCountIndexes(inpArr, inpNumber));
    }
    static void Main(string[] args)
    {
      Console.WriteLine($"Score is: {GetArrayMax()}");
    }
  }
}
