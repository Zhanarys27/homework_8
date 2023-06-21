// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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

void multiplication(int[,] arrayA, int[,] arrayB, int rows, int cols)
{
    int[,] arrayres = new int[rows, cols];
    arrayres[0, 0] = arrayA[0, 0] * arrayB[0, 0] + arrayA[0, 1] * arrayB[1, 0];
    arrayres[0, 1] = arrayA[0, 0] * arrayB[0, 1] + arrayA[0, 1] * arrayB[1, 1];
    arrayres[1, 0] = arrayA[1, 0] * arrayB[0, 0] + arrayA[1, 1] * arrayB[1, 0];
    arrayres[1, 1] = arrayA[1, 0] * arrayB[0, 1] + arrayA[1, 1] * arrayB[1, 1];
    
    for (int i = 0; i < arrayres.GetLength(0); i++)
    {
        for (int j = 0; j < arrayres.GetLength(1); j++)
            Console.Write($"{arrayres[i, j],3}    ");
        System.Console.WriteLine();
    }
}

Console.Clear();
int cols = 2;
int rows = 2;
int[,] arrayA = new int[rows, cols];
int[,] arrayB = new int[rows, cols];
FillArray(arrayA);
FillArray(arrayB);
System.Console.WriteLine("Первая матрица:");
PrintArray(arrayA);
System.Console.WriteLine("Вторая матрица:");
PrintArray(arrayB);
System.Console.WriteLine("Произведение:");
multiplication(arrayA,arrayB,rows,cols);
