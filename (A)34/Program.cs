﻿// 34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int N = 8;
int[] a = new int[N];
Random random = new Random();
for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(100, 1000);

int chet = 0;

for (int i = 0; i < a.Length; i++)
{
    Console.Write(a[i] + "   ");
    if (a[i] % 2 == 0) chet = chet + 1;
   
}

Console.WriteLine();
Console.WriteLine(chet);

