// // Task 25
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

// // Extra task 1

// int[] array = {1,2,3,4,5,6,7,8,9};
// int n = array.Length;
// int[] new_array = new int[n];
// int k = -3;
// int i = 0;
// int position;

// if(k > 0)
// {
//     i = 0;
//     position = n - k;
//     while(i < n)
//     {
//         new_array[i] = array[position];
//         position++;
//         if(position == n){break;}
//         i++;
//     }

//     i = 0;
//     while(k < n)
//     {
//         new_array[k] = array[i];
//         k++;
//         i++;
//     }

//     foreach (int element in new_array)
//     {
//         Console.Write($"{element} ");
//     } 
// } 

// if(k < 0)
// {
//     i = n + k;
//     while(i < n)
//     {
//         new_array[i] = array[i-n-k];
//         i++;
//     }

//     i = -k;
//     int j = 0;
//     while(i < n)
//     {
//         new_array[j] = array[i];
//         i++;
//         j++;
//     }

//     foreach (int element in new_array)
//     {
//         Console.Write($"{element} ");
//     } 
// } 

//  Extra task 2

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int max = 1000;
int i = 2;
List<int> prime()
{
    List<int> prime_numbers = new List<int>();
    while(i <= max)
    {   
        List<int> numbers = new List<int>();
        double[] array = new double[i];
        int j = 1;
        while(j <= i)
        {   
            array[j-1] = j;
            j++;
        } 

        int count = 0;   
        while(count < array.Length)
        {
            double res = i / array[count];
            if(res == Convert.ToInt32(res)){numbers.Add(Convert.ToInt32(res));}
            count++;
        }
        int[] num = numbers.ToArray();
        if(num.Length < 3){prime_numbers.Add(i);}
        i++;
    }
    return prime_numbers;
}
List<int> a = prime();
List<int> sum = new List<int>();
List<int> index_i = new List<int>();
List<int> index_j = new List<int>();
int[] arr1 = a.ToArray();
int count = 0;
while(count < arr1.Length)
{   
    int j = 0;
    while(j < arr1.Length)
    {   
        sum.Add(arr1[count] + arr1[j]);
        index_i.Add(count);
        index_j.Add(j);

        j++;
    }
    count++;
}
int[] arr2 = sum.ToArray();
int s = 0;
while(s < arr2.Length)
{
    if(arr2[s] == N){break;}
    s++;
}

int first_prime = index_i[s];
int second_prime = index_j[s];

Console.WriteLine($"Четное число {N} = {arr1[first_prime]} + {arr1[second_prime]}");