#pragma warning disable
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int Promt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Promt("Введите трёхзначное число: ");
if (number < 100 || number > 1000)
{
    Console.WriteLine("Вы ввели не трёхзначное число. Пробуйте ёщё раз!");
    return;
}
Console.WriteLine($"Введённое число: '{number}'");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра: '{secondRank}'");




// int a;
// Console.WriteLine("Введите число");
// int.TryParse(Console.ReadLine()!);

// if (a >= 100)
// {
//     a /= 10;
//     Console.WriteLine(a);
// }
