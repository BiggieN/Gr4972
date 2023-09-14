// Задача №22 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

//Получаем N
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Выводим массив квадратов
void PrintResult(string msg, int[] squareTable, int N)
{
    Console.Write(msg);
    for (int i = 0; i < N; i++)
    {
        Console.Write(squareTable[i] + " ");
    }
}

//Вычисляем квадрат текущего числа в диапазоне от 1 до N
int square(int number)
{
    number *= number;
    return number;
}

//Заполняем массив квадратов
void FillTable(int[] squareTable, int N)
{
    for (int i = 1; i <= N; i++)
    {
        squareTable[i - 1] = square(i);
    }
}

//Инициализация переменных, вызов функций
int N = ReadData("Введите число N");

int[] squareTable = new int[N];

FillTable(squareTable, N);

PrintResult("Таблица квадратов от 1 до N: ", squareTable, N);
