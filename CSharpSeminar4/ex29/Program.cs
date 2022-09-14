// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
int[] arrey = new int [8];
for (int i = 0; i < arrey.Length; i++)
{
    arrey[i] = new Random().Next(0, 10);
}
Console.WriteLine("[" + string.Join(", ", arrey) + "]");