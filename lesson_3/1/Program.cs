// Вид 1
void Metod1()
{
    Console.WriteLine("Автор ...");
}

// Metod1();


// Вид 2
void Metod2(string msg)
{
    Console.WriteLine(msg);
}

// Metod2(msg: "Текст сообщения");

void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

// Metod21(msg: "Текст 1", count: 4);
// Metod21(count: 5, msg: "Хай");


// Вид 3

int Metod3()
{
    return DateTime.Now.Year;
}

// int year = Metod3();
// Console.WriteLine(year);


// Вид 4

// string Metod4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

string Metod4(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < 10; i++)
    {
        result = result + text;
    }
    return result;
}

// string res = Metod4(10, "absd;");
// Console.WriteLine(res);


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
