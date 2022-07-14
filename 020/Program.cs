// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
int x = -1;
int y = -1;

Console.WriteLine(Chetvert(x,y));




int Chetvert(int x, int y)
{
    bool a = x > 0;
    bool b = y > 0;
    if (a == true && b==true)
    {
        return 1;
    }
    if (a == true && b==false)
    {
        return 4;
    }
    if (a == false && b==true)
    {
        return 2;
    }
    if (a == false && b==false)
    {
        return 3;
    }
    return 0;
}