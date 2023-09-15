// Задача №21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

double length(int xa, int ya, int za, int xb, int yb, int zb)
{
    double len = Math.Sqrt(((xb - xa) * (xb - xa)) + ((yb - ya) * (yb - ya)) + ((zb - za) * (zb - za)));
    return len;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int xa = ReadData("Введите координату X первой точки: ");
int ya = ReadData("Введите координату Y первой точки: ");
int za = ReadData("Введите координату Z первой точки: ");
int xb = ReadData("Введите координату X второй точки: ");
int yb = ReadData("Введите координату Y второй точки: ");
int zb = ReadData("Введите координату Z второй точки: ");

double result = Math.Round(length(xa, ya, za, xb, yb, zb), 3);

PrintResult("Расстояние равно = " + result);