// Задача №42 Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine() ?? ",";
    int number = Convert.ToInt32(value);

    return number;
}
// Переводит число в двоичное
string DecToBin(int num)
{
    string line = "";
    while (num > 0)
    {
        line = num % 2 + line;
        num = num / 2;
    }
    return line;
}


int number = Prompt("Введите число: ");

Console.Write($"Двоичное представление числа: {DecToBin(number)}");
