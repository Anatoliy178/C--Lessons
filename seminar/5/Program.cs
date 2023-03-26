/*
// Задайте массив с 12 случайными значениями в диапозоне [-9, 9]
// Найдите сумму отрицательных и положительных элементов массива

int[] array = new int[12];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 9);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

int sumP = 0;
int sumN = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sumP += array[i];
    }
    else
    {
        sumN += array[i];
    }
}
Console.Write($"Сумма положительных элементов  равна {sumP},\n сумма отрицательных равна {sumN}");
*/

//Напишите программу замены элементов массива на соответствующие отрицательные
//[4, -5, 8, -6] -> [-4,5,-8,6]

int[] array = CreateArray(10, -9, 9);

for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
    Console.Write($"{array[i]}; ");
}

int[] CreateArray(int size, int min = 0, int max = 9)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        Console.Write($"{array[i]}; ");
    }
    Console.WriteLine();
    return array;
}


























/*
int[] array;
array = new int[6];

array[0] = 2;
array[1] = 3;
array[2] = 5;
array[3] = -5;
array[4] = 6;
array[5] = 8;

for (int i = 0; i < array.Length; i++)
{
  Console.Write($"array[{i}] = {array[i]}\n");
}

Resize(ref array, 12);

Console.Write($"\n\n");
for (int i = 0; i < array.Length; i++)
{
  Console.Write($"array[{i}] = {array[i]}\n");
}

// метод переноса данных старого массива и  увеличения его размера на newSize
void Resize(ref int[] array, int newSize)
{
  int[] array2 = new int[newSize];
  for (int i = 0; i < array.Length; i++)
  {
    array2[i] = array[i];
  }
  array = array2;
}
*/

/*
// в данном примере переменная а после применения метода не меняется,
// из за видимости переменной(в консоле выведет 10, 10)
int a = 10;

void Change(int a)
{
  a = 4;
}
Console.Write($"{a}\n");

Change(a);

Console.Write($"{a}\n");
*/

/*
// используем ref для видимости а во всём коде (в консоле выведет 10, 4)
int a = 10;

void Change(ref int a)
{
  a = 4;
}
Console.Write($"{a}\n");

Change(ref a);

Console.Write($"{a}\n");
*/
