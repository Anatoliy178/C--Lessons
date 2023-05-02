// int a = 5;
// int b = 8;

// Console.Write("a"); // Длинная запись не используется
// Console.Write(" + ");
// Console.Write("b");
// Console.Write(" = ");
// Console.Write(a + b);
// Console.WriteLine();

// Console.Write("a" + "+" + "b" + "=" + a + b);
// Console.WriteLine();

// //так нельзя писать нужно использовать скобки (Смотри ниже)
// Console.Write("a" + "+" + "b" + "=" + (a + b));
// Console.WriteLine();

// // нужно использовать интерполяцию строки
// Console.Write($"{a} + {b} =\n {a + b}");
// Console.WriteLine("++++++++++++++++++++++++++++");

// Напишите программу, которая принимает на вход число и выдаёт его квадрат.
// 6-> 36
// 5-> 25

/*
int num = 0;
Console.WriteLine("Введите число: ");
string text = Console.ReadLine()!;
num = int.Parse(text);
int num2 = num * num;
Console.WriteLine($"{num}^2 = {num2}");
*/

// можно сократить до 3х - 4x строк
/*
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{num}^2 = {num * num}");
++++++++++++++++++++++++++++++++++++++++++++
int num;
Console.WriteLine("Введите число: ");
int.TryParse(Console.ReadLine()!,out num);
Console.WriteLine($"{num}^2 = {num * num}");
*/

//или можно написать так
// string? text = Console.ReadLine(); это не удобно так как нужно будет писать везде где
// num = int.Parse(text!);  string - ? и проверять.

//+++++++++++++++++++++++++++++++++++++++++++++
// можно использовать булево
/*
bool flag = false;
int num;
Console.WriteLine("Введите число: ");
flag = int.TryParse(Console.ReadLine()!, out num);

if (flag == true)
{
    Console.WriteLine($"{num}^2 = {num * num}");
}
else
{
    Console.WriteLine("Введено неверное число");
}
*/

// Сравнить 2 числа
// int a,
//     b;
// Console.WriteLine($"Введите число а:");
// int.TryParse(Console.ReadLine()!, out a);
// Console.WriteLine($"Введите число б: ");
// int.TryParse(Console.ReadLine()!, out b);

// int b2 = b * b;

// if (a == b2) // if (a == b*b)
// {
//     Console.Write($"да");
// }
// else
// {
//     Console.Write($"нет");
// }

// написать программу, которая будет выводить, при вводе номера дня, дни недели
// int a;
// Console.WriteLine($"Введите номер дня недели: ");
// int.TryParse(Console.ReadLine()!, out a);

// if (a < 1 || a > 7)
//     Console.Write($"Введено неверное число!");
// else if (a == 1)
//     Console.Write($"Понедельник");
// else if (a == 2)
//     Console.Write($"Вторник");
// else if (a == 3)
//     Console.Write($"Среда");
// else if (a == 4)
//     Console.Write($"Четверг");
// else if (a == 5)
//     Console.Write($"Пятница");
// else if (a == 6)
//     Console.Write($"Суббота");
// else if (a == 7)
//     Console.Write($"Воскресенье");

// ----------------------------------------
// Пример работы рандома

// string[] name = new string[] { "Vasiliy", "Sergei", "Kolya" };
// string[] surname = new string[] { "Semenov", "Ivanov", "Pegov" };

// int r = new Random().Next(0, 3); // выбор случайного числа из массива от 0 до 3 невключительно
// int rt = new Random().Next(0, 3);

// Console.Write($"{name[r]} {surname[rt]}");

//***********************************************************
// пример работы цикла While
// Написать программу, которая будет принимать на вход цисло и будет вводить все числа от -Т до Т.

// int N;
// Console.WriteLine($"Введите число: ");
// int.TryParse(Console.ReadLine()!, out N);

// int n = -N;

// while (n <= N)
// {
//     Console.Write($"{n}  ");
//     n++;
// }
