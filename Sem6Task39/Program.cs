// Задача 39: Напишите программу, которая перевернёт одномерный 
// массив (последний элемент будет на первом месте, а первый - на 
// последнем и т.д.)

// Заполняем одномерный массив
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

// Переворачиваем в новый массив
int[] SwapNewArray(int[] arr)
{
    int[] outArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArray[arr.Length - 1 - i] = arr[i];
    }
    return outArray;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

//Переворачиваем в тот же массив
void SwapArray(int[] arr)
{
    int buferElement = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        buferElement = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = buferElement;
    }
}

// Вызываем генерацию массива
int[] array = GenArray(20, 1, 25);
// выводим изначальный массив
PrintResult("Неотсортированный массив");
PrintArray(array);
int[] swapArray = SwapNewArray(array);
PrintResult("Неотсортированный массив");
PrintArray(array);
PrintResult("Перевернутый массив");
PrintArray(swapArray);
SwapArray(array);
PrintResult("Перевернутый массив 2");
PrintArray(array);
