// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine($"Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

if(a > b && a > c) 
{
  Console.WriteLine("Max = " + a);
} 
else if(b > a && b > c) 
{
  Console.WriteLine("Max = " + b);
}
else
{
Console.WriteLine("Max = " + c);
}