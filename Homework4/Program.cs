// Задача 25: Используя определение степени числа, напишите цикл,
// который принимает на вход два натуральных числа (A и B) и
// возводит число A в степень B.
void Zadacha25()
{
    Console.WriteLine("Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.");
    Console.WriteLine("Введите первое натуральное число");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе натуральное число");
    int B = Convert.ToInt32(Console.ReadLine());
    int St = A;

    if (A < 0 || B < 0)
        Console.WriteLine("Введите натуральные числа!!!");
    else if (B == 0)
        {
            Console.WriteLine($"Число {A} в степени {B} равно 1");
        }
        else
        {
            for (int i = 2; i <= B; i++)
                {
                    St = St * A;
                }
            Console.WriteLine($"Число {A} в степени {B} равно {St}");
        }
}

// Задача 27: Напишите программу, которая принимает на вход число и
// выдаёт сумму цифр в числе.
void Zadacha27()
{
    Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int Sum = 0;
    int numb = Math.Abs(number);

    while (numb > 0)
    {
        Sum = Sum + (numb % 10);
        numb = numb / 10;
    }

    Console.WriteLine($"Сумма цифр числа {number} равна {Sum}");
}

//Задача 29: Напишите программу, которая задаёт массив из 8 случайных
// целых чисел и выводит отсортированный по модулю массив.
void Zadacha29()
{
    Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.");
    int size = 8;
    int[] array = new int[size];
    Random rand = new Random();
    int MaxEl, IndMaxEl;    //Максимальный элемент массива и его индекс
    int temp;

    Console.WriteLine("Исходный массив:");
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(-1001,1001);
        Console.Write(array[i] + ", ");
    };
    Console.WriteLine("\b\b]");

    for (int j = 0; j < size - 1; j++)
    {
        MaxEl = array[0];
        IndMaxEl = 0;
       
        for (int i = 1; i < size - j; i++)    // Ищем максиальный элемент массива
        {
            if (Math.Abs(array[i]) > Math.Abs(MaxEl))
            {
                MaxEl = array[i];
                IndMaxEl = i;
            }
        }
        // Помещаем максимальный элемент массива в конец массива, а на его место
        // последний элемент массива
        temp = array[size-j-1];
        array[size-j-1] = MaxEl;
        array[IndMaxEl] = temp;
    }

    Console.WriteLine("Отсортированный массив:");
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine("\b\b]");
}


Zadacha25();
Zadacha27();
Zadacha29();