// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// Заполняем одномерный массив вещественных чисел
double[] GenArray(int num, int coefficient)
{

    double[] array = new double[num];

    for (int i = 0; i < num; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * coefficient, 2);
    }
    return array;
}

// Печатаем результат
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");

    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Находим разницу между максимальным и минимальным элементов массива
double MaxMinDiff(double[] arr)
{
    double min = 0;
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    double diff = max - min;
    return diff;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Вызываем генерацию массива
double[] array = GenArray(20, 20);
// выводим изначальный массив
PrintResult("Неотсортированный массив");
PrintArray(array);
// Находим разницу между максимальным и минимальным элементов массива
double diff = MaxMinDiff(array);
// Выводим разницу
PrintResult($"Разница: {diff}");

