// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void RandomArrey(int[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = new Random().Next(100,1000);
    }
}

int Count(int[] arrey)
{
    int count = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if(arrey[i]%2 == 0) count++;
    }
    return count;
}


int[] myArrey = new int[5];
RandomArrey(myArrey);
Console.WriteLine("["+string.Join(", ", myArrey)+"]");
Console.WriteLine("Количетсво четных чисел в массиве: "+ Count(myArrey));