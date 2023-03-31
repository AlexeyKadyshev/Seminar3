/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Clear();
Console.WriteLine("Введите значение координаты x1");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение координаты y1");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение координаты z1");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение координаты x2");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение координаты y2");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение координаты z2");
double z2 = double.Parse(Console.ReadLine());
Console.Write(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)));