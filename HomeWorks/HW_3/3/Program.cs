// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


int a;
Console.WriteLine($"Введите число для проверки: ");
int.TryParse(Console.ReadLine()!, out a);
int Ab = a;

poliandrom(a);

void poliandrom(int a)
{
    string msg = "Это число полиндром!";
    string msg1 = "Это число не полиндром.";
    int rev = 0;
    while (a > 0)
    {

        int d = a % 10;
        rev = rev * 10 + d;
        a = a / 10;

    }
    if (rev == Ab)
        {
            Console.WriteLine(msg);

        }
        else
        {
            Console.WriteLine(msg1);
        }
}






