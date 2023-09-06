/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/
Console.WriteLine("Введите первое число");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int thirdNumber = int.Parse(Console.ReadLine());

int max = firstNumber;

if (firstNumber < secondNumber)
{
    max = secondNumber;
}
if (max < thirdNumber)
{
    max = thirdNumber;
}

Console.WriteLine("Максимальное из трех: " + max);
    