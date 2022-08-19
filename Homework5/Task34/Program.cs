// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.WriteLine("Введите количество элементов массива");
int[] arr = new int[Convert.ToInt32(Console.ReadLine())];

Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100, 1000);
}

Console.WriteLine("Заданный массив: ");
Console.WriteLine(string.Join(", ", arr));

int find = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {    
        find = find + 1;
    }
}

Console.WriteLine($"Количество четных чисел в массиве - {find}");
