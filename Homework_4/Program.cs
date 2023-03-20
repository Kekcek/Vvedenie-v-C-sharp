// HOMEWORK 4
// Task 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int DoDegree(int a, int b)
{
    int result = a;
    while (b > 1)
    {
        result = result * a;
        b--;
    }
    return result;
}

Console.WriteLine("Введите число, которую нужно возвести в степень: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = DoDegree(A, B);
Console.WriteLine(result);
*/

// Task 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*

int SumFigureOfNumber(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

Console.WriteLine("Введите число в котором необходимо найти сумму цифр: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumFigureOfNumber(number));
*/

//Task 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] GetMassive(int count)
{
    int[] array = new int[count];
    for (int index = 0; index < count; index++)
    {
        array[index] = Convert.ToInt32(Console.ReadLine());
    }

return array;
}

void OutputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write( + array[i]+ " ");
    }
}

Console.WriteLine("Напишите количесто эллементов массива: ");
int quantityOfMassive = Convert.ToInt32(Console.ReadLine());
int[] array = GetMassive(quantityOfMassive);
OutputArray(array);
*/