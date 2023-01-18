// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] Array()
{
    int[,] array = new int[new Random().Next(2, 5), new Random().Next(2, 5)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
    }
    return array;
}

void Print(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"[{array1[i, j]}] ");
        }
        Console.WriteLine();
    }

}
int[,] array2 = Array();
int[,] array3 = Array();
int[,] array4 = new int[array2.GetLength(0), array3.GetLength(1)];
if (array2.GetLength(1) == array3.GetLength(0))
{
    for (int i = 0; i < array4.GetLength(0); i++)
    {
        for (int j = 0; j < array4.GetLength(1); j++)
        {
            for (int t = 0; t < array4.GetLength(1); t++)
            {
                array4[i, j] = (array2[i, t] * array3[t, j]) + array4[i, j];
            }

        }
    }
    Print(array2);
    Console.WriteLine("X");
    Print(array3);
    Console.WriteLine("=");
    Print(array4);
}
else Console.WriteLine("Матрицы не согласованы");