// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine();
Console.WriteLine("Данная программа вычисляет функцию Аккермана.");
Console.WriteLine();

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (M >= 4 && N >= 1)
{
    Console.WriteLine("Число слишком велико. Во избежания переполнения стека программа была принудительно остановлена.");
}
else
{
    if (M < 0 | N < 0)
    {
        Console.WriteLine("Ошибка ввода. Число M или N не может быть отрицательным.");
    }
    else
    {
        if (M > 4 && N >= 0)
        {
            Console.WriteLine("Число слишком велико. Во избежания переполнения стека программа была принудительно остановлена.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"{"Ответ: "}{Ack(M, N)}");

            int Ack(int M, int N)
            {
                if (M == 0) return N + 1;
                else if (N == 0) return Ack(M - 1, 1);
                return Ack(M - 1, Ack(M, N - 1));
            }
        }
    }
}
