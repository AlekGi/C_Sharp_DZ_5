// Задача 2: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

static void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] ArraySwitch(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        var tmp = array[2, i];
        array[2, i] = array[0, i];
        array[0, i] = tmp;
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

//---------------------------


int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
Console.WriteLine("Наш массив:");
PrintArray(array);
Console.Write("Измененный массив:");
ArraySwitch(array);
