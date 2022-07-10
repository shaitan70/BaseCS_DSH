// Вывести на экран числа от -N до N
double a, N;
string? s;
s=Console.ReadLine();
N= Convert.ToDouble(s);
a= 0 - N;
while (a<=N)
{
    System.Console.Write($"{a} ");
    a++;
}