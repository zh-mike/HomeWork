// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100) 
    Console.WriteLine($"В числе {num} третьей цифры нет");

else
{
    while ( num > 1000)
        num = num / 10;
    Console.WriteLine(num % 10);
}
