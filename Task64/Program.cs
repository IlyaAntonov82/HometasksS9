// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine();
Console.WriteLine("Данна программа выводит все натуральные числа в промежутке от N до 1.");
Console.WriteLine();

Console.Write("Задайте число N: ");
int userNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.Write("Числа от N до 1: ");
FromNtoOne(userNum);
Console.WriteLine();

void FromNtoOne(int n)
{
    if (n > 1)
    {
        Console.Write($"{n}, ");
        FromNtoOne(n - 1);
    }
    else Console.Write($"{n}");
}
