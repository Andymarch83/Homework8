/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
 Массив размером 2 x 2 x 2
 66(0,0,0) 25(0,1,0)
 34(1,0,0) 41(1,1,0)
 27(0,0,1) 90(0,1,1)
 26(1,0,1) 55(1,1,1)
 */

void FillCub(int[,,] cub)
{
    int count = new Random().Next(1, 99);
    for (int i = 0; i < cub.GetLength(0); i++)
    {
        for (int j = 0; j < cub.GetLength(1); j++)
        {
            for (int k = 0; k < cub.GetLength(2); k++)
            {
                cub[k, i, j] += count;
                count += new Random().Next(1, 9);
            }
        }
    }
}

void PrintIndex(int[,,] cub)
{
    for (int i = 0; i < cub.GetLength(0); i++)
    {
        for (int j = 0; j < cub.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < cub.GetLength(2); k++)
            {
                Console.Write($"{cub[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

int[,,] box = new int[2, 2, 2];
FillCub(box);
PrintIndex(box);