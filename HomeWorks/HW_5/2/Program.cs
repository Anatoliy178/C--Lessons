// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//-4, -6, 89, 6]-> 0


int[] array = new int[4];
int count = 0;

ArrayFilling(array);
Console.WriteLine();
Sum(array);

int[] ArrayFilling(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 20);
        Console.Write($"{array[i]}; ");
    }
    return array;
}

int Sum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            count += array[i];
    }
    Console.Write($"\nСумма элементов на нечётных местах равна {count}");
    return count;
}
