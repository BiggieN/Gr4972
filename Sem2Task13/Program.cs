// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// * Сделать вариант для числа длиной до 10 цифр не используя char или string
Console.WriteLine("Введите число");
long number = long.Parse(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Число имеет меньше 3 цифр.");
}
else
{
    //int temp = number / 100;
    long[] temp = {};
    int i = 0;
    do
    {
        temp[i] = number % 10;
        number = number - (number % 10);
        i++;
    } while (number == 0);
    for (int j = 0; j < temp.Length; j++)
    {
        Console.WriteLine(temp[j] + " ");
    }
}