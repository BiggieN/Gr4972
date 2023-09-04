// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
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