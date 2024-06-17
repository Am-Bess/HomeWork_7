// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int m = InputNumber("Введите M ");
    int n = InputNumber("Введите N ");

    if (m > n)
        PrintNaturalNumber(n, m);
    else
        PrintNaturalNumber(m, n);
}

void PrintNaturalNumber(int m, int n)
{
    if (m > n - 1)
    {
        Console.Write(m);
        return;
    }

    Console.Write($"{m}, ");
    PrintNaturalNumber(m + 1, n);
}

int InputNumber(string msg)
{
    Console.Write(msg);
    string? inputUser = Console.ReadLine();
    return Math.Abs(int.Parse(inputUser!));
}

Main();