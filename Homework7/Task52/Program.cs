// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillMatrix(int rowsCount, int columnsCount, int LeftRange = 0, int RightRange = 10)
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
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}


void FindArithmeticColumnMatrix(int[,] matrix)
{
    double arif = 0;
    double sum = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        arif = sum / matrix.GetLength(0);
        Console.WriteLine($" Среднеарифметическое столбца {j+1}= {arif:F2}");
        sum = 0;
    }
}


Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
FindArithmeticColumnMatrix(matrix);


