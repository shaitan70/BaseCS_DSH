// 41 В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int N = 3;
double[] a = new double[N];

/*Random random = new Random();
for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(-10, 10);
*/
a[0] = -1.1;
a[1] = 0;
a[2] = 1.1;

double min = a[0];
double max = a[0];

for (int i = 0; i < a.Length; i++)
{
    if (a[i] < min) min = a[i];
    if (a[i] > max) max = a[i];
    Console.Write(a[i] + "   ");

}
double s = max - min;
Console.WriteLine();
Console.WriteLine("Diff " + s);
Console.WriteLine("max " + max);
Console.WriteLine("min " + min);
