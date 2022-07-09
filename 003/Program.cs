// С клавиатуры вводятся два числа a и b. Найти максимальное из них.
double a , b;
string? s;
s=Console.ReadLine();
a= Convert.ToDouble(s);
s=Console.ReadLine();
b= Convert.ToDouble(s);
if (a>b)
{
    Console.WriteLine(a);
}
else 
{
    Console.WriteLine(b);
}