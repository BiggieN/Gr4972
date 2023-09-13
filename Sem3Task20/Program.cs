// Задача №20
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

double length(int xa, int ya, int xb, int yb)
{
    double len = Math.Sqrt(((xb - xa) * (xb - xa)) + ((yb - ya) * (yb - ya)));
    return len;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int xa = ReadData("Введите координату X первой точки: ");
int ya = ReadData("Введите координату Y первой точки: ");
int xb = ReadData("Введите координату X второй точки: ");
int yb = ReadData("Введите координату Y второй точки: ");

double result = Math.Round(length(xa, ya, xb, yb), 3);

PrintResult("Расстояние равно = " + result);