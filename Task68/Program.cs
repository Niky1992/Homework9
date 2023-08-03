// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}

int GetInfo(string message)
{
    int result = 0;
    bool validInput = false;
    while (!validInput)
    {
        Console.Write(message);
        validInput = int.TryParse(Console.ReadLine(), out result);
        if (!validInput || result < 0)
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите неотрицательное целое число.");
            validInput = false;
        }
    }

    return result;
}

int m = GetInfo("Введите неотрицательное число m: ");
int n = GetInfo("Введите неотрицательное число n: ");
int result = AckermannFunction(m, n);
Console.WriteLine($"m = {m}, n = {n} -> A({m}, {n}) = {result}");
