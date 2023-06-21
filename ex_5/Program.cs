// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillArray(int[,] array)
{
    int count = 1;
    int i = 0, j = 0;
    while (count <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = count;
        count++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        {
            j++;
        }
        else if (i < j && i + j >= array.GetLength(0) - 1)
        {
            i++;
        }
        else if (i >= j && i + j > array.GetLength(1) - 1)
        {
            j--;
        }
        else i--;

    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j],3} ");
        }
        System.Console.WriteLine();
    }
}

Console.Clear();
int rows = 4;
int cols = 4;
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);