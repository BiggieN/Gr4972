// Задача №28
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

long countFactorial(int x)
{
    long factorial = 1;
    for (int i = 1; i <= x; i++)
    {
        factorial *= i;   
    }
    return factorial;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int x = ReadData("Введите N:");

long factorial = countFactorial(x);

PrintResult($"Произведение чисел от 1 до N = {factorial}");
