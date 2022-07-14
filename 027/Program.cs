// Возведите число А в натуральную степень B используя цикл
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int i=1;
int s=1;
while (B>=i)
{
    s=s*A;
    i++;
}
Console.WriteLine(s);
