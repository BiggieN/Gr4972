// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
string number = Console.ReadLine();

char[] digitArray = number.ToCharArray();

if (digitArray.Length < 3)
{
    Console.WriteLine("Число имеет меньше 3 цифр.");
}
else
{
        Console.WriteLine("Третья цифра числа = " + digitArray[2]);
}