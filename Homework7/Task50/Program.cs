// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, 
//  что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такого числа в массиве нет

int[,] matrix = new int[,]
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4},
};

Console.WriteLine("Введите номер строки элемента:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца элемента:");
int b = Convert.ToInt32(Console.ReadLine());

bool res = false;
int find = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i == a && j == b)
        {
            res = true;
            find = matrix[i, j];
        }
    }
}


if (res == true) Console.Write($"Число с индексом [{a},{b}] = {find}");
else Console.Write($"Числа с индексом [{a},{b}] в массиве нет");
