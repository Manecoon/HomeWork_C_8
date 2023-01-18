// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

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

int[,] ItogArray(int i)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        int max = j;
        for (int m = j + 1; m < array1.GetLength(1); m++)
        {
            if (array1[i, m] > array1[i, max]) max = m;
        }
        int temp = array1[i, j];
        array1[i, j] = array1[i, max];
        array1[i, max] = temp;
    }
    return array1;
}

void Itog()
{
    for (int k = 0; k < array1.GetLength(0); k++)
        ItogArray(k);
}

Print();
Itog();
Print();