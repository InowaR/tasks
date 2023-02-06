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
    int n = degree(10, (length(number) / 2) + 1);
    int left = number / n;
    return left;
}

int l = left();

int right()
{
    int right = reverse(number % degree(10, (length(number) / 2)));
    if(right % 10 == 0){right /= 10;}
    return right;
}

int r = right();

void main(int l, int r)
{
    if(l == r){Console.WriteLine($"Число {number} палиндром");}
    else{Console.WriteLine($"Число {number} не палиндром");}
}

main(l, r);