// Task 19
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

int reverse(int number)
{
    int len = length(number);
    int temp = 0;
    int count = 0;
    int i = 1;
    int i_reversed = degree(10, len);
    int c = 0;
    while(count < len)
    {
        c = (number / i) % 10;
        temp += c * i_reversed;
        i *= 10;
        count += 1;
        i_reversed /= 10;
    }
    return temp / 10;
}

int left()
{   
    int n;
    int left;
    if(number > 50000)
    {
        n = degree(10, (length(number) / 2));
        left = number / n;
    }
    else
    {
        n = degree(10, ((length(number) / 2) + 1));
        left = number / n;
    }
    return left;
}

int l = left();

int right()
{
    int n = reverse(number);
    int d = degree(10, ((length(n) / 2) + 1));
    int right = n / d;
    return right;
}

int r = right();

void main(int l, int r)
{
    if(l == r){Console.WriteLine($"Число {number} палиндром");}
    else if(number == reverse(number)){Console.WriteLine($"Число {number} палиндром");}
    else{Console.WriteLine($"Число {number} не палиндром");}
}

main(l, r);


// Task 21
Console.WriteLine("Введите координаты x,y,z точки А через пробел");
string first = Console.ReadLine()!;
double[] a = first.Split(' ').Select(double.Parse).ToArray();
Console.WriteLine("Введите координаты x,y,z точки B через пробел");
string second = Console.ReadLine()!;
double[] b = second.Split(' ').Select(double.Parse).ToArray();
double x = a[0] - b[0];
double y = a[1] - b[1];
double z = a[2] - b[2];
double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
Console.WriteLine(distance);


// Task 23
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= n)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
    i++;
}