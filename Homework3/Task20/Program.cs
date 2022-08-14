// Задача 20
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А и точки B");
int[] arr= Console.ReadLine().Split().Select(int.Parse).ToArray();
 
int xa = arr[0];
int ya = arr[1];
int za = arr[2];
int xb = arr[3];
int yb = arr[4];
int zb = arr[5];


double ab = Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2)+ Math.Pow(zb-za, 2));
Console.WriteLine($"Расстояние между точками равно {ab:f2}");