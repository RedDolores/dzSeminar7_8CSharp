// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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
            arr[i, j] = new Random().Next(1, 15);
        }
    }
    return arr;
}

void SortingMatrix(int[,] arr)
{
    int[] array = new int[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            array[j] = arr[i, j];
        }

        int tmp = 0;
        int n = array.GetLength(0);
        for (int k = 0; k < n; k++)
        {
            for (int l = n - 1; l > k; l--)
            {
                if (array[k] > array[l])
                {
                    tmp = array[k];
                    array[k] = array[l];
                    array[l] = tmp;
                }
            }
        }

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = array[j];
        }

    }
    

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



int indexi = ReadInt("Введите индекс строки: ");
int indexj = ReadInt("Введите индекс столбца: ");

int[,] newMatrix = GetRandomMatrix(indexi, indexj);

PrintMatrix(newMatrix);
SortingMatrix(newMatrix);
Console.WriteLine();
PrintMatrix(newMatrix);



