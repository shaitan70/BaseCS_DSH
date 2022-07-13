// Дано число. Проверить кратно ли оно 7 и 23
/*double a = 23*7;
if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно");
}
*/
double a = 23*7;
bool b=a%7==0 && a%23==0;
Console.WriteLine(b);