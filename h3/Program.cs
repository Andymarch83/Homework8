/* Задача 58: Задайте две матрицы. Напишите программу, 
 которая будет находить произведение двух матриц.
 Например, даны 2 матрицы:
 2 4 | 3 4
 3 2 | 3 3
 Результирующая матрица будет:
 18 20
 15 18
 */

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrixRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] tab = new int[rows, columns];
int[,] secondTab = new int[rows, columns];
int[,] resultTab = new int[rows, columns];

FillMatrixRandom(tab);
PrintMatrix(tab);

Console.WriteLine();

FillMatrixRandom(secondTab);
PrintMatrix(secondTab);

Console.WriteLine();

if (tab.GetLength(0) != secondTab.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < tab.GetLength(0); i++)
{
    for (int j = 0; j < secondTab.GetLength(1); j++)
    {
        resultTab[i, j] = 0;
        for (int k = 0; k < tab.GetLength(1); k++)
        {
            resultTab[i, j] += tab[i, k] * secondTab[k, j];
        }
    }
}

PrintMatrix(resultTab);
