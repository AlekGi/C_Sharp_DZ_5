// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using System.Buffers;

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

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int ArrayCheck(int[,] array, int a, int b)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (a > array.GetLength(0) || b > array.GetLength(1))
            {
                Console.WriteLine("такого элемента нет");
                break;
            }
        }
    }
    return array[a, b];
}

//---------------------------


int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
Console.WriteLine("Наш массив:");
PrintArray(array);

int a = ReadInt("Введите координаты строки(координаты начинаются со значения 0): ");
int b = ReadInt("Введите координаты столбца(координаты начинаются со значения 0): ");
System.Console.WriteLine(ArrayCheck(array, a, b));


// Не получается правильно сформиулировать код, вывод сообщения что "Такого числа нет" задваивается и затраивается.

