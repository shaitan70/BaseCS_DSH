﻿// 40. Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. 
// Создайте массив, который является произведением пар чисел в одномерном массиве a. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int N = 6;
int[] a = new int[N];
Random random = new Random();
for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(1, 11);

int[] b = new int[N / 2];
for (int i = 0; i < a.Length / 2; i++)
{
    System.Console.WriteLine($"{a[i]} {a[a.Length - i - 1]}");
    b[i] = a[i] * a[a.Length - i - 1];
}

for (int i = 0; i < a.Length; i++)
    Console.Write(a[i] + "   ");
Console.WriteLine();
for (int i = 0; i < b.Length; i++)
    System.Console.Write($"{b[i],4}");
System.Console.WriteLine();