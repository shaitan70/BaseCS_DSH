// 25 Вывести на экран кубы чисел от 1 до N
int N=Convert.ToInt32(Console.ReadLine());
int i=1;
while (N>=i)
{
 Console.WriteLine(Math.Pow(i,3));
 i++;
};