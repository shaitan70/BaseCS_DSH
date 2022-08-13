// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] a = new int[0];
Init(out a,5,-100,100);
int s=0;
for (int i = 1; i < a.Length; i=i+2)
{
    s=s+a[i];
}
Print(a);
Console.WriteLine();
Console.WriteLine(s);




void Init(out int[] a,int Length=10,int min=0,int max=100)
{
    a=new int[Length];
    Random random=new Random();//псевдослучайные числа
    for(int i=0;i<a.Length;i++)
            a[i]=random.Next(min,max+1);
}

/*void FindMinMax(int[] a,out int min, out int max)
{
    min=a[0];
    max=a[0];
    for(int i=1;i<a.Length;i++)
    {
        if (a[i]>max) max=a[i];
        if (a[i]<min) min=a[i];
    }
}
*/

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],6} ");
}
