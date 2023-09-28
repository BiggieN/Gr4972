// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//Вводим данные
double ReadData(string msg)
{
    Console.WriteLine(msg);
    double num = double.Parse(Console.ReadLine());
    return num;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

bool ParallelCheck(double k1, double k2)
{
    bool parallel = false;
    if (k1 == k2)
    {
        parallel = true;
    }
    return parallel;
}

double FindX(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    return x;
}

double FindY(double k1, double x, double b1)
{
    double y = k1 * x + b1;
    return y;
}

double b1 = ReadData("Введите b1");
double k1 = ReadData("Введите k1");
double b2 = ReadData("Введите b2");
double k2 = ReadData("Введите k2");

if (ParallelCheck(k1, k2) == true)
{
    PrintResult("Прямые параллельны!");
    return;
}

double x = FindX(b1, k1, b2, k2);
double y = FindY(k1, x, b1);

PrintResult($"Точка пересечения двух прямых [{x}, {y}]");