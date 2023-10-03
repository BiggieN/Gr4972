// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

static int Akkerman(int n, int m)
            {
                if (n == 0) return m + 1;
                if (n != 0 && m == 0) return Akkerman(n - 1, 1);
                if (n > 0 && m > 0) return Akkerman(n - 1, Akkerman(n, m - 1));
                return Akkerman(n,m);
            }

// Ввод числа с клавиатуры
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int m = ReadData("Введите положительное m: ");
int n = ReadData("Введите положительное n: ");
Console.WriteLine((m >0 && n > 0) ? Akkerman(n, m) : "n и m должно быть положительными числами");