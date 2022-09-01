// 55  Дан целочисленный массив. 
//Найти среднее арифметическое каждого из столбцов.
int sum = 0;
int[,] arr = Create2DArray(3, 4);
PrintArray2D(arr);
for (int i = 0; i < arr.GetLength(1); i++)
{
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        sum = sum + arr[j, i];
    }
    int srznach = sum/arr.GetLength(0);
    Console.WriteLine(srznach);
    sum=0;
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
