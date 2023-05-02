// Задача 38: Задайте массив вещественных чисел.
////// Найдите разницу между максимальным и минимальным элементов массива.

//////[3 7 22 2 78] -> 76



using System.ComponentModel.DataAnnotations;

double[] array = new double[20];
ArrayFilling(array);
MinMax(array);

double[] ArrayFilling(double[] array)
{
    Random random = new();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble() * 100;
        Console.Write($"{array[i]:F2}; ");
    }
    return array;
}

double[] MinMax(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }
    Console.Write(
        $"\nРазность между минимальным\n и максимальным элементом массива равен {max - min:f2}"
    );
    return array;
}
