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

/* double Result(int[,]matr)
 {
    double sum = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.WriteLine($" столбец {j}");
        for (int i = 0; i < matr.GetLength(0); i++)
        {
                Console.WriteLine($" строка {i}");
                sum = sum + matr[i,j];
        }
        Console.WriteLine($" сумма {sum}");
    }
return sum / matr.GetLength(0); 
} */

double Result(int[,]matr)
{
    double sum = 0;
    double result = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        sum = 0;
        Console.WriteLine($" столбец {j}");
        for (int i = 0; i < matr.GetLength(0); i++)
        {
                //Console.WriteLine($" строка {i}");
                sum = sum + matr[i,j];
        }
        Console.WriteLine($" сумма {sum}");
        result = sum / matr.GetLength(0); 
        Console.WriteLine($" среднее арифметическое {result}");
    }
return result; 
} 






int[,] Array = new int[3,5];
FillArray(Array);
PrintArray(Array);
double Res = Result(Array);
Console.WriteLine(Res);
