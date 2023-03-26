// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


using System;

int Promt(string message)
{
  Console.Write(message);
  string inputRead = Console.ReadLine()!;
  int result = int.Parse(inputRead);
  return result;
}

Int64 PowerBase(int powerBase, int exponent)
{
  int power = 1;
  for (int i = 0; i < exponent; i++)
  {
    power *= powerBase;    
  }
  return power;
}

bool Validator(int exponent)
{
  if (exponent < 0)
  {
    Console.WriteLine($"степень не может быть меньше 0!");
    return false;
  }
  return true;
}


int powerBase = Promt($"Введите число: ");
int exponent = Promt($"Введите степень: ");
if(Validator(exponent))
{
  Console.WriteLine($"Число {powerBase}  в степение {exponent}  равно {PowerBase(powerBase, exponent)}");
}
