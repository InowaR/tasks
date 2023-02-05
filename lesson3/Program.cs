Console.WriteLine("start");
int number = Convert.ToInt32(Console.ReadLine());

int length()
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

int pow(int x, int i)
{
    int res = 1;
    int count = 0;
    while(count < i)
    {
        res *= x;
        count++;
    }
    return res;
}
int len = length();
int n = pow(10,(len/2) + 1);
int left = number / n;
int right = number % 100;
Console.WriteLine($"{left}, {right}");
Console.WriteLine($"{left == right}");