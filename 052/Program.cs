﻿// 52 В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.
int[,] arr = Create2DArray(3,4);
PrintArray2D(arr);
Console.WriteLine();

int[,] arr2 = new int[arr.GetLength(0),arr.GetLength(1)];
for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           arr2[i,j]=arr[i,j];
        }
        
    }
Zamenachet(arr2);
PrintArray2D(arr2);



void PrintArray2D(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write($"{a[i, j],3} ");
        }
        System.Console.WriteLine();
    }
}

int[,] Create2DArray(int n, int m, int min = 0, int max = 100)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.Next(min, max + 1);
    return a;
}

int[,] Zamenachet(int[,] b)
{
    for (int i = 0; i < b.GetLength(0); i = i + 2)
    {

        for (int j = 0; j < b.GetLength(1); j = j + 2)
        {
            b[i, j] = b[i, j] * b[i, j];
        }

    }

    return b;
}