// Задача 23.
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3-> 1, 8, 27
//5-> 1, 8, 27, 64, 125

int num;
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out num);
Console.WriteLine($"Таблица кубов чисел от 1 до {num} равен");

for (int i = 1; i <= num; i++)
{
    int b = i * i * i;
    Console.Write($"|{b}|");
}
