// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента. Массив размером 2 x 2 x 2
// И снова пример какой то странный. индекм многомерного массива добавляется вперед а не последним числом

void InputMatrix(int[,,] matrix)
{
    int num = 9;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                num++;
                matrix[i, j, k] = num;
            }
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}[{i}, {j}, {k}] \t");

            }
            Console.WriteLine();

        }
    }

}



Console.Clear();
int[,,] matrix = new int[2, 2, 2];
InputMatrix(matrix);

//Если вводить трехмерный массив в ручную:
// int[,,] matrix =
// {
//     {
//         {1, 2},
//         {3, 4}
//     },
//     {
//         {5, 6},
//         {7, 8}
//     },
// };
PrintMatrix(matrix);




