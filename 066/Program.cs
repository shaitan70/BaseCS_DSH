// 066 Показать натуральные числа от 1 до N, N задано
int i=1;
int ViewNumber(int N)
{
    if (i < N)
    {
        Console.Write("{0} ", i);
        i++;
        return(ViewNumber(N));
    }
    else return N;
}
Console.WriteLine(ViewNumber(11));