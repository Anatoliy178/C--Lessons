// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;

const int COEFFECIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(Line2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FineCoords(LINE1, LINE2);
    Console.Write($"Точка пересечения уравнений
    y = {lineData1[COEFFECIENT]} * x + {lineData1[CONSTANT]} и 
    y= {lineData2[COEFFECIENT]} * x + {lineData2[CONSTANT]}");
    Console.Write($"имеет координаты ({coord[X_COORD]}, ({coord [Y_COORD]})) ");    
}

// Ввод числа
double Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert
        
}