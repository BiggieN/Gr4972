// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементов

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Заполняем массив рандомных числами с заданными параметрами
void filTemp(int[] temp, int massiveSize, int startRand, int finRand)
{
    Random rnd = new Random();
    for (int i = 0; i < massiveSize; i++)
    {
        temp[i] = rnd.Next(startRand, finRand + 1);
    }
}

//Печатаем результат
void PrintResult(int[] temp, int massiveSize)
{
    for (int i = 0; i < massiveSize; i++)
    {
        Console.Write($"{temp[i]} ");
    }
}

int massiveSize = ReadData("Введите длину массива");
int startRand = ReadData("Введите начало диапазона рандома");
int finRand = ReadData("Введите конец диапазона рандома");

int[] rndMassive = new int[massiveSize];

filTemp(rndMassive, massiveSize, startRand, finRand);
PrintResult(rndMassive, massiveSize);