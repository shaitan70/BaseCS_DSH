// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет.
int a ;
string? s;
s=Console.ReadLine();
a= Convert.ToInt32(s);
if (a<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
    int b = (a/100)%10;
    Console.WriteLine(b);
}