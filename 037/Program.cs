// 37 Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел
int N = 8;
int[] a = new int[N];
Random random = new Random();
for (int i = 0; i < a.Length; i++)
    a[i] = random.Next(100, 1000);

int chet=0;
int nechet=0;

for (int i = 0; i < a.Length; i++)
{   
    Console.Write(a[i] + "   ");
    if (a[i]%2==0) chet=chet+1;
    else nechet=nechet+1;
}
   
 Console.WriteLine();
 Console.WriteLine("Четных чисел:"+chet);
 Console.WriteLine("Нечетных чисел:"+nechet);
 


