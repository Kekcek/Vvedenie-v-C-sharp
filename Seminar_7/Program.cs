// СЕМИНАР 7

// Task 1. Задайте двумерный массив размером m*n, заполненный случайными числами.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Задайте количество строчек массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте количество столбцоы массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте минимальную велечину элемента массива: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте максимальную велечину элемента массива: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue+1);
        }
    } 
return array;
}

void Write2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateRandom2dArray();
Write2dArray(array);
*/

// Task 2. Задайте двумерный массив размера m * n. При этом каждый элемент в массиве находится по формуле: Aij = i + j
/*
int[,] CreateArray()
{
    Console.Write("Задайте количество строчек массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте количество столбцоы массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
    }
return array;
}

void Write2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "    ");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateArray();
Write2dArray(array);
*/

// Task 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Задайте количество строчек массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте количество столбцоы массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте минимальную велечину элемента массива: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте максимальную велечину элемента массива: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue+1);
        }
    } 
return array;
}


void SqrNumberOfArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
}

void Write2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "    ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array = CreateRandom2dArray();
Write2dArray(array);
SqrNumberOfArray(array);
Write2dArray(array);
*/

// Task 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Задайте количество строчек массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте количество столбцоы массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте минимальную велечину элемента массива: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте максимальную велечину элемента массива: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue+1);
        }
    } 
return array;
}

int CountDiagonal(int[,] array)
{
    int counter = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {
        counter = counter + array[i, i];
    }
    return counter;
}


void Write2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "    ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array = CreateRandom2dArray();
Write2dArray(array);
Console.WriteLine(CountDiagonal(array));
*/

