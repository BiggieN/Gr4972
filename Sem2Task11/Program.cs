// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
void Variant1()
{
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);
    Console.WriteLine(number);

    char[] startNumber = number.ToString().ToCharArray();
    Console.Write(startNumber[0]);
    Console.Write(startNumber[2]);
}

Variant1();
