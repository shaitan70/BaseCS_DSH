// 48 Показать двумерный массив размером m×n заполненный целыми случайными числами

int[,] arr = Create2DArray(3, 4);
PrintArray2D(arr);


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

/*void Create2DArray2(int n, int m, out int[,] a)
{
    a = new int[n, m];//создаем массив
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)//перебираем строки
        for (int j = 0; j < a.GetLength(1); j++)//перебираем столбцы
            a[i, j] = random.Next(0, 100);

}
*/