// Task 2
void max_two_numbers()
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int max;
    if (a > b)
    {
        max = a;
    }
    else
    {
        max = b;
    }
    Console.WriteLine($"Max number: {max}");
}

max_two_numbers();


// Task 4
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int k = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (m > max)
{
    max = m;
}

if (n > max)
{
    max = n;
}

if (k > max)
{
    max = k;
}
Console.WriteLine($"Max number: {max}");

// Task 6
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine($"{a} - четное");
}
else
{
    Console.WriteLine($"{a} - нечетное");
}

// Task 8
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= N)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count}, ");
    }
    count++;
}
