// Доп задача про узор
// if условие получилось громоздким,
// но я не смог написать по другому, что бы все четыре переменные 
// были одинаковые. Получается только по-парно

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 2);
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

string TestMatrix(int[,] matrix)
{
    string answer = "Yes";
    for (int i = 0; i+1 < matrix.GetLength(0); i++)
    {
        for (int j = 0; j+1 < matrix.GetLength(01); j++)
        {
            if ((
                matrix[0+i, 0+j] == 1 &&
                matrix[0+i, 1+j] == 1 &&
                matrix[1+i, 0+j] == 1 &&
                matrix[1+i, 1+j] == 1 
            ) || (
                matrix[0+i, 0+j] == 0 &&
                matrix[0+i, 1+j] == 0 &&
                matrix[1+i, 0+j] == 0 &&
                matrix[1+i, 1+j] == 0 
            ))
                return answer = "No";
        }
    }
    return answer;
}

int[,] matrix = new int[4, 4];
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine(TestMatrix(matrix));