// 051 Создать подпрограмму Create2DArray(m,n), которая возвращает двумерный массив следующим правилом:
// Aij = i+j, где i и j - индексы элементов массива, а m и n - размеры массива
PrintArray2D(Create2DArray(3,4));

int[,] Create2DArray(int m,int n)
{
    int[,] a = new int[m,n];
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
        {
            a[i,j]=i+j;
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