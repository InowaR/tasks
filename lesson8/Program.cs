// // Task 54
// int row = 4;
// int column = 10;
// int[,] Matrix = new int[row, column];

// for(int i = 0; i < Matrix.GetLength(0); i++)
// {
//     for(int j = 0; j < Matrix.GetLength(1); j++)
//     {
//         Matrix[i, j] = new Random().Next(1,100);
//         Console.Write($"{Matrix[i,j]}\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("----------------------------------------------------------------------------");

//  void BubbleSort(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         for (int j = 0; j < array.Length - 1; j++)
//             if (array[j] < array[j + 1])
//             {
//                 int t = array[j + 1];
//                 array[j + 1] = array[j];
//                 array[j] = t;
//             }
// }

// for(int i = 0; i < Matrix.GetLength(0); i++)
// {
//     int[] array = new int[column];
//     for(int j = 0; j < Matrix.GetLength(1); j++)
//     {
//         array[j] = Matrix[i,j];
//     }
//     BubbleSort(array);
//     foreach(int element in array){Console.Write($"{element}\t");}
//     Console.WriteLine();
// }



// // Task 56
// int row = 4;
// int column = 4;
// int[,] Matrix = new int[row, column];

// for(int i = 0; i < Matrix.GetLength(0); i++)
// {
//     for(int j = 0; j < Matrix.GetLength(1); j++)
//     {
//         Matrix[i, j] = new Random().Next(1,100);
//         Console.Write($"{Matrix[i,j]}\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("--------------------------------------------");

// int[] SumArray = new int[row];
// for(int i = 0; i < Matrix.GetLength(0); i++)
// {
//     int[] array = new int[column];
//     for(int j = 0; j < Matrix.GetLength(1); j++)
//     {
//         array[j] = Matrix[i,j];
//     }
//     int sum = 0;
//     foreach(int element in array){sum += element;}
//     SumArray[i] = sum;
//     Console.WriteLine($"Сумма элементов строки {i} = {sum}");
// }
// Console.WriteLine("--------------------------------------------");
// int minVal = SumArray.Min();
// int indexMin = Array.IndexOf(SumArray, minVal);
// Console.WriteLine($"Строка с минимальной суммой имеет индекс {indexMin}");
// for(int count = 0; count < Matrix.GetLength(1); count++)
// {
//     Console.Write($"{Matrix[indexMin,count]}\t");
// }
// Console.WriteLine();



// // Task 58
// int[,] Matrix(int Row, int Column)
// {
//     int[,] Matrix = new int[Row, Column];
//     int num = 1;
//     for(int i = 0; i < Matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < Matrix.GetLength(1); j++)
//         {
//             Matrix[i, j] = num;
//             Console.Write($"{Matrix[i,j]}\t");
//             num++;
//         }
//         Console.WriteLine();
//     }
//     return  Matrix;
// }
// int[,] First =  Matrix(4,4);  // 1 квадратная матрица
// Console.WriteLine("--------------------------------------------");
// int[,] Second =  Matrix(4,4); // 2 квадратная матрица
// Console.WriteLine("--------------------------------------------");

// int OneElementAfterRowMultColumn(int IndexRow, int IndexColumn)
// {
//     List<int> Row = new List<int>();
//     for(int i = IndexRow; i < IndexRow + 1; i++)
//     {
//         for(int j = 0; j < First.GetLength(1); j++)
//             {
//                 Row.Add(First[i,j]);
//             }
//     }
//     List<int> Column = new List<int>();
//     for(int i = 0; i < Second.GetLength(0); i++)
//     {
//         for(int j = IndexColumn; j < IndexColumn + 1; j++)
//             {
//                 Column.Add(First[i,j]);
//             }
//     }
//     List<int> MultiplicateElements = new List<int>();
//     for(int count = 0; count < First.GetLength(1); count++)
//     {
//         MultiplicateElements.Add(Row[count] * Column[count]);
//     }
//     int sum = 0;
//     for(int count = 0; count < First.GetLength(1); count++)
//     {
//         sum += MultiplicateElements[count];
//     }
//     return sum;
// }
// void NewMatrix(int[,] First, int[,] Second)
// {
//     int[,] Mult = new int[First.GetLength(1), First.GetLength(1)];
//     for(int i = 0; i < Mult.GetLength(0); i++)
//     {
//         for(int j = 0; j < Mult.GetLength(0); j++)
//         {
//             Mult[i,j] = OneElementAfterRowMultColumn(i,j);
//         }
//     }
//     for(int i = 0; i < Mult.GetLength(0); i++)
//         {
//             for(int j = 0; j < Mult.GetLength(1); j++)
//             {
//                 Console.Write($"{Mult[i,j]}\t");
//             }
//             Console.WriteLine();
//         }
// }
// NewMatrix(First,Second); // умножение 2 квадратных матриц


// // Task 60
// int count = 0;
// List<int> randomList = new List<int>();
// while(count < 27)
// {
//     int MyNumber = new Random().Next(10, 99);
//     if (!randomList.Contains(MyNumber)){randomList.Add(MyNumber);count++;}
// }
// int i = 0;
// while(i < 27)
// {
//     int[,,] m = new int[3, 3, 3];
//     for (int x = 0; x < 3; x++)
//     {
//         for (int y = 0; y < 3; y++)
//         {
//             for (int z = 0; z < 3; z++)
//             {
//                 m[x, y, z] = randomList[i];
//                 Console.Write($"{m[x, y, z]}({x},{y},{z})\t");
//                 i++;
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }


// Task 61
int n = 15;
int i = 1;
string result;
string Spaces = "   ";
int multiplier = n;
while(i < n + 1)
{
    result = string.Join(Spaces, new string[multiplier]);
    Console.Write(result);
    multiplier--;
    int number = 1;
    int j = 1;
    while(j < i + 1)
    {
        Console.Write($"{number}     ");
        number = number * (i - j) / j;
        j++;
    }
    Console.WriteLine();
    i++;
}