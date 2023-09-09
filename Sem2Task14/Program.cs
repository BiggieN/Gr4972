// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

//Проверяем, являетя ли число одновременно кратным 7 и 23.
if ((number % 7 == 0) && (number % 23 == 0))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
