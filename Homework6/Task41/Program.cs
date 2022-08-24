// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



Console.WriteLine("Введите числа через запятую+пробел");

int[] arr= Console.ReadLine()!.Split(", ").Select(int.Parse).ToArray();
int find = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0) find = find + 1;
}

Console.WriteLine($"Количество чисел > 0 в массиве - {find}");