// // Task 25
int degree(int num, int degree)
{
    int res = 1;
    int count = 0;
    while(count < degree)
    {
        res *= num;
        count++;
    }
    return res;
}


// Task 27
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int length(int number)
{
    int len = 1;
    int temp = number;
    while (len < temp)
    {
        temp = temp / 10;
        len++;
    }
    return len;
}
int len = length(number);
int sum_numbers = 0;
int sum = 0;
for(int i = 1; i < len; i++)
{
    sum = number % degree(10, i);
    sum /= degree(10, i) / 10;
    sum_numbers += sum; 
}
Console.WriteLine(sum_numbers);