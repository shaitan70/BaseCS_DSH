// 46 С клавиатуры вводится число N. Показать первые N чисел Фибоначчи.
// Принять первые числа равными 0 и 1
/*int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
array[0]=0;
array[1]=1;
Console.Write(0+" ");
Console.Write(1+" ");
for (int i =2;i<=N;i++)
{
    array[i]=array[i-2]+array[i-1];
    Console.Write(array[i]+" ");
}
*/
int N = Convert.ToInt32(Console.ReadLine());
for (int i =0;i<=N;i++)
{
  Console.Write(Fibonachi(i)+" ");
}

int Fibonachi(int n)
{
    int result = 0;
    int b = 1;
    int tmp;
 
    for (int i = 0; i < n; i++)
    {
        tmp = result;
        result = b;
        b += tmp;
    }
 
    return result;
}