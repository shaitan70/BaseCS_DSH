// Дано число из  диапозона  [10, 99]. Показать наибольшую цифру числа
int a, b1, b2;
string? s;
s = Console.ReadLine();
a = Convert.ToInt32(s);
b1 = a % 10;
b2 = a/10;
if (b1 > b2)
{
    Console.WriteLine(b1);
}
else
{
    Console.WriteLine(b2);
}
