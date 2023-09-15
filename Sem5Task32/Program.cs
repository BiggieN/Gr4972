using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
        // Введите свое решение ниже
        if (number < 9999)
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }
        else
        {
            int[] temp = new int[5];
            //Инициализируем дополнительные переменные - флаги
            //int i = 1;
            int j = 100;
            int k = 10;
            //int thirdNumber = -2;
            //Раскладываем число на цифры с помощью дополнительных переменных
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
        }
    }
}

// Не удаляйте и не меняйте метод Main! 
static public void Main(string[] args)
{
    int number;

    if (args.Length >= 1)
    {
        number = int.Parse(args[0]);
    }
    else
    {
        // Здесь вы можете поменять значения для отправки кода на Выполнение
        number = 4546;
    }

    // Не удаляйте строки ниже
    bool result = IsPalindrome(number);
    System.Console.WriteLine($"{result}");
}
}