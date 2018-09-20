using System;

namespace sumOfRows
{
  class Program
  {
    public static int[] sum2DArray(int[,] arr)
    {
      int[] result = new int[arr.GetLength(0)];
      for (int i = 0; i < arr.GetLength(0); i++)
      {
        int sumOfRow = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
          sumOfRow += arr[i, j];
        }
        result[i] = sumOfRow;
      }
      return result;
    }
    static void Main(string[] args)
    {

      int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
      int[] res = sum2DArray(myArray);
      Console.WriteLine(String.Join(" ", res));
    }
  }
}
