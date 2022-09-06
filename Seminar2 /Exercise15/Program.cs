// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int numDay = Convert.ToInt32(Console.ReadLine());
if (5 < numDay && numDay < 8) Console.WriteLine("Yes");
else Console.WriteLine("No");
