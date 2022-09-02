﻿// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы
//  каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] FillMatrix(int rowsCount, int columnsCount, int LeftRange = -10, int RightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(LeftRange, RightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(m, n);
Console.WriteLine("Исходный массив:");
PrintMatrix(matrix);

void InsertionSort(int[,] matrix)
{

    int x, i, j, b;

    for (i = 0; i < matrix.GetLength(0); i++)
    {

        for (j = 0; j < matrix.GetLength(1); j++)
        {
            x = matrix[i, j];

            for (b = j - 1; b >= 0 && matrix[i, b] > x; b--) 
            matrix[i, b + 1] = matrix[i, b];

            matrix[i, b + 1] = x;
        }
    }

}

InsertionSort(matrix);
Console.WriteLine("Отсортированный массив:");
PrintMatrix(matrix);