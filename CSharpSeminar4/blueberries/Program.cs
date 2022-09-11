// Доп. задача про чернику
// Не разобрался как ввести в массив строку если пользователь вводит "1 2 3 4"
// По очереди цифры могу ввести в массив, это через тот же цикл что и с рандомом делается,
// а вот с одной строки не смог по-этому сделал с рандомными числами

Console.Clear();
Console.Write("Солько кустов: ");
int coin = Convert.ToInt32(Console.ReadLine());
int[] arrey = new int [coin];
for (int i = 0; i < arrey.Length; i++)
{
    arrey[i] = new Random().Next(0, 10);
}
Console.WriteLine("[" + string.Join(", ", arrey) + "]");


int sum = 0;
int j = 1;
int max = arrey[j-1]+ arrey[j]+arrey[j+1];

for (j = 2; j < arrey.Length-1; j++)
{
    sum = arrey[j-1]+ arrey[j]+arrey[j+1];
    if (max < sum) max = sum;
}

Console.WriteLine(max);




