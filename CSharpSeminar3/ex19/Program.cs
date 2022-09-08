// Палидром
Console.Clear();
Console.Write("Введите 5и значное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num /10000 == num %10 && (num / 1000) %10 == (num / 10) % 10) 
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

