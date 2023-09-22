// №34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// *Отсортировать массив методом пузырька

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

// Находим количество четных чисел в массиве
int CountPositive(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            temp++;
        }
    }
    return temp;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

//Сортировка пузырьком
int[] BubbleSort(int[] array)
{
    int len = array.Length;
    for (int i = 1; i < len; i++)
    {
        for (int j = 0; j < len - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    return array;
}

// Вызываем генерацию массива
int[] array = GenArray(20, 100, 1000);
// выводим изначальный массив
PrintResult("Неотсортированный массив");
PrintArray(array);
// Сортируем массив пузырьком
BubbleSort(array);
// Выводим отсортированный массив
PrintResult("Отсортированный массив");
PrintArray(array);
// Подсчитываем и выводим количество четных чисел в массиве
PrintResult($"количество чётных чисел в массиве {CountPositive(array)}");