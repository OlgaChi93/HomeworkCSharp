// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число ");
string input = Console.ReadLine()!;
char[] inputarray = input.ToCharArray();
Array.Reverse(inputarray);
string output = new string(inputarray);

if (input == output)
{
    Console.WriteLine($"Число {input} палиндром");
}
else
{
    Console.WriteLine($"Число {input} не является палиндромом");
}

