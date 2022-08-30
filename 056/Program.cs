// 56*. Написать программу, которая обменивает элементы первой строки и последней строки

int[,] arr = Create2DArray(3, 5);
int[] copy = new int[arr.GetLength(1)];
PrintArray2D(arr);

for (int i = 0; i < arr.GetLength(1); i++) // КОПИРУЕМ ПЕРВУЮ СТРОКУ
{
    copy[i] = arr[0, i];
}

for (int i = 0; i < copy.Length; i++) // первая строка становиться как последняя
{
    arr[0, i] = arr[arr.GetLength(0) - 1, i];
}



for (int i = 0; i < copy.Length; i++) // последнюю строку меняем на копию первой строки
{
    arr[arr.GetLength(0) - 1, i] = copy[i];
}

Console.WriteLine();
PrintArray2D(arr);


int[,] Create2DArray(int n, int m, int min = 0, int max = 100)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.Next(min, max + 1);
    return a;
}
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


