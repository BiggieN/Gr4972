// Задача №55 Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    // Введите свое решение ниже
    int[,] doubleMatrix = new int[m, n];
    //Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            doubleMatrix[i, j] = new Random().Next(minLimitRandom, maxLimitRandom + 1);
        }
    }
    return doubleMatrix;
}

void PrintArray(int[,] matrix)
{
    // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

bool TestArrRot(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        return true;
    }
    else
    {
        return false;
    }
}

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void Rotate2DArray(int[,] matrix)
{
    int buf = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            buf = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = buf;
        }
    }
}

int n = ReadData("Количество строк: ");
int m = ReadData("Количество столбцов: ");
Console.WriteLine("Исходная матрица");
int[,] array2D = CreateRandomMatrix(n, m, 1, 10);
PrintArray(array2D);
if (TestArrRot(array2D))
{
    Console.WriteLine("________________");
    Rotate2DArray(array2D);
    PrintArray(array2D);
}