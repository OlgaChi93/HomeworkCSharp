// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите число A ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
if (B > 0)
{
    for (int i = 1; i <= B; i++)
    {
        result = A * result;
    }
    Console.Write($" Число {A} в степени {B} равняется {result}");
}
else
{
    Console.Write($" Error. Введено некорректное число (число В должно быть больше 0");
}