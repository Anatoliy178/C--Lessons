﻿//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] array = new int[4];
int count = 0;

int[] ArrayFilling(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]}; ");
    }
    return array;
}

int Pozitiv(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count += 1;
    }
    return count;
}

ArrayFilling(array);
Pozitiv(array);
Console.WriteLine($"В массиве {count} чётных элементов");
