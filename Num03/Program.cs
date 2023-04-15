/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

string Mean(int[,]matr)
{
    double sum = 0;
    double result = 0;
    string Res = String.Empty;
    for (int j = 0; j < matr.GetLength(1); j++) 
    {
        sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++) 
        {
                sum = sum + matr[i,j]; 
        }
        result = sum / matr.GetLength(0);  
        string res = $"{result}";
        Res = Res + res + "; ";
    }
return Res; 
} 





Console.Clear();
int[,] Array = new int[5,5];
FillArray(Array);
PrintArray(Array);
string Res = Mean(Array);
Console.WriteLine($"Среднее арифметическое каждого столбца {Res}");
