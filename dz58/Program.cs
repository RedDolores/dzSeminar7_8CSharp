// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


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

int[,] ProductMatrix(int[,] arrA, int[,] arrB)
{
    int[,] arrC = new int[arrA.GetLength(0), arrB.GetLength(1)];

    for (int i = 0; i < arrC.GetLength(0); i++)
    {
        for (int j = 0; j < arrC.GetLength(1); j++)
        {
            for (int p = 0; p < arrC.GetLength(1); p++)
            {
                arrC[i, j] += arrA[i, p] * arrB[p, j];
            }
        }
    }
    return arrC;
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

int indexAi = ReadInt("Введите количество строк матрицы А: ");
int indexAj = ReadInt("Введите количество столбцов матрицы А: ");
int indexBi = ReadInt("Введите количество строк матрицы В: ");
int indexBj = ReadInt("Введите количество столбцов матрицы В: ");

int[,] massA = GetRandomMatrix(indexAi, indexAj);
int[,] massB = GetRandomMatrix(indexBi, indexBj);
PrintMatrix(massA);
Console.WriteLine();
PrintMatrix(massB);
Console.WriteLine();

if(indexAj != indexBi) Console.WriteLine("Получить произведение данных матриц невозможно");
else
{
    int[,] massC = ProductMatrix(massA, massB);
    PrintMatrix(massC);
}

