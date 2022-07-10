// Выяснить является ли число чётным.
double a, b;
string? s;
s=Console.ReadLine();
a= Convert.ToDouble(s);
b = a%2;
if (b==1)
{
    Console.WriteLine("Нечетное число");
}
else 
{
    Console.WriteLine("Четное число");
}