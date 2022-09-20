// Задана целочисленная квадратная матрица размером N x N. 
// Требуется транспонировать ее относительно побочной диагонали. 
// Вывод двумерного массива
void RandomArrey(int [,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey[i,j] = new Random().Next(0, 10);
            Console.Write($"{arrey[i,j]} "); 
        }
        Console.WriteLine();
    }
}

void Result(int[,] arrey, int[,] arreyTwo)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arreyTwo[arrey.GetLength(0)-1-j, arrey.GetLength(1)-1-i] = arrey[i, j];
        }
    }
}

void PrintArrey(int [,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            Console.Write($"{arrey[i,j]} "); 
        }
        Console.WriteLine();
    }
}

int n = Convert.ToInt32(Console.ReadLine());
int[,] arrey = new int[n, n];
RandomArrey(arrey);
Console.WriteLine();
int[,] arreyTwo = new int[n, n];
Result(arrey,arreyTwo);
PrintArrey(arreyTwo);