// Задача 23.
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3-> 1, 8, 27
//5-> 1, 8, 27, 64, 125

Console.WriteLine($"Введите число для вычисления: ");
int number = int.Parse(Console.ReadLine()!);

functionCube(number);

// void PrintCube(int[] array)
// {
//   Console.Write(int[] array);
// }

int functionCube(int number)
{
    int[] array;
    for (int i = 1; i <= number; i++)
    {
        array[i] = i * i * i;
    }
    return array[number];
}
