/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или
 сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6                    */

// int a;
// Console.WriteLine("Введите число: ");
// int.TryParse(Console.ReadLine()!, out a);
// int a1 = a % 100 ;
// Console.WriteLine(a1);


int number;
Console.WriteLine("Введите число: ");
int.TryParse(Console.ReadLine()!, out number);

int thirdNumber(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool check(int number)
{
    if (number < 100)
    {
        return false;
    }
    else
        return true;
}

if (check(number) != true)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра числа {number} является {thirdNumber(number)}");
}
