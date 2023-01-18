// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int[4, 4];

void Print()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array[i, j]}]   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Helix()
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[0, j] = j + 1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = array.GetLength(0) - 1;
        array[i, j] = (j + 1) + i;
    }

    for (int j = 0; j < array.GetLength(1); j++)
    {
        int k = array.GetLength(1) * 3 - 2;
        array[array.GetLength(1) - 1, j] = k - j;
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int k = array.GetLength(1) * 4 - 3;
        array[i, 0] = k - i;
    }

    for (int j = 1; j < array.GetLength(1) - 1; j++)
    {
        int k = array.GetLength(1) * 4 - 4;
        array[1, j] = k + j;
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int k = array.GetLength(1) * 4 - 3;
        array[i, 0] = k - i;
    }

    for (int j = 1; j < array.GetLength(1) - 1; j++)
    {
        int k = array.GetLength(1) * 5 - 3;
        array[2, j] = k - j;
    }
    return array;
}

Helix();
Print();