// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void RandomArrey(int[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = new Random().Next(0, 16);
    }
}

int Sum(int[] arrey)
{
    int sum = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if(i % 2 != 0) sum += arrey[i];
    }
    return sum;
}

int[] myArrey = new int[5];
RandomArrey(myArrey);
Console.WriteLine("["+string.Join(", ", myArrey)+"]");
Console.WriteLine("Сумму элементов, стоящих на нечётных позициях: "+ Sum(myArrey));
