// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// ​1 4 7 2
// ​5 9 2 3
// ​8 4 2 4
// ​1 7 -> такого числа в массиве нет

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
            arr[i, j] = new Random().Next(-20, 30);
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

void FindElement(int[,] matr, int indi, int indj)
{
    if (indi <= matr.GetLength(0) - 1 && indj <= matr.GetLength(1) - 1 && indi > 0 && indj > 0)
        Console.WriteLine(matr[indi, indj]);
    else Console.WriteLine("Такого элемента не существует");
}


int indexi = ReadInt("Введите индекс строки: ");
int indexj = ReadInt("Введите индекс столбца: ");

int[,] array = GetRandomMatrix(3, 4);
FindElement(array, indexi, indexj);

PrintMatrix(array);