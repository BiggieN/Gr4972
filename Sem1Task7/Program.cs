// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());

int thirdNum = number % 10;

Console.WriteLine("Последнее число: " + thirdNum);