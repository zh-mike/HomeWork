// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Сделал как объясняли на семинаре. Примеры какие то кривые

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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ReleaseMatrix(int[,] matrix1, int[,] matrix2, int[,] matrixResult)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrixResult[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
}

Console.Clear();
int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
int[,] matrixResult = new int[2, 2];
InputMatrix(matrix1);
InputMatrix(matrix2);
Console.WriteLine("Исходный двумерный массив: ");
PrintMatrix(matrix1);
PrintMatrix(matrix2);

ReleaseMatrix(matrix1, matrix2, matrixResult);
Console.WriteLine("Конечный двумерный массив: ");
PrintMatrix(matrixResult);


