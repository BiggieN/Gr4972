// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем двумерный массив
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rnd.Next(downBorder, topBorder);
        }
    }
    return array2D;
}

// Проверяем, прямоугольный ли массив
bool SquareCheck(int countRow, int countColumn)
{
    if (countRow == countColumn)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int[] CountLineElementsSumm(int[,] mtrx)
{
    int[] summElements = new int[mtrx.GetLength(0)];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        int summTemp = 0;
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            summTemp += mtrx[i, j];
        }
        summElements[i] = summTemp;
    }
    return summElements;
}

// Печатаем результат
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// Печатаем матрицу сумм
void PrintSummArray(int[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write(matrix[i] + " ");
    }
    Console.WriteLine();
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Находим строку с наименьшей суммой
int SmallestRaw(int[] summArray)
{
    int temp = 0;
    for (int i = 1; i < summArray.Length; i++)
    {
        if (summArray[temp] > summArray[i])
        {
            temp = i;
        }
    }
    return temp;
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
if (SquareCheck(row, column))
{
    int[,] arr2D = Fill2DArray(row, column, 11, 1);
    Print2DArray(arr2D);
    Console.WriteLine();
    PrintSummArray(CountLineElementsSumm(arr2D));
    PrintResult($"Строка, с наименьшей суммой элементов {SmallestRaw(CountLineElementsSumm(arr2D)) + 1}");
}
else
{
    PrintResult("Матрица не прямоугольная");
}
