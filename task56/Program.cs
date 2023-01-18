// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] Array()
{
    int[,] array = new int[new Random().Next(2, 6), new Random().Next(2, 6)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
    }
    return array;
}

int[,] array1 = Array();

void Print()
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"[{array1[i, j]}] ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SumArrayString(int i)
{
    int result = 0;
    for (int j = 0; j < array1.GetLength(1); j++)
        result = result + array1[i, j];
    return result;
}

int FindMinSum()
{
    int MinSum = SumArrayString(0);
    for (int k = 0; k < array1.GetLength(0); k++)
    {
        if (MinSum > SumArrayString(k)) MinSum = SumArrayString(k);
    }
    return MinSum;
}

void Itog()
{
    for (int k = 0; k < array1.GetLength(0); k++)
    {
        if (FindMinSum() == SumArrayString(k))
            Console.WriteLine($"Номер строки с наименьшей суммой элементов: {k + 1} строка");
    }
}

Print();
Itog();