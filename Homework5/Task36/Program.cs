// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.WriteLine("Введите количество элементов массива");
int[] arr = new int[Convert.ToInt32(Console.ReadLine())];

Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-50, 50);
}

Console.WriteLine("Заданный массив: ");
Console.WriteLine(string.Join(", ", arr));

int sum = 0;

for (int i = 1; i < arr.Length; i += 2)
{
    sum = sum + arr[i];
}

Console.WriteLine($"Сумма эл-в на нечетных позициях = {sum}");
