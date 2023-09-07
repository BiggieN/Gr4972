// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число некратно первому, то программа выводит остаток от деления.
Console.WriteLine("Введите первое число");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = int.Parse(Console.ReadLine());

if (secondNumber % firstNumber == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else 
{
    Console.WriteLine("Второе число не кратно первому");
    Console.WriteLine("Остаток от деления: " + (secondNumber % firstNumber));
}