// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//* Сделать вариант для числа длиной до 10 цифр не используя char или string
Console.WriteLine("Введите число");
long number = long.Parse(Console.ReadLine());

//Проверяем, чтобы было 3 и больше цифры в числе
if (number < 100)
{
    Console.WriteLine("Число имеет меньше 3 цифр.");
}
else
{
    //Инициализируем массив чисел
    long[] temp = new long[10];
    //Инициализируем дополнительные переменные - флаги
    int i = 1;
    long j = 100;
    long k = 10;
    int thirdNumber = -2;
    //Раскладываем число на цифры с помощью дополнительных переменных
    temp[0] = number % 10;
    number -= number % 10;
    do
    {
        temp[i] = (number % j) / k;
        number -= (number % j);
        i++;
        j *= 10;
        k *= 10;
        thirdNumber++;
    } while (!(number == 0));

    Console.WriteLine("Третья цифра: " + temp[thirdNumber]);
}