// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine("Введите число 1");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num2 = int.Parse(Console.ReadLine());

//Переменная для проверки, является ли первое число квадратом второго.
bool check1 = false;
//Переменная для проверки, является ли второе число квадратом первого.
bool check2 = false;

//Проверяем на квадрат
if (num2 * num2 == num1)
{
    check1 = true;
}
if (num1 * num1 == num2)
{
    check2 = true;
}

//Проверяем результат проверок на квадрат и выводим результат
if (check1 == true)
{
    Console.WriteLine("Первое число является квадратом второго");   
} else if (check2 == true)
{
    Console.WriteLine("Второе число является квадратом первого");   
} else
{
    Console.WriteLine("Числа не являются квадратами друг друга");
}