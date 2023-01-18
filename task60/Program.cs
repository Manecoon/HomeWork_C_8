// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Array3()
{
    int[,,] array = new int[2, 2, 2];
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                array[k, i, j] = new Random().Next(0, 100);
            }
        }
    }
    return array;
}

int[,,] array = Array3();

void PrintArray3()
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        Console.WriteLine($"По оси к: {k + 1}");
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                Console.Write($"{array[k, i, j]}({k},{i},{j}) ");
            }
            System.Console.WriteLine();
        }
        Console.WriteLine();
    }
}

PrintArray3();