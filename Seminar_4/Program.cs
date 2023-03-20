// СЕМИНАР 4.
// Task 1. Наобходимо задать число и вывести сумму чисел от одного до этого числа.
/*
int GetSumOfNumbers(int number)
{
    int sum = 0;
    for (int current = 0; current <= number; current++) // переменная созданная внутри цикла(current) будет существовать только там
    {
        sum = sum + current;
    }
    return sum;
}

Console.WriteLine("Введите рабочее число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetSumOfNumbers(number));
*/

// Task 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int QuantityFigureInNumber(int number)
{
    int counter = 0;
    while (number> 0)
    {
        if (number > 0) 
        {
            counter++;
            number = number / 10;
        }
        else break;
    }
    return counter;
}
Console.WriteLine("Введите рабочее число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(QuantityFigureInNumber(number));
*/

// Task 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Factroial(int num)
{
    int result = 1;
    for (int i = 2; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}
Console.WriteLine("Введите рабочее число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Factroial(number));
*/

// Массивы
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // new int[размер] - эта констуркция позволяет инициализировать массив

    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }

    Console. WriteLine();
}

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижнее значения для чисел массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхнее значения для чисел массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(length, minValue, maxValue);
WriteArray(array);
*/