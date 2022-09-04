// С клавиатуры вводится строка разделенная точкой. 
// Подсчитать количество символов до точки
string s = Console.ReadLine();
int pos = s.IndexOf('.');
System.Console.WriteLine(pos);
