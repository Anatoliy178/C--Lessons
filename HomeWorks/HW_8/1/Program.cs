/* Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

// int m,
//     n;
// Console.Write("Введите размерность m массива: ");
// int.TryParse(Console.ReadLine(), out m);
// Console.Write("Введите размерность n массива: ");
// int.TryParse(Console.ReadLine(), out n);
// int[,] randomArray = new int[m, n];

int[,] array =
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 }
};

// void ArrayFilling(int m, int n)
// {
//     int i,
//         j;
//     Random rand = new Random();
//     for (i = 0; i < m; i++)
//     {
//         for (j = 0; j < n; j++)
//         {
//             randomArray[i, j] = rand.Next(1, 9);
//         }
//     }
// }



void Printmass(int[,] array)
{
    int i,
        j;
    for (i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"| {array[i, j]}");
        }
        Console.WriteLine($"|");
    }
}

// ArrayFilling(m, n);
Console.WriteLine("\n Исходный массив: ");

Printmass(array);

// Printmass(randomArray);

// Сортировка массива по убыванию
void ArraySortDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

ArraySortDescending(array);

// ArraySortDescending(randomArray);
Console.WriteLine("\n Отсортированный массив: ");

Printmass(array);
// Printmass(randomArray);
