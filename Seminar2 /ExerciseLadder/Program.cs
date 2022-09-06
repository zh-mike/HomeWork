// Задача про лестницу
Console.Write("Введите количество ступеней: ");
int n = Convert.ToInt32(Console.ReadLine());
string x = "" ;
if (n <= 9)
{
    for (int i = 1; i <= n; i++)
    {
        x = x+i;
        Console.WriteLine(x);
    }
}