// / Задача 67 Программа примает на вход число N и возвращает сумму цифр в числе

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int SumDigitRec(int num)
{
    if (num == 0)
    {
        return 0;
    }
    else
    {
        return num % 10 + SumDigitRec(num / 10);
    }
}

int n = ReadData("Введите число N ");
int sum = SumDigitRec(n);
PrintResult($"Сумма чисел {sum}");

