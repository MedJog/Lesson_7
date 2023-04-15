/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

using System;
using static System.Console;

Clear();
Write("Введите количество строк массива: ");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int n = int.Parse(ReadLine());
double[,] array = FillArray(m,n);
PrintArray(array);


double[,] FillArray(int m, int n)
{
    double[,] Array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
        {
             Array[i, j] =  Convert.ToDouble(random.Next(-100, 100)/10.0); // генератор дробных чисел
        }
        }
        return Array;
}
void PrintArray(double[,] Arr)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
        {
            for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Write($"{Arr[i,j]} ");
                }
            WriteLine();
        }
}






