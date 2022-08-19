// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите количество элементов массива");
int[] arr = new int[Convert.ToInt32(Console.ReadLine())];
int max = 0;
int min = 100;

Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 100);
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
}
Console.WriteLine("Заданный массив:");
Console.WriteLine(string.Join(", ", arr));

Console.WriteLine($"Максимальное число = {max}");
Console.WriteLine($"Минимальное число = {min}");
Console.WriteLine("Разница между максимальным и минимальным числом =" + (max - min));