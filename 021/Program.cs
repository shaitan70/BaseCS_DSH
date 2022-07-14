// 21 Задать номер четверти, показать диапазоны для возможных координат
int x = 1;
int y = 1;
if (x > 0 && y > 0)
{
 Console.WriteLine ("1 chetvert x  (0;infinity) y  (0;infinity)");
}
if (x > 0 && y < 0)
{
 Console.WriteLine ("4 chetvert x  (0;infinity) y  (-infinity;0)");
}if (x < 0 && y > 0)
{
 Console.WriteLine ("2 chetvert x  (-infinity;0) y  (0;infinity)");
}if (x < 0 && y < 0)
{
 Console.WriteLine ("3 chetvert x  (-infinity;0) y  (-infinity;0)");
}
