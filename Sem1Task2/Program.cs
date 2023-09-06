/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*/
Console.WriteLine("Введите первое число");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.Write("max = " + firstNumber);
} 
else
{
    Console.Write("max = " + secondNumber);
}