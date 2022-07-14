// 29 Подсчитать сумму цифр в числе
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sumchisel(n));



int Sumchisel(int n)
{
    int s = 0;
    while (n > 0)
    {
        s = s + n % 10;
        n /= 10;
    }
    return s;
}