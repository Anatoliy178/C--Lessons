﻿/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.WriteLine("Hello, World!");

Random rnd = new Random();

int[,,] CreateMatrix(int row, int col, int dep, int min, int max)
{
    int[,,] matrix = new int[row, col, dep];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                // matrix[i, j, k] = rnd.Next(10, 99);
                matrix[i, j, k] = GetUniqueValue(matrix, min, max, i, j, k);
            }
        }
    }
    return matrix;
}

/// <summary>
/// Отдает уникальное для <paramref name="matrix"/> значение
/// </summary>
/// <param name="matrix">сама матрица</param>
/// <param name="min">минимальное значение для рандомайзера</param>
/// <param name="max">максимальное значение для рандомайзера</param>
/// <param name="i">текущая итерация <paramref name="i"/></param>
/// <param name="j">текущая итерация <paramref name="j"/></param>
/// <param name="k">текущая итерация <paramref name="k"/></param>
/// <returns>Уникальное для <paramref name="matrix"/> значение</returns>
///
int GetUniqueValue(int[,,] matrix, int min, int max, int i, int j, int k)
{
    int value = default;
    bool exist = true;
    while (exist)
    {
        bool _break = false;
        value = rnd.Next(min, max + 1);
        for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
        {
            if (_break)
            {
                break;
            }
            for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
            {
                if (_break)
                {
                    break;
                }
                for (int k1 = 0; k1 < matrix.GetLength(2); k1++)
                {
                    if (matrix[i1, j1, k1] == value)
                    {
                        _break = true;
                        break;
                    }
                    if (i1 == i && j1 == j && k1 == k)
                    {
                        exist = false;
                    }
                }
            }
        }
    }
    return value;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("|");
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k], 1}({i},{j},{k})|");
            }
            Console.WriteLine();
        }
    }
}

int[,,] array3D = CreateMatrix(2, 2, 2, 10, 99);
PrintMatrix(array3D);
