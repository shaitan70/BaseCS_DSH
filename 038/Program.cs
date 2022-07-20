// 38 В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int N = 123;
int[] a = new int[N];
Random random = new Random();
for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(0, 1000);

int k = 0;

for (int i = 0; i < a.Length; i++)
{
    Console.Write(a[i] + "   ");
    if (a[i] <= 99 && a[i] >= 10) k = k + 1;

}

Console.WriteLine();
Console.WriteLine("Количество чисел в отрезке "+k);
