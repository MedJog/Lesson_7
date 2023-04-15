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
             matr[i,j] = new Random().Next(1,5);
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
    for (int j = 0; j < matr.GetLength(1); j++) // счётчик столбцов (переход на другой столбец)
    {
        sum = 0;
        Console.WriteLine($" столбец {j}");
        for (int i = 0; i < matr.GetLength(0); i++) // счётчик для строк 
        {
                sum = sum + matr[i,j]; // подсчёт суммы
        }
        Console.WriteLine($" сумма {sum}");
        result = sum / matr.GetLength(0);  // вычисление среднего арифметического для элементов каждого столбца
        Console.WriteLine($" среднее арифметическое {result}");
        string res = $"{result}";
        Res = Res + res + "; ";
    }
return Res; 
} 





Console.Clear();
int[,] Array = new int[4,4];
FillArray(Array);
PrintArray(Array);
string Res = Mean(Array);
Console.WriteLine($"Среднее арифметическое каждого столбца {Res}");
