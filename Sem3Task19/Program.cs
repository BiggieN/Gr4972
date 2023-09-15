// №19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool IsPalindrome(int number)
{
    if (number < 9999 || number > 99999)
    {
        System.Console.WriteLine("Число не пятизначное");
        return false;
    }
    else
    {
        int[] temp = new int[5];
        int j = 100;
        int k = 10;
        temp[0] = number % 10;
        number -= number % 10;
        for (int i = 1; i < 5; i++)
        {
            temp[i] = (number % j) / k;
            number -= (number % j);
            j *= 10;
            k *= 10;
        }
        if (temp[0] == temp[4] && temp[1] == temp[3])
        {
            return true;
        }
        return false;
    }

}

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int num = ReadData("Введите пятизначное число");

//bool check = 
if (IsPalindrome(num))
{
    PrintResult("Да");      
}
else
{
    PrintResult("Нет");   
}