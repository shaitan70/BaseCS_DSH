// Определить являются ли введенные с клавиатуры символы правильно записью целого числа.
// Вычислить сумму цифр введенного числа

string s = Console.ReadLine();
char[] cc1 = s.ToArray();
int sum=0;

//if (cc1[0] != 0)
//{
    for (int i = 0; i < cc1.GetLength(0); i++)
    {
        if (char.IsNumber(cc1[i]))
        {
            int intVal = (int)Char.GetNumericValue(cc1[i]);
            sum=sum+intVal;
        }
    }
//}
//else { System.Console.WriteLine("no"); }
System.Console.WriteLine(sum);
