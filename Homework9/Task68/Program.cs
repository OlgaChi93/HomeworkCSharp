// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Выполняем вычисление функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
Console.WriteLine("Введите число m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());

if ((m > 0) && (n > 0))
{
    int result = Akkerman(m, n);
    Console.WriteLine($"A(m,n) = {result}");
}
else
{
    Console.WriteLine("Error. Введите неотрицательные числа согласно условиям задачи.");
}


int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}
