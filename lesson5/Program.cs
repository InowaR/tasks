﻿// // Task 34
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

// Task 36

int[] random(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(10, 50);
  }
  return array;
}

int[] array = new int[6];
int[] arr = random(array);
foreach (int c in arr)
{
    Console.Write($"{c}, ");
}

List<int> odd_position = new List<int>();
int count = 0;
while(count < arr.Length)
{
    if (count % 2 == 1){odd_position.Add(arr[count]);}
    count++;
}
Console.WriteLine();
int[] odd = odd_position.ToArray();
int sum = 0;
foreach (int j in odd)
{
    sum += j;
}
Console.WriteLine($"Сумма элементов нечетных позиций в массиве = {sum}");