// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// int number;
// Console.WriteLine($"Введите число: ");
// int.TryParse(Console.ReadLine()!, out number);


// for (i = 0, i <= number, i + 2 );
// {
//   if(number % 2 == 0)
//   {
//     Console.Write(i ,", ");
//   }  
// }

int n;
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out n);

for(int i=1;i<=n;i++)
{
if (i % 2 == 0)
{
  System.Console.Write(i + ", ");
}
if (n <= 1)
{
Console.WriteLine($"Слишком маленькое число");
}
}

