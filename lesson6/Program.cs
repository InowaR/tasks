// Task 41
int count = 0;
while(true)
{
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number > 0){count++;}
    Console.WriteLine($"Введено {count} чисел больше 0");
}

// Task 43