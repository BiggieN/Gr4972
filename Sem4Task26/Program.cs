// Задача №26
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

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

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

long num = ReadData("Введите число: ");
List<long> temp = new List<long>();

fillTemp(temp, num);

PrintResult("Количество цифр: " + temp.Count);
