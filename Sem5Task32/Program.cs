//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

//Заполняем одномерный массив
int[] GenArray(int num, int lowBorder, int highBorder){
    
    int[] array = new int[num];
    
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder+1);
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

//Инвертируем массив методом умножения на -1
void InverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        arr[i] *= -1;
    }   
}

// Вызываем генерацию массива, выводим изначальный массив, инвертируем массив и выводим инвертированный массив
int[] array = GenArray(12,-9,9);
PrintArray(array);
InverseArray(array);
PrintArray(array);