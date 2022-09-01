// 067 Показать натуральные числа от N до 1, N задано
int ViewNumber(int N)
{
    if(N>1)
    {
        Console.WriteLine(N+" ");
        return ViewNumber(N-1);
    }
    else return 1;
}

Console.WriteLine(ViewNumber(10));