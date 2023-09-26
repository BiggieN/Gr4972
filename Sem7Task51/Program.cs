// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д

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

int MainDiagSum(int[,] mtrx)
{
    int res = 0;
    int min = mtrx.GetLength(0);
    if (min > mtrx.GetLength(1))
    {
        min = mtrx.GetLength(1);
    }
    for (int i = 0; i < min; i++)
    {
        res += mtrx[i,i];
    }
    return res;
}

// Печатаем результат
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");  
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
int res = MainDiagSum(arr2D);
PrintResult($"{res}");
