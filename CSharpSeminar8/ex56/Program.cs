// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 10);
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ReleaseMatrix(int[,] matrix, int[] arrey)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        arrey[i] = sum;
    }
}
void MaxString(int[] array)
{
    int min = array[0];
    int minI = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minI = i;
        }
    }                                           // Указываю +1 что бы понятнее было пользователю
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minI+1}"); 
}

Console.Clear();
int[,] matrix = new int[4, 4];
InputMatrix(matrix);
Console.WriteLine("Исходный двумерный массив: ");
PrintMatrix(matrix);
int[] array = new int[4];
ReleaseMatrix(matrix, array);
MaxString(array);




