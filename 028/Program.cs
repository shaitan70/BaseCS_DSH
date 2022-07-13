//Определить количество цифр в числе. Сделать подпрограмму.
int Count(int N)
{
    int k=0;
    while (N !=0)
    {
        k++;
        N/=10;
    }
    return k;
}
Console.WriteLine(Count(14));