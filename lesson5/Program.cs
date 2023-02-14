// // Task 34
// int[] random(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = new Random().Next(100, 1000);
//   }
//   return array;
// }

// int[] array = new int[60];
// int[] arr = random(array);

// List<int> even_numbers = new List<int>();
// foreach(int i in arr)
// {
//     if(i % 2 == 0){even_numbers.Add(i);}
//     Console.Write($"{i}, ");
// }
// int[] even = even_numbers.ToArray();
// Console.WriteLine();
// int len = even.Length;
// if(((10+len) - (len/10) * 10) % 11 == 0){Console.WriteLine($"В массиве {len} четное число");}
// else if(((10+len) - (len/10) * 10) % 11 == 1){Console.WriteLine($"В массиве {len} четных числа");}
// else if(((10+len) - (len/10) * 10) % 11 == 2){Console.WriteLine($"В массиве {len} четных числа");}
// else if(((10+len) - (len/10) * 10) % 11 == 3){Console.WriteLine($"В массиве {len} четных числа");}
// else {Console.WriteLine($"В массиве {len} четных чисел");}


// // Task 36
// int[] random(int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = new Random().Next(10, 50);
//   }
//   return array;
// }

// int[] array = new int[6];
// int[] arr = random(array);
// foreach (int c in arr)
// {
//     Console.Write($"{c}, ");
// }

// List<int> odd_position = new List<int>();
// int count = 0;
// while(count < arr.Length)
// {
//     if (count % 2 == 1){odd_position.Add(arr[count]);}
//     count++;
// }
// Console.WriteLine();
// int[] odd = odd_position.ToArray();
// int sum = 0;
// foreach (int j in odd)
// {
//     sum += j;
// }
// Console.WriteLine($"Сумма элементов нечетных позиций в массиве = {sum}");


// Task 38
double GetPseudoDoubleWithinRange(double lowerBound, double upperBound)
{
    var random = new Random();
    var rDouble = random.NextDouble();
    var rRangeDouble = rDouble * (upperBound - lowerBound) + lowerBound;
    return rRangeDouble;
}

double[] array = new double[6];

for (int i = 0; i < array.Length; i++)
{
array[i] = GetPseudoDoubleWithinRange(1,10);
}

void diff_max_min()
{
    List<double> odd_position = new List<double>();
    double max = 0;
    foreach (double c in array)
    {   
        if(c > max){max = c;}
    }

    double min = max;
    foreach (double c in array)
    {   
        Console.Write($"{Math.Round(c,2)}, ");
        if(c < min){min = c;}
    }
    Console.WriteLine();
    Console.Write($"{Math.Round(max - min, 2)}");
}
diff_max_min();


// Extra task
List<int> randomList = new List<int>();
int MyNumber = 0;
for (int i = 0; i < 10; i++)
{
    MyNumber = new Random().Next(1, 31);
    if (!randomList.Contains(MyNumber)){randomList.Add(MyNumber);}
}
foreach (int c in randomList)
{
    Console.Write($"{c}, ");
}
Console.WriteLine();
void find_days()
{
    List<int> even_days = new List<int>();
    List<int> odd_days = new List<int>();
    foreach (int j in randomList)
    {   
        if(j % 2 == 0){even_days.Add(j);}
        else{odd_days.Add(j);}
    }
    int[] even = even_days.ToArray();
    int[] odd = odd_days.ToArray();
    if(even.Length >= odd.Length){Console.WriteLine("Yes");}
    else{Console.WriteLine("No");}
}
find_days();