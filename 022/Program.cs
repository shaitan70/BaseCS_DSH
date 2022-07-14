// 22 Программа проверяет пятизначное число на палиндромом.
string? s=Console.ReadLine();
Console.WriteLine(Palindrome(s));

bool Palindrome(string s)
{
    for (int i = 0; i < s.Length / 2; ++i)
        if (s[i] != s[s.Length - 1 - i]) return false;
    return true;
}
/*
int s =12121;
Console.WriteLine(Palindrome(s));
bool Palindrome(int n)
{
    int a2=n%100/10;
    int a4=n/1000%10;
    if (n/10000==n%10 && a2==a4) return true;
    else return false;

}
*/