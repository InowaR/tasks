// // Task 41
// int count = 0;
// while(true)
// {
//     Console.WriteLine("Введите число:");
//     int number = Convert.ToInt32(Console.ReadLine());
//     if(number > 0){count++;}
//     Console.WriteLine($"Введено {count} чисел больше 0");
// }

// // Task 43
// Console.WriteLine("Введите k1:");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите b1:");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите k2:");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите b2:");
// double b2 = Convert.ToDouble(Console.ReadLine());
// double x = (b1 - b2) / (k2 - k1);
// double y = (k1 * x) + b1;
// Console.WriteLine($"Точка пересечения 2 прямых x = {x}, y = {y}.");

// Extra task 1
int[] number = {1,2,3,4,5};
int Factorial(int n)
{
    if (n == 1) return 1;
    return n * Factorial(n - 1);
}
int factorial = Factorial(number.Length);

int[] indexes()
{
    List<int> indexes= new List<int>(); 
    int i = 0;
    while(i < number.Length)
    {
        indexes.Add(i);
        i++;
    }
    int[] index = indexes.ToArray();
    return index;
    }
int[] index = indexes();

