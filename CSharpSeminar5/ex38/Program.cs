// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void RandomArrey(double[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = new Random().Next(-10, 11);
    }
}

void Sum(double[] arrey)
{
    int i = 0;
    double min = arrey[i];
    double max = arrey[i];
    double sum = 0;
    for (i = 0; i < arrey.Length; i++)
    {
        if(arrey[i] < min) min = arrey[i];
        if(arrey[i] > max) max = arrey[i];
    }
    Console.WriteLine("Минимальное значение: " + min);
    Console.WriteLine("Максимальное значение: " + max);
    Console.WriteLine("Разница: " + (max-min));
}

double[] myArrey = new double[5];
RandomArrey(myArrey);
Console.WriteLine("[" + string.Join(", ", myArrey)+"]");
Sum(myArrey);

