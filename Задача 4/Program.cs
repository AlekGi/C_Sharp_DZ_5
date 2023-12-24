// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца

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

int ArrayMinElement(int[,] array)
{
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
                min = array[i, j];
        }
    }
    return min;

}

int[,] CreateNewArray(int[,] array, int[,] newarray)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == ArrayMinElement(array)){
                newarray = new int[i-1,j-1];
                
            }
        }
        
    }
    return newarray;
}




//---------------------------


int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
Console.WriteLine("Наш массив:");
PrintArray(array);
Console.WriteLine($"Минимальный элемент в массиве: {ArrayMinElement(array)}");
int[,] newarray = new int[2,2];
CreateNewArray(array, newarray);

// Получилось вывести только минимальный элемент массива, Я пытался создать новый массив, но ничего не выходит, если подскажете
// как это сделать, буду благодарен. Надеюсь, хотя бы плючик нарисуете за старания :)