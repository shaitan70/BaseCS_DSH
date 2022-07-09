/*int a = 2 , b = 3 , s = a + b  ;
Console.WriteLine(a+"+"+b+"="+s );//склеивание
Console.WriteLine("{0}+{1}={2}",a,b,s);//строка форматирования
Console.WriteLine($"{a}+{b}={s}");//строка интерполяции
*/
//С клавиатуры вводится целое число. Вывести квадрат этого числа 
int a,b;
string? s;
s=Console.ReadLine();
a=Convert.ToInt32(s);
b=a*a;
Console.WriteLine($"{a}^2={b}");
