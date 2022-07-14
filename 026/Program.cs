//26 Найти сумму чисел от 1 до А
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Sum(A));



int Sum(int A)
{
    int i = 1;
    int sum=0;
    while (A >= i)
    {
        sum=sum+i;
        i++;
    };
    return sum;
}

