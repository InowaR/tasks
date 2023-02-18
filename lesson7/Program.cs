// // Task 47
// double[,] matrix = new double[3,4];
// for(int i = 0; i < matrix.GetLength(0); i++)
// {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().NextDouble() * (100 + 100) - 100;
//         Console.Write($"{matrix[i,j]}\t");
//     }
//     Console.WriteLine();
// }

// // Task 50
// int[,] Matrix()
// {
//     int[,] Matrix = new int[5,4];
//     for(int i = 0; i < Matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < Matrix.GetLength(1); j++)
//         {
//             Matrix[i, j] = new Random().Next(100);
//             Console.Write($"{Matrix[i,j]}\t");
//         }
//         Console.WriteLine();
//     }
//     return Matrix;
// }
// int[,] M = Matrix();
// int RowNumber = 2;
// int ColumnNumber = 3;
// void CheckIndex(int[,] M)
// {
//     Console.WriteLine("Нумерация строк и стобцов начинается с нуля");
//     int RowLength = M.GetLength(0);
//     int ColumnLength = M.GetLength(1);
//     if(RowNumber >= RowLength || ColumnNumber >= ColumnLength)
//     {
//         Console.WriteLine("Такой позиции в массиве нет");
//     }
//     else
//     {
//         Console.WriteLine($"В {RowNumber} ряду, {ColumnNumber} столбце находится элемент {M[RowNumber, ColumnNumber]}");
//     }
// }
// CheckIndex(M);

// // Task 52
// int[,] Matrix()
// {
//     int[,] Matrix = new int[5,4];
//     for(int i = 0; i < Matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < Matrix.GetLength(1); j++)
//         {
//             Matrix[i, j] = new Random().Next(100);
//             Console.Write($"{Matrix[i,j]}\t");
//         }
//         Console.WriteLine();
//     }
//     return Matrix;
// }
// int[,] M = Matrix();
// Console.WriteLine("------------------------------------");
// int Column = 1;
// int Sum = 0;
// for(int i = 0; i < M.GetLength(0); i++)
// {
//     for(int j = Column; j < Column + 1; j++)
//     {
//         Console.Write($"{M[i,j]}\t");
//         Sum += M[i,j];
//     }
//     Console.WriteLine();
// }
// Console.WriteLine($"Сумма элементов столбца {Column} равна {Sum}");

// Extra task transposition

int row = 5;
int column = 4;

int[,] Matrix()
{
    int[,] Matrix = new int[row, column];
    for(int i = 0; i < Matrix.GetLength(0); i++)
    {
        for(int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i, j] = new Random().Next(100);
            Console.Write($"{Matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
    return Matrix;
}
int[,] M = Matrix();
Console.WriteLine("------------------------------------");

int[,] T = new int[column, row];
void GetColumn(int[,] M)
{
    for(int Column = 0; Column < M.GetLength(1); Column++)
    {
        for(int i = 0; i < M.GetLength(0); i++)
        {
            for(int j = Column; j < Column + 1; j++)
            {
                T[j,i] = M[i,j];
            }
        }
    }
}
GetColumn(M);

for(int i = 0; i < T.GetLength(0); i++)
{
    for(int j = 0; j < T.GetLength(1); j++)
    {
        Console.Write($"{T[i,j]}\t");
    }
    Console.WriteLine();
}
