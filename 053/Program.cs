// 53 Написать подпрограмму, поиска элемента в двумерном массиве, подпрограмма возвращает позицию числа.
// Если элемент отсутствует, подпрограмма возвращает -1.
int[,] arr = Create2DArray(3, 4);
arr[2,3]=5;
PrintArray2D(arr);
int i,j;
Console.WriteLine(Find(arr,out i, out j, 5));
System.Console.WriteLine($"i={i} j={j}");


bool Find(int[,] a, out int i, out int j, int number)
{
    for (i = 0; i < a.GetLength(0); i++)
        for ( j = 0; j < a.GetLength(1); j++)
        {
            if ( a[i, j] == number )
            {
                return true;
            }
        }
    j=-1;
    i=-1;    
    return false;
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