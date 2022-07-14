// 22 Программа проверяет пятизначное число на палиндромом.
string? s=Console.ReadLine();
Console.WriteLine(Palindrome(s));

bool Palindrome(string s)
{
    for (int i = 0; i < s.Length / 2; ++i)
        if (s[i] != s[s.Length - 1 - i]) return false;
    return true;
}
