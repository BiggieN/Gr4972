// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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

// Находим произведение пар чисел
int[] ConvertArray(int[] arr)
{
    int[] outArr = new int[arr.Length / 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        outArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return outArr;
}

// Вызываем генерацию массива, выводим изначальный массив, инвертируем массив и выводим инвертированный массив
int[] array = GenArray(10, 0, 10);
PrintArray(array);
int[] outArr = ConvertArray(array);
PrintArray(outArr);
