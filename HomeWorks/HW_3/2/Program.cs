// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] pointA = new double[3];
double[] pointB = new double[3];
Console.WriteLine($"Введите первую кординату первой точки: ");
double.TryParse(Console.ReadLine()!, out pointA[0]);
Console.WriteLine($"Введите вторую кординату первой точки: ");
double.TryParse(Console.ReadLine()!, out pointA[1]);
Console.WriteLine($"Введите третью кординату первой точки: ");
double.TryParse(Console.ReadLine()!, out pointA[2]);
Console.WriteLine(pointA);
Console.WriteLine();

Console.WriteLine($"Введите первую кординату второй точки: ");
double.TryParse(Console.ReadLine()!, out pointB[0]);
Console.WriteLine($"Введите вторую кординату второй точки: ");
double.TryParse(Console.ReadLine()!, out pointB[1]);
Console.WriteLine($"Введите третью кординату второй точки: ");
double.TryParse(Console.ReadLine()!, out pointB[2]);
Console.Write(pointB);

// double ditance(double[] pointA, double[] pointB)
// {
//     double dist = Math.Sqrt(
//         Math.Pow(pointB[0] - pointA[0], 2)
//             + Math.Pow(pointB[1] - pointA[1], 2)
//             + Math.Pow(pointB[2] - pointA[2], 2)
//     );
//     return dist;
// }

// double dist = ditance(pointA[3], pointB[3]);
// Console.WriteLine(dist);

double dist = Math.Sqrt(
    Math.Pow(pointB[0] - pointA[0], 2)
        + Math.Pow(pointB[1] - pointA[1], 2)
        + Math.Pow(pointB[2] - pointA[2], 2)
);

double distance = Math.Round(dist, 2);
Console.WriteLine($"Расстояние между точками А и Б = {distance}");
// Console.WriteLine($"Расстояние между точками А и Б = {dist}");
