/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int n,
    m;
int sum = 0;
Console.WriteLine($"Введите число M: ");
int.TryParse(Console.ReadLine()!, out m);
Console.WriteLine($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out n);

if (m < n)
{
    for (int i = m; i <= n; i++)
    {
        sum = sum + i;
    }
}
Console.Write($"Сумма чисел от {m} до {n} = {sum}");
