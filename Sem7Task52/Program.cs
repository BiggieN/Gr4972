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
                        increasingMatrix[i, j] = increasingMatrix[i - 1, m -1] + k;
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

    static void PrintListAvr(double[] list)
    {
        // Введите свое решение ниже
        Console.WriteLine("The averages in columns are: ");
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write($"{list[i].ToString("0.00")}\t");
        }
    }

    static double[] FindAverageInColumns(int[,] matrix)
    {
        // Введите свое решение ниже
        double[] average = new double[matrix.GetLength(1)];
        double temp = 0.00;
        double count = 0.00;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                temp += matrix[i, j];
                count++;
            }
            average[j] = (double)temp / count;
            temp = 0.00;
            count = 0.00;
        }
        return average;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}