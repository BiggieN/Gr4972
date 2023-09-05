Console.WriteLine("Введите первое число");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.Write("max = ");
    Console.WriteLine(firstNumber);
} 
else
{
    Console.Write("max = ");
    Console.Write(secondNumber);
}