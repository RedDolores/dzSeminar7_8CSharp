// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] GetRandomMatrix(int m = 2, int n = 2, int l = 2)
{
    int[,,] arr = new int[m, n, l];
    int rand = new Random().Next(10, 21);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for(int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = rand;
                rand += 1;
            }
        }
    }
    return arr;
}

void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for(int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]} ({i}, {j}, {k}) \t");
            }
        }
        Console.WriteLine();
    }
}

int[,,] array = GetRandomMatrix();
PrintMatrix(array);

