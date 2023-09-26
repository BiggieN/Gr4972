// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// *Найдите все пары в массиве и выведите пользователю

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

// Находим сумму элементов, стоящих на нечётных позициях
int SummUnevenPosition(int[] arr)
{
    int temp = 0;
    for (int i = 1; i < arr.Length;)
    {
        temp += arr[i];
        i += 2;
    }
    return temp;
}

// Находим пары чисел
void ConvertArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int temp = arr[i];
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] == temp)
            {
                Console.WriteLine($"Пара [{arr[i]}, {arr[j]}] на позиции [{i}, {j}]");
            }
        }
    }
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Вызываем генерацию массива
int[] array = GenArray(20, 0, 20);
// выводим изначальный массив
PrintResult("Неотсортированный массив");
PrintArray(array);
// Считаем сумму значений нечетных индексов
int summa = SummUnevenPosition(array);
// Выводим сумму
PrintResult($"Сумма: {summa}");
// Находим пары чисел
ConvertArray(array);