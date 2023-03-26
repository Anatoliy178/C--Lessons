// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


using System;

Console.WriteLine("Hello, World!");

int ArrayLength(string message)
{
    Console.Write(message); // вывести сообщение
    string read = Console.ReadLine()!; // считываем данные с консоли
    int convert = Convert.ToInt32(read); // конвертируем стоку в число
    return convert;
}

// создание размера массива
int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ArrayLength($"Введите {i + 1}-й элемент");
    }
    return array;
}

// отпечатка массива в консоле
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) //проходим по массиву
    {
        Console.Write($"\narray[{i}] =  {array[i]}"); // и назначаем каждый элемент массива
    }
}

// метод расчёта положительных значений ячеек массива
int CountPozitiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) // проходим по массиву
    {
        if (array[i] > 0)
        {
            count++;
        } // если число в ячейке больше 0, то увеличиваем счётчик
    }
    return count;
}

int length = ArrayLength("Введите размер массива: "); // указывыаем размер массива для создания массива
int[] array; // выделяем память под массив
array = InputArray(length); // создаём массив размером length
PrintArray(array); // печатаем массив в консоль
Console.Write($"\nКолличество ячеек больше 0 - {CountPozitiveNumbers(array)}");
