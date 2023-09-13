// Задача №18
//Напишите программу, которая по заданному номеручетверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//По координатам точки определяем номер четверти
int QuterTest(int quarter)
{
    if (quarter == 1) return (100, 100);
    if (quarter == 2) return (-100, 100);
    if (quarter == 3) return (-100, -100);
    if (quarter == 4) return (100, -100);
    return 0;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}


int quarter = ReadData("Введите четверть: ");

int x, y = QuterTest(quarter);

PrintResult("Диапазон возможных координат точек в этой четверти по оси Х от 0 до " + x + " , по оси Y от 0 до " + y);
