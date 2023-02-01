// Task 10
void second_number()
{
    Console.WriteLine("Введите трехзначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine((number / 10) % 10);
}
second_number();

// Task 13
void third_number()
{
    Console.Clear();
    Console.WriteLine("Введите любое число");
    int number = Convert.ToInt32(Console.ReadLine());
    int len = 1;
    int temp = number;
    while (len < temp)
    {
        temp = temp / 10;
        len++;
    }

    if(len < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
    int zeros = Convert.ToInt32(Math.Pow(10, len - 3));
    Console.WriteLine((number / zeros) % 10);
    }
}
third_number();

// Task 15
void day_of_the_week()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Введите число от 1 до 7");
        int n = Convert.ToInt32(Console.ReadLine());
        if(n > 0 && n < 8)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;

                case 2:
                    Console.WriteLine("Вторник");
                    break;

                case 3:
                    Console.WriteLine("Среда");
                    break;

                case 4:
                    Console.WriteLine("Четверг");
                    break;

                case 5:
                    Console.WriteLine("Пятница");
                    break;

                case 6:
                    Console.WriteLine("Суббота");
                    break;

                case 7:
                    Console.WriteLine("Воскресенье");
                    break;    
            }
            break;
        }
        else
        {   
            Console.Clear();
            Console.WriteLine("Вы ввели неверное число");
            Console.WriteLine("Введите число от 1 до 7");
            n = Convert.ToInt32(Console.ReadLine());
        }
    }
}
day_of_the_week();

// Extra task
void second_max()
{
    string input = File.ReadAllText("input.txt");
    string a = input;
    int[] arr = a.Split(',').Select(int.Parse).ToArray();

    int old_max = 0;
    int new_max = 0;
    int count = 0;
    while (count < arr.Length)
    {   
        
        if(arr[count] > new_max)
        {   
            old_max = new_max;
            new_max = arr[count];
        }
        if(arr[count] == 0){break;}

        count++;
    }
    File.WriteAllText("output.txt", old_max.ToString());
}
second_max();