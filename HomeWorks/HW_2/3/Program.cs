﻿/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет   */


Console.WriteLine($"Введите цифру от 1 до 7");
int day = int.Parse(Console.ReadLine()!);

if (day <= 5)
{
    Console.WriteLine($"Это рабочий день ((");
    return;
}

Console.WriteLine($"Это выходной день!");