// №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

//Получаем N
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Выводим массив кубов
void PrintResult(string msg, double[] cubeTable, int N)
{
    Console.Write(msg);
    for (int i = 0; i < N; i++)
    {
        Console.Write(cubeTable[i] + " ");
    }
}

//Вычисляем куб текущего числа в диапазоне от 1 до N
double cube(double number)
{
    number = Math.Pow(number, 3);
    return number;
}

//Заполняем массив кубов
void FillTable(double[] cubeTable, int N)
{
    for (int i = 1; i <= N; i++)
    {
        cubeTable[i - 1] = cube(i);
    }
}

//Инициализация переменных, вызов функций
int N = ReadData("Введите число N");

double[] cubeTable = new double[N];

FillTable(cubeTable, N);

PrintResult("Таблица кубов от 1 до N: ", cubeTable, N);
