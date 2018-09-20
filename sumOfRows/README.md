# Sum of Rows

#### Problem Statement

Given a matrix of integers. Return the sum of each row in a single dimensional array.

#### Input Format

a multidimensional array with the dimensions of **m x n** (m = rows, n = columns).

1. duplicate integers are possible.
2. Negative numbers are possible
3. both **m** and **n** can vary in length

#### Sample Input

`csharp int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };`

^^ The actual input would just be `myArray`, but the above code shows the pre-initialization before the method is called.

#### Sample Output
{10,40,65} <-- an integer array
![image](https://al1s.github.com/401-prework-assignments/sumOfRows/screenshot_sumofrows.gif)
