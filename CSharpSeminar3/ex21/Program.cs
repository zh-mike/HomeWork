// Задачка про нахождение растояния между точками

Console.Write("Ведите координаты точки A по X : ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите координаты точки A по Y : ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите координаты точки A по Z : ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите координаты точки B по X : ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите координаты точки B по Y : ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите координаты точки B по Z : ");
int z2 = Convert.ToInt32(Console.ReadLine());



Console.WriteLine(Math.Sqrt(Math.Pow(x1 - x2, 2)+ Math.Pow(y1 - y2,2)+ Math.Pow(z1 - z2,2)));

