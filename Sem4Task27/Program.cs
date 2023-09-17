// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// * Сделать оценку времени алгоритма через вещественные числа и строки

//Вводим данные, второй вариант
string ReadData2(string msg)
{
    Console.WriteLine(msg);
    string strNumber = Console.ReadLine();
    return strNumber;
}

//Вводим данные
long ReadData(string msg)
{
    Console.WriteLine(msg);
    long number = long.Parse(Console.ReadLine() ?? "0");
    return number;
}

void fillTemp(List<long> list, long number)
{
    //Инициализируем дополнительные переменные - флаги
    long j = 100;
    long k = 10;
    //Раскладываем число на цифры с помощью дополнительных переменных
    list.Add(number % 10);
    number -= number % 10;
    do
    {
        list.Add((number % j) / k);
        number -= (number % j);
        j *= 10;
        k *= 10;
    } while (!(number == 0));
}

//Сумма цифр, первый вариант
long summNumbers(List<long> list)
{
    long result = list.ToArray().Sum();
    return result;
}

//Сумма цифр, второй вариант
int summNumbers2(char[] num2)
{
    int result = 0;
    for (int i = 0; i < num2.Length; i++)
    {
        result += (num2[i] + '0');
    }
    return result;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

//Первый вариант основного блока программы с проверкой производительности
long num = ReadData("Введите число: ");
DateTime d1 = DateTime.Now;
List<long> temp = new List<long>();
fillTemp(temp, num);
long summ = summNumbers(temp);
PrintResult("Сумма цифр: " + summ);
Console.WriteLine(DateTime.Now - d1);

//Второй вариант основного блока программы с проверкой производительности
char[] num2 = ReadData2("Введите число: ").ToCharArray();
DateTime d2 = DateTime.Now;
int summ2 = summNumbers2(num2);
PrintResult("Сумма цифр: " + summ2);
Console.WriteLine(DateTime.Now - d2);