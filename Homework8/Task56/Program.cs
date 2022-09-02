// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] FillMatrix(int rowsCount, int columnsCount, int LeftRange = 0, int RightRange = 9)
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



void MinSumOfElementsRow(int[,] matrix)
{
    int[] newMatrix = new int[matrix.GetLength(0)];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            newMatrix[i] = sum;
        }


    }
    int min = 100;
    int row = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {


        if (newMatrix[i] < min)
        {
            min = newMatrix[i];
            row = i + 1;
        }

    }
    Console.WriteLine($"Наименьшая сумма {min} в строке {row}");

}


Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
if ((m > n) || (n > m))
{
    int[,] matrix = FillMatrix(m, n);
    Console.WriteLine("Исходный массив:");
    PrintMatrix(matrix);
    MinSumOfElementsRow(matrix);
}
else if (m == n) Console.WriteLine("Error. Введите номера строк для прямоугольного массива");
