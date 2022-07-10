// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, 
// eсли нет, вывести остаток от деления a на b.
double a , b;
string? s;
s=Console.ReadLine();
a= Convert.ToDouble(s);
s=Console.ReadLine();
b= Convert.ToDouble(s);
if (a%b ==0)
{
    Console.WriteLine("а кратно b");
}
else 
{
    Console.WriteLine(a%b);
}