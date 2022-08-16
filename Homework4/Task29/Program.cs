// Задача 29: Напишите программу, которая задаёт массив из
//  8 элементов и выводит их на экран. 
// Вводим массив через консоль

int[] a = new int[8];
for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine("Введите {0}-й элемент", i + 1);
    a[i] = Convert.ToInt32(Console.ReadLine());

}

int count = a.Length;
int position = 0;
while (position < count)
{
    Console.Write(a[position] + " ");
    position++;
}
