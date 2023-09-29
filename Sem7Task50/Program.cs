// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет

using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }

    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        // Введите свое решение ниже
        int[,] increasingMatrix = new int[n, m];
        int first = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i == 0 && j == 0)
                {
                    increasingMatrix[i, j] = first;
                }
                else
                {
                    if (j == 0)
                    {
                        increasingMatrix[i, j] = increasingMatrix[i - 1, m - 1] + k;
                    }
                    else
                    {
                        increasingMatrix[i, j] = increasingMatrix[i, j - 1] + k;
                    }
                }
            }
        }
        return increasingMatrix;
    }

    public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
    {
        // Введите свое решение ниже
        int matrixColumn = matrix.GetLength(0);
        int matrixRaw = matrix.GetLength(1);
        int temp;
        if (rowPosition >= matrixRaw || columnPosition >= matrixColumn)
        {
            temp = 1;
        }
        else
        {
            temp = 2;
        }
        int[] tempMatrix = new int[temp];
        if (temp == 1)
        {
            tempMatrix[0] = 0;
        }
        else
        {
            tempMatrix[0] = matrix[columnPosition, rowPosition];
            tempMatrix[1] = 0;
        }
        return tempMatrix;
    }

    public static void PrintCheckIfError(int[] results, int X, int Y)
    {
        // Введите свое решение ниже
        if (results.Length == 1)
        {
            Console.WriteLine("There is no such index");
        }
        else
        {
            Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
        }

    }
}

// Не удаляйте и не меняйте метод Main! 
public static void Main(string[] args)
{
    int n, m, k, x, y;

    if (args.Length >= 5)
    {
        n = int.Parse(args[0]);
        m = int.Parse(args[1]);
        k = int.Parse(args[2]);
        x = int.Parse(args[3]);
        y = int.Parse(args[4]);
    }
    else
    {
        // Здесь вы можете поменять значения для отправки кода на Выполнение
        n = 3;
        m = 4;
        k = 2;
        x = 2;
        y = 3;
    }

    // Не удаляйте строки ниже
    int[,] result = CreateIncreasingMatrix(n, m, k);
    PrintArray(result);
    PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
}
