// Task 54
int[,] Matrix = new int[4,4];

for(int i = 0; i < Matrix.GetLength(0); i++)
{
    for(int j = 0; j < Matrix.GetLength(1); j++)
    {
        Matrix[i, j] = new Random().Next(1,100);
        Console.Write($"{Matrix[i,j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine("-------------------------------------------------------------");

 void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - 1; j++)
            if (array[j] < array[j + 1])
            {
                int t = array[j + 1];
                array[j + 1] = array[j];
                array[j] = t;
            }
}

for(int i = 0; i < Matrix.GetLength(0); i++)
{
    int[] array = new int[4];
    for(int j = 0; j < Matrix.GetLength(1); j++)
    {
        array[j] = Matrix[i,j];
    }
    BubbleSort(array);
    foreach(int element in array){Console.Write($"{element}\t");}
    Console.WriteLine();
}