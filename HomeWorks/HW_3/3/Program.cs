// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

string number;

// int a;
Console.WriteLine($"Введите число для проверки: ");
number = Console.ReadLine()!;

Console.WriteLine($"{number[0]} + {number[1]}");
// int.TryParse(Console.ReadLine()!, out a);

// if (a <= 10000 || a <= 99999)
// {
//     int result = a % 100;
//     Console.WriteLine(result);
// }

// string firstFriend = "Maria";
// string secondFriend = "Sage";
// Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

// Console.WriteLine($"{firstFriend} {firstFriend.Length}");
// Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
