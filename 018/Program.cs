// По двум заданным числам проверять является ли одно квадратом другого. Используйте подпрограмму.
bool Check (int a, int b)
{
    return a*a==b || b*b==a;
}
int a = 36;
int b =3;
if (Check (a,b))
{
Console.WriteLine("является");
}
else Console.WriteLine("не является");
