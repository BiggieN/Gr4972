// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

void fillMassive(int[] rand)
{
    Random rnd = new Random();
    for (int i = 0; i < 8; i++)
    {
        rand[i] = rnd.Next(0,2);   
    }
}

//Печатаем результат
void PrintResult(int[] rand)
{
    Console.Write("[");
    for (int i = 0; i < 8; i++)
    {
        Console.Write(rand[i]);
        if (i == 7)
        {
            break;
        }  
        Console.Write(","); 
    }
    Console.Write("]");
}

int[] rand = new int[8]; 

fillMassive(rand);

PrintResult(rand);
