// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();


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
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int max = matrix[i, j];
            int maxK = j;
            int change = 0;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (max < matrix[i, k])
                {
                    max = matrix[i, k];
                    maxK = k;
                }
            }
            if (j != maxK)
            {
                change = matrix[i, j];
                matrix[i, j] = matrix[i, maxK];
                matrix[i, maxK] = change;
            }

        }
    }
}


Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine("Исходный двумерный массив: ");
PrintMatrix(matrix);
ReleaseMatrix(matrix);
Console.WriteLine("Конечный двумерный массив: ");
PrintMatrix(matrix);


