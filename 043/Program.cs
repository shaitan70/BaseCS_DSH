// 43 С клавиатуры вводится число N. Затем вводятся N чисел. 
// Определить сколько чисел больше 0 введено с клавиатуры.

int sum=0;
int N = Convert.ToInt32(Console.ReadLine());
int[] a = new int[N];
a = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
for (int i = 0; i < a.Length; i++)
{
    if (a[i]>0) sum++;
}
Console.WriteLine(sum);


