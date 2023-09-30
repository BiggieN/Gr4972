// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void Sort(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        int temp;
        for (int j = 0; j < mtrx.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < mtrx.GetLength(1); k++)
            {
                if (mtrx[i, j] < mtrx[i, k])
                {
                    temp = mtrx[i, j];
                    mtrx[i, j] = mtrx[i, k];
                    mtrx[i, k] = temp;
                }
            }
        }
    }
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

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArray(row, column, 11, 1);
Print2DArray(arr2D);
Console.WriteLine();
Sort(arr2D);
Print2DArray(arr2D);