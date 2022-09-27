// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((new Random().NextDouble() * (10.1 + 10) - 10), 1);
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

double[,] matrix = new double[4, 4];
InputMatrix(matrix);
Console.Write("Введите строку: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int x = Convert.ToInt32(Console.ReadLine());
if (y > matrix.GetLength(0) || x > matrix.GetLength(1) || y < 1 || x < 1)
{
    Console.Write("Такого числа нет");
}
else Console.Write(matrix[y-1, x-1]);