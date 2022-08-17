// 49 Показать двумерный массив размером m×n заполненный вещественными случайными числами
double[,] arr = Create2DArray(3, 4);
PrintArray2D(arr);


void PrintArray2D(double[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0:F3}",a[i,j]);  Console.Write(" ");
        }
        System.Console.WriteLine();
    }
}

double[,] Create2DArray(int n, int m, int min = 0, int max = 100)
{
    double[,] a = new double[n, m];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.NextDouble()*(max-min)+min;
    return a;
}
