// Найти расстояние между точками в пространстве 2D
/*int x1 = 2;
int y1 = 2;
int x2 = 3;
int y2 = 3;
double s = Math.Sqrt((Math.Abs(x1 - x2)) + Math.Abs(y1 - y2));
Console.WriteLine(s); */
double Distance(double x1, double y1, double x2, double y2)
{
    double d;
    d = Math.Sqrt((Math.Pow(x1 - x2, 2)) + Math.Pow(y1 - y2, 2));
    return d;
}
double x1 = 0, y1=0, x2=4, y2 =3;
Console.WriteLine(Distance(x1,y1,x2,y2));