// HOMEWORK 5.

// TASK 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(100,1000);
    }
return array;
}


int CountEvenNumberInArray(int[] array)
{
    int counter = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (index % 2 == 0) counter++;
    }

return counter;
}

void DisplayArrayOnScreen(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write(array[index] + " ");
    }
}


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size);
DisplayArrayOnScreen(array);
Console.WriteLine();
Console.WriteLine(CountEvenNumberInArray(array));
*/

// TASK 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(minValue, maxValue+1);
    }
return array;
}

int SumUnevenNUmber(int[] array)
{
    int sum_of_array = 0;
    for (int index = 1; index < array.Length; index = index + 2)
    {
        sum_of_array = sum_of_array + array[index];
    }
return sum_of_array;
}

void DisplayArrayOnScreen(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write(array[index] + " ");
    }
    Console.WriteLine();
}


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число для рандома: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число для рандома: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, minValue, maxValue);
DisplayArrayOnScreen(array);

Console.WriteLine(SumUnevenNUmber(array));
*/

// TASK 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for (int index = 0; index < size; index++)
    {
        array[index] = Math.Round(new Random().Next(minValue, maxValue+1) + new Random().NextDouble(), 2);
    }
return array;
}

void DisplayArrayOnScreen(double[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write(array[index] + " ");
    }
    Console.WriteLine();
}

double SearchDifference(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] < min)
            min = array[index];
        else if (array[index] > max)
                    max = array[index];
    }

    double diff = max - min;
    return diff;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число для рандома: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число для рандома: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] array = CreateRandomArray(size, minValue, maxValue);
DisplayArrayOnScreen(array);

Console.WriteLine(SearchDifference(array));
*/
