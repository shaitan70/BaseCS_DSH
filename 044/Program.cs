// 44 Написать программу преобразования десятичного числа в двоичное
int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[8];

PerevodvDvoichnyu (a);
FlipMassiv(arr);
Print(arr);


void Print(int[] a)
{
    for (int j = 0; j < a.Length; j++)
    {
        Console.Write(a[j]);
    }
}

int[] PerevodvDvoichnyu(int a)
{
    int b = 0;
    int i = 0;
    while (a >= 1)
    {
        b = a % 2;
        a = a / 2;
        arr[i] = b;
        i++;
    }
    return arr;
}

int[] FlipMassiv(int[] a)
{
    int pst = 0;
    int i1 = 0;                //переворот массива
    int j1 = a.Length - 1;
    while (i1 < j1)
    {
        pst = a[i1];
        a[i1] = a[j1];
        a[j1] = pst;
        i1++;
        j1--;
    }
    return a;
}
