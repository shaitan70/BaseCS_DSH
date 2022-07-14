//30 Написать программу вычисления произведения чисел от 1 до N

int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(N));


int Sum(int A)
{
    int i = 1;
    int s = 1;
    while (A >= i)
    {
        s = s * i;
        i++;
    };
    return s;
}
