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

// Task 56
int row = 4;
int column = 4;
int[,] Matrix = new int[row, column];

for(int i = 0; i < Matrix.GetLength(0); i++)
{
    for(int j = 0; j < Matrix.GetLength(1); j++)
    {
        Matrix[i, j] = new Random().Next(1,100);
        Console.Write($"{Matrix[i,j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine("--------------------------------------------");

int[] SumArray = new int[row];
for(int i = 0; i < Matrix.GetLength(0); i++)
{
    int[] array = new int[column];
    for(int j = 0; j < Matrix.GetLength(1); j++)
    {
        array[j] = Matrix[i,j];
    }
    int sum = 0;
    foreach(int element in array){sum += element;}
    SumArray[i] = sum;
    Console.WriteLine($"Сумма элементов строки {i} = {sum}");
}
Console.WriteLine("--------------------------------------------");
int minVal = SumArray.Min();
int indexMin = Array.IndexOf(SumArray, minVal);
Console.WriteLine($"Строка с минимальной суммой имеет индекс {indexMin}");
for(int count = 0; count < Matrix.GetLength(1); count++)
{
    Console.Write($"{Matrix[indexMin,count]}\t");
}
Console.WriteLine();