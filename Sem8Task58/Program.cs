// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем двумерный массив
int[,] Fill2DArray(int countRow, int countColumn, int downBorder, int topBorder)
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

// Проверяем на согласованность матриц
bool IfMatchedMatrix(int rowA, int columnB)
{
    if (rowA == columnB)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int[] GetRow(int[,] firstArr2D, int row, int columnA)
{
    int[] tempRow = new int[columnA];
    for (int i = row; i <= row; i++)
    {
        for (int j = 0; j < columnA; j++)
        {
            tempRow[j] = firstArr2D[i, j];
        }    
    }
    return tempRow;
}

int[] GetColumn(int[,] secondArr2D, int column, int rowB)
{
    int[] tempColumn = new int[rowB];
    for (int i = column; i <= column; i++)
    {
        for (int j = 0; j < rowB; j++)
        {
            tempColumn[j] = secondArr2D[j, i];
        }
    }
    return tempColumn;
}

int MultipleElement(int[] tempRow, int[] tempColumn)
{
    int element = 0;
    for (int i = 0; i < tempRow.Length; i++)
    {
        int tempMultiple = 0;
        tempMultiple = tempRow[i] * tempColumn[i];
        element += tempMultiple;
    }
    return element;
}

int[,] MultipleMatrix(int[,] firstArr2D, int[,] secondArr2D, int rowA, int columnA, int rowB, int columnB)
{
    int[,] multipleMatrix = new int[rowA, columnB];
    for (int i = 0; i < rowA; i++)
    {
        for (int j = 0; j < columnB; j++)
        {
            multipleMatrix[i, j] = MultipleElement(GetRow(firstArr2D, i, columnA), GetColumn(secondArr2D, j, rowB));
        }
    }
    return multipleMatrix;
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

int rowA = ReadData("Введите количество строк первой матрицы: ");
int columnA = ReadData("Введите количество столбцов первой матрицы: ");
int rowB = ReadData("Введите количество строк второй матрицы: ");
int columnB = ReadData("Введите количество столбцов второй матрицы: ");
if (IfMatchedMatrix(rowA, columnB))
{
    int[,] firstArr2D = Fill2DArray(rowA, columnA, 1, 11);
    int[,] secondArr2D = Fill2DArray(rowB, columnB, 1, 11);
    Print2DArray(firstArr2D);
    Console.WriteLine();
    Print2DArray(secondArr2D);
    Console.WriteLine();
    Print2DArray(MultipleMatrix(firstArr2D, secondArr2D, rowA, columnA, rowB, columnB));
    //PrintSummArray(CountLineElementsSumm(arr2D));
    //PrintResult($"Строка, с наименьшей суммой элементов {SmallestRaw(CountLineElementsSumm(arr2D)) + 1}");
}
else
{
    PrintResult("Перемножать можно только согласованные матрицы");
}