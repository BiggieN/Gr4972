/*Напишите программу, которая на вход принимает одно число N, а на выходе показывает все целые числа в промежутке от -N до N.*/
Console.WriteLine("Введите натуральное число");
int N = int.Parse(Console.ReadLine());

int invN = N * -1;

if (N > invN)
{
    for (int i = invN; i <= N; i++)
    {
        Console.WriteLine(i);    
    }
} else
{
    for (int i = N; i <= invN; i++)
    {
        Console.WriteLine(i);    
    }    
}
