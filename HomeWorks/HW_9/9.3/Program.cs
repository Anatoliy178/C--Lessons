﻿/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int m,
    n;
Console.Write($"Введите число M: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out n);

int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akk(m - 1, 1);
    }
    else
    {
        return Akk(m - 1, Akk(m, n - 1));
    }
}

Console.WriteLine(Akk(m, n));
