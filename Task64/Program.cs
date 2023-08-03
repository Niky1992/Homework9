// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumbersRec(int numberFirst, int numberLast)
{
    if (numberFirst > numberLast) return $"{numberFirst}, " + NumbersRec(numberFirst - 1, numberLast);
    else return Convert.ToString(numberFirst);
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int n = GetInfo("Введите число: ");
int numberOne = 1;
Console.WriteLine($"N = {n} -> {NumbersRec(n, numberOne)}");
