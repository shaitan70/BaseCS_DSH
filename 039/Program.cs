// 39. Найти сумму чисел одномерного массива стоящих на нечетной позиции
int N=5;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
{
    a[i]=random.Next(0,10);
}

int sumNechet =0;
for(int i=1;i<a.Length;i=i+2)
{
    sumNechet+=a[i];
}

for (int i = 0; i < a.Length; i++)
    Console.Write(a[i] + "   ");
Console.WriteLine();
Console.WriteLine($"Сумма нечетных номеров: {sumNechet}");