/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные
 числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 */

using System;
using System.Runtime.CompilerServices;

int n;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out n);

Console.Write(AllNaturalNumbers(n));

string AllNaturalNumbers(int n)
{
    int k = n;
    if (k <= 1)
        return $"{n}";
    return $"{k}, {AllNaturalNumbers(k - 1)}";
}
