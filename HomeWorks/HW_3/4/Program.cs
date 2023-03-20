int a = 454;
int Ab = a;

while (a > 0)
{
    int rev = 0;
    int d = a % 10;
    rev = rev * 10 + d;
    a = a / 10;
    if (rev == Ab)
    {
        Console.WriteLine($"Это число полиндром!");
        break;
    }
    else
    {
        Console.WriteLine($"Это число не полиндром.");
    }
}
Console.WriteLine("Hello, World!");
