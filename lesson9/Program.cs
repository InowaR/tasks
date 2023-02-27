// Task 66
int Sum(int m, int n)
{
    if(m == n){return m;}
    return m + Sum(m + 1, n);
}
Console.WriteLine(Sum(4,8));

// Task 68
int Ackermann(int n, int m)
{
    while(n != 0)
    {
        if(m == 0){m = 1;}
        else{m = Ackermann(n, m - 1);}
        n--;
    }
    return m + 1;
}
Console.WriteLine(Ackermann(3,2));