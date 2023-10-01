// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем двумерный массив
int[,,] Fill3DArray(int x, int y, int z, int downBorder, int topBorder)
{
    System.Random rnd = new System.Random();
    int[,,] array3D = new int[z, y, z];

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                int temp = rnd.Next(10, 100);

                while (RepeatedElement(array3D, temp))
                {
                    temp = rnd.Next(10, 100);
                }

                array3D[i, j, k] = temp;
            }
        }
    }
    return array3D;
}

bool RepeatedElement(int[,,] array3D, int temp)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                if (temp == array3D[i, j, k])
                {
                    return true;
                }
            }
        }
    }
    return false;
}

// Печатаем результат
void Print3DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}] {matrix[i, j, k]}\t");
            }
            Console.WriteLine();
        }
    }
}

int x = ReadData("Введите первую размерность матрицы: ");
int y = ReadData("Введите вторую размерность матрицы: ");
int z = ReadData("Введите третью размерность матрицы: ");
int[,,] array3D = Fill3DArray(x, y, z, 10, 100);
Print3DArray(array3D);