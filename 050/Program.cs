// 50 В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j])

int[,] arr = Create2DArray(3, 4);
PrintArray2D(arr);

Console.WriteLine();
ZamenaChet(arr);
PrintArray2D(arr);





int[,] ZamenaChet(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i, j] % 2 == 0) { a[i, j] = -a[i, j]; };
        }

    }
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

int[,] Create2DArray(int n, int m, int min = 0, int max = 100)
{
    int[,] a = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.Next(min, max + 1);
    return a;
}
