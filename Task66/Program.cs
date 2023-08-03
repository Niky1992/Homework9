// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumNumbersInterval (int m, int n)
{
    if (m <= n) return m + SumNumbersInterval(m + 1, n);
    else return 0;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInfo("Введите первое число: ");
int n = GetInfo("Введите второе число: ");
Console.Write($"M = {m}; N = {n} -> {SumNumbersInterval (m, n)}");
