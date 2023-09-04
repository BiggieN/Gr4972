// See https://aka.ms/new-console-template for more information
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int c = b * b;

if (c == a)
    {
        Console.WriteLine("Первое число является квадратом второго");
    }
else
    {
        Console.WriteLine("Первое число не является квадратом второго");
    }