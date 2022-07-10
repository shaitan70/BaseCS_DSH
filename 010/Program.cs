// Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
double a, b;
string? s;
s=Console.ReadLine();
a= Convert.ToDouble(s);
b = a%10;
Console.WriteLine(b);