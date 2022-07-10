// По заданному с клавиатуры номеру дня недели вывести его название
string? s;
int a;
s=Console.ReadLine();
a=Convert.ToInt32(s);
if (a==1)
{
    Console.WriteLine("Понедельник");
}
if (a==2)
{
    Console.WriteLine("Вторник");
}
if (a==3)
{
    Console.WriteLine("Среда");
}
if (a==4)
{
    Console.WriteLine("Четверг");
}
if (a==5)
{
    Console.WriteLine("Пятница");
}
if (a==6)
{
    Console.WriteLine("Суббота");
    
}
if (a == 7)
{
    Console.WriteLine("Воскресенье");
    
}

