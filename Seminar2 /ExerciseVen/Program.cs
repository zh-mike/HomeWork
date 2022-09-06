// Задача про вагон
Console.Write("Введите в какой вагон сел Витя: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер вагона: ");
int J = Convert.ToInt32(Console.ReadLine());
if (i == J) Console.WriteLine("Я хз сколько тут вагонов дружище");
else Console.WriteLine(i + J -1);