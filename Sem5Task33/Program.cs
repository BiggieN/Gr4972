// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

//Заполняем одномерный массив
int[] GenArray(int num, int lowBorder, int highBorder)
{

    int[] array = new int[num];

    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder + 1);
    }

    return array;
}

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Печатаем результат
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");

    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Находим заданное число в массиве
int FindElm(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            return i;
        }
    }
    return -1;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int num = ReadData("Введите число, которое нужно найти в массиве");
// Вызываем генерацию массива, выводим изначальный массив, инвертируем массив и выводим инвертированный массив
int[] array = GenArray(12, 0, 10);
PrintArray(array);
int check = FindElm(array, num);
if (check > -1)
{
    PrintResult($"Указанное число присутствует в массиве на позиции {check + 1}");
}
else
{
    PrintResult($"Указанное число отсутствует в массиве");
}