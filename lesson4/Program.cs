﻿// // Task 25
// int degree(int num, int degree)
// {
//     int res = 1;
//     int count = 0;
//     while(count < degree)
//     {
//         res *= num;
//         count++;
//     }
//     return res;
// }


// // Task 27
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int length(int number)
// {
//     int len = 1;
//     int temp = number;
//     while (len < temp)
//     {
//         temp = temp / 10;
//         len++;
//     }
//     return len;
// }
// int len = length(number);
// int sum_numbers = 0;
// int sum = 0;
// for(int i = 1; i < len; i++)
// {
//     sum = number % degree(10, i);
//     sum /= degree(10, i) / 10;
//     sum_numbers += sum; 
// }
// Console.WriteLine(sum_numbers);


// // Task 29
// int[] array = {10,8,5,5,4,4,4,3,2,1};
// int n = array.Length;
// int[] new_array = new int[n+1];
// int height = 4;
// int i = 0;
// while(i < n)
// {   
//     new_array[i] = array[i];
//     if (height == array[i])
//     {
//         if (height == array[i+1])
//         {
//             i++;
//             continue;
//         }
//         else
//         {
//             new_array[i+1] = 0;
//             break;
//         }
//     }
//     i++;
// }

// i = i+=2;
// while(i < n+1)
// {
//     new_array[i] = array[i-1];
//     i++;
// }

// foreach (int element in new_array)
// {
//     Console.Write($"{element} ");
// }

// Extra task 1

int[] array = {1,2,3,4,5,6,7,8,9};
int n = array.Length;
int[] new_array = new int[n];
int k = -3;
int i = 0;
int position;

if(k > 0)
{
    i = 0;
    position = n - k;
    while(i < n)
    {
        new_array[i] = array[position];
        position++;
        if(position == n){break;}
        i++;
    }

    i = 0;
    while(k < n)
    {
        new_array[k] = array[i];
        k++;
        i++;
    }

    foreach (int element in new_array)
    {
        Console.Write($"{element} ");
    } 
} 

if(k < 0)
{
    i = n + k;
    while(i < n)
    {
        new_array[i] = array[i-n-k];
        i++;
    }

    i = -k;
    int j = 0;
    while(i < n)
    {
        new_array[j] = array[i];
        i++;
        j++;
    }

    foreach (int element in new_array)
    {
        Console.Write($"{element} ");
    } 
} 
