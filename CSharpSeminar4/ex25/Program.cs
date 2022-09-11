// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());

//Походу так нельзя и нужно решить через цикл
//Console.WriteLine($"{a} в степени {b} = {Math.Pow(a,b)}");

int sum = a;
for (int i = 1; i < b; i++)
{
    sum *= a;
    Console.WriteLine(sum);
}
Console.WriteLine(sum);