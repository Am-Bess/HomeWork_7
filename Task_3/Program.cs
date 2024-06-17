// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int[] nums = new int[InputSizeArray("Введите длинну массива : ")];

    FillArray(nums);

    Console.Write("Было  => ");
    PrintArrayNormal(nums);

    Console.Write("\nCтало => ");
    PrintArrayReverse(nums);
}

int InputSizeArray(string msg)
{
    Console.Write(msg);
    string? inputUser = Console.ReadLine();
    return int.Parse(inputUser!);
}

void FillArray(int[] arr, int index = 0)
{
    Random rnd = new Random();
    if (index == arr.Length) return;

    arr[index] = rnd.Next(1, 100);
    FillArray(arr, index + 1);
}

void PrintArrayNormal(int[] arr, int index = 0)
{
    if (index == arr.Length) return;

    Console.Write($"{arr[index]}\t");
    PrintArrayNormal(arr, index + 1);
}

void PrintArrayReverse(int[] arr, int index = 0)
{
    if (index == arr.Length) return;

    PrintArrayReverse(arr, index + 1);
    Console.Write($"{arr[index]}\t");
}

Main();