// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Сколько чисел будите вводить: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrey = new int[m];
int sum = 0;
for (int i = 0; i < arrey.Length; i++)
{
    Console.Write("Введите число: ");
    arrey[i] = Convert.ToInt32(Console.ReadLine());
    if(arrey[i]>0) sum++;
}
Console.WriteLine("[" + string.Join (", ", arrey) + "]");
Console.WriteLine(sum);






