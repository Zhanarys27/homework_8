// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}

void TraceArray(int[,] array)
{
    int[] summ = new int[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0 && j == 0)
            {
                summ[i] += array[i, j];
            }
            else if (i == 0 && j > 0)
            {
                summ[i] += array[i, j];
            }
            else if (i > 0 && j == 0)
            {
                summ[i] += array[i, j];
            }
            else if (i > 0 && j > 0)
            {
                summ[i] += array[i, j];
            }
        }
    }
    int index = 0;
    int min = summ[0];
    for (int i = 0; i < summ.Length; i++)
    {

        if(min>summ[i])
        {
            min=summ[i];
            index=i;
        }
        System.Console.Write($"{summ[i]} ");
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"номер строки с наименьшей суммой элементов: {index+1} строка");
}


Console.Clear();
int rows = 4;
int cols = 4;
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
TraceArray(array);

