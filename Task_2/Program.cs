//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

void Main()
{
    int m = InputNumber("Введите M ");
    int n = InputNumber("Введите N ");
 
    if (m >= 0 && n >= 0)
        Console.WriteLine($"M = {m}, N = {n} -> A({m},{n}) = {Ackermann(m, n)}");
    else
        Console.WriteLine("Только неотрицательные числа!");
}

int InputNumber(string msg)
{
    Console.Write(msg);
    string? inputUser = Console.ReadLine();
    return int.Parse(inputUser!);
}

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m - 1, 1);
    return Ackermann(m - 1, Ackermann(m, n - 1));
}

Main();