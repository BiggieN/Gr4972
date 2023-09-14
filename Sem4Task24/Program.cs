//Задача №24
//Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

//1) Вводим число от пользователя
//2) Вычисляем сумму
//3) Выводим результат

int SimpleSum(int numA)
{
    int sumOfNumber = 0;
    for (int i = 0; i <= numA; i++)
    {
        sumOfNumber = sumOfNumber + i;
    }
    return sumOfNumber;
}

int GaussSum(int numA)
{
    int sumOfNumber = 0;
    sumOfNumber = (numA * (numA + 1)) / 2;
    return sumOfNumber;
}

int numberA = ReadData("Введите число А: ");

DateTime d1 = DateTime.Now;
int res1 = SimpleSum(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = GaussSum(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до: " + numberA + " (простой) равна " + res1);
PrintResult("Сумма чисел от 1 до: " + numberA + " (Гауссом) равна " + res2);

