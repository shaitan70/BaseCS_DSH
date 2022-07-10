// Удалить вторую цифру целого числа введенного с клавиатуры.1234  123 - 3 = 120 + b1 124
int a, b1 ;
string? s;
s = Console.ReadLine();
a = Convert.ToInt32(s);
b1 = a % 10;
a= a /100;
Console.Write(a);
Console.Write(b1);