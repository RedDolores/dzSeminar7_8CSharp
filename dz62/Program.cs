// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7



int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Spiral(int[,] matrix) 
{ 
    int tmpi = 0, tmpj = 0, num = 1, countRight = 0, countLeft = 0, countUp = 0, countDown = 0,   
        end = 0; 
 
    while (end <= matrix.GetLength(0) + matrix.GetLength(1) - 1) 
    { 
        for (int j = 0 + countRight; j < matrix.GetLength(0) - countRight; j++)                      
        { 
            matrix[tmpi, j] = num; 
            num++; 
            tmpj = j; 
        } 
        countUp++; end++; 
 
        if (end <= matrix.GetLength(0) + matrix.GetLength(1) - 1)                                   
        { 
            for (int i = tmpi + 1; i < matrix.GetLength(0) - countDown; i++)                         
            { 
                matrix[i, tmpj] = num; 
                num++; 
                tmpi = i; 
 
            } 
            countRight++; end++; 
        } 
        else return; 
         
        for (int j = tmpj - 1; j > -1 + countLeft; j--)                                             
        { 
            matrix[tmpi, j] = num; 
            num++; 
            tmpj = j; 
        } 
            countDown++; end++; 
         
        if (end <= matrix.GetLength(0) + matrix.GetLength(1) - 1)                                   
        { 
            for (int i = tmpi - 1; i > -1 + countUp; i--)                                          
            { 
                matrix[i, tmpj] = num; 
                num++; 
                tmpi = i; 
            } 
            countLeft++; end++; 
        } 
        else return; 
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

int n = ReadInt("Введите размер матрицы: ");
int[,] hellSnail = new int[n, n];

Spiral(hellSnail);
PrintMatrix(hellSnail);