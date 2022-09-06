
Console.Write("Напишите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberA < numberB){
    max = numberB;
}
if (max < numberC){
    max = numberC;
}

Console.WriteLine("Максимальное чисто: "+ max);
