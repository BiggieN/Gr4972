// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int SumNaturalRec(int m, int n)
{
    if (m <= n)
    {
        return m + SumNaturalRec(m + 1, n);
    }
    return 0;
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
Console.WriteLine((m > n) ? SumNaturalRec(n, m) : SumNaturalRec(m, n));
