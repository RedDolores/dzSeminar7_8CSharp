// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int m, int n)
{
    int[,] arr = new int[m, n];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void FindRows(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        int minSum = sum;
        int mini = i;
        sum = 0;
        for (int k = 1; k < arr.GetLength(0); k++)
        {
            for (int l = 0; l < arr.GetLength(1); l++)
            {
                sum += arr[k, l];
            }
            if (sum < minSum)
            {
                minSum = sum;
                mini = k;
            }
            sum = 0;
        }
        Console.WriteLine($"{minSum}, {mini}");
    }
}


int indexi = ReadInt("Введите индекс строки: ");
int indexj = ReadInt("Введите индекс столбца: ");

int[,] newMatrix = GetRandomMatrix(indexi, indexj);


PrintMatrix(newMatrix);
FindRows(newMatrix);