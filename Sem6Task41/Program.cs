// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Вводим данные
string ReadData(string msg)
{
    Console.WriteLine(msg);
    string numbers = Console.ReadLine();
    return numbers;
}

string[] SplitString(string numbers)
{
    string[] splitNumbersStr = numbers.Split(',');
    return splitNumbersStr;
}

void ConvertToInt(string[] splitNumbersStr, int[] numberArray)
{
    for (int i = 0; i < splitNumbersStr.Length; i++)
    {
        numberArray[i] = int.Parse(splitNumbersStr[i]);
    }
}

int CountPositive(int[] numberArray)
{
    int count = 0;
    for (int i = 0; i < numberArray.Length; i++)
    {
        if (numberArray[i] > 0)
        {
            count++;
        }
    }
    return count;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

string numbers = ReadData("Введите числа через запятую");
string[] splitNumbersStr = SplitString(numbers);
int[] numberArray = new int[splitNumbersStr.Length];
ConvertToInt(splitNumbersStr, numberArray);
int count = CountPositive(numberArray);
PrintResult($"Количество чисел больше 0 = {count}");