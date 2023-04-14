/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
             matr[i,j] = new Random().Next(1,10);
        }
    }
} 

void PrintArray(int[,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
} 

void Elements(int[,] matr, int i, int j)
{
    int row = matr.GetLength(0);
    int column = matr.GetLength(1);
    if (i < row && j < column)
    {
        Console.WriteLine($"Элемент на позиции [{i},{j}] --> {matr[i,j]}");
    }

    else
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
}

int[,] Array = new int[5,5];
FillArray(Array);
PrintArray(Array);
Elements(Array, 3, 4);

 
