﻿// 35. Написать программу замены элементов массива на противоположные
int N = 8;
int[] a = new int[N];
Random random = new Random();
for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(-9, 10);

for (int i = 0; i < a.Length; i++)
    Console.Write(a[i] + "   ");
    Console.WriteLine();

Zamena(ref a);

for (int i = 0; i < a.Length; i++)
    Console.Write(a[i] + "   ");
    



int[] Zamena(ref int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = a[i] * (-1);
    }
    return a;
}