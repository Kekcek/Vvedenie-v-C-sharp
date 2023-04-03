// SEMINAR 8

// Task 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

void ChangeRows(int[,] array, int r1, int r2)
{
    if (r1 < array.GetLength(0) && r1 >= 0 && 
        r2 < array.GetLength(0) && r2 >= 0 && 
        r1 != r2)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                int temp = array[r1, j];
                array[r1, j] = array[r2, j];
                array[r2, j] = temp;
            }
        }
}

int[,] myArray = CreateRandom2dArray();
Write2dArray(myArray);

Console.WriteLine("Введите номер первой строки, которую надо заменить: ");
int row1 = Convert.ToInt32(Console.ReadLine()) - 1; 
Console.WriteLine("Введите номер второй строки, которую надо заменить: ");
int row2 = Convert.ToInt32(Console.ReadLine()) - 1;

ChangeRows(myArray, row1, row2);
Write2dArray(myArray);
*/


// Task 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
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

void ChangeRows(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
                temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
        }
    }
}

int[,] myArray = CreateRandom2dArray();
Write2dArray(myArray);
ChangeRows(myArray);
Console.WriteLine();
Write2dArray(myArray);
*/


// Task 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
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


int[] FindArrayMin(int[,] array)
{
    int[] minCoord = {0,0};
    int min = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i ,j] < min) 
            {
                min = array[i, j];
                minCoord[0] = i;
                minCoord[1] = j;
            }
        }
    }
    return minCoord;
}


int[,] CreateNewArray(int[,] array, int[] coordinates)
{
    int[,] newArrayWithoutTwoLines = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == coordinates[0]) i++;
            if (j == coordinates[1]) j++;

            if (i > coordinates[0])
            {
                if (j > coordinates[1]) 
                {
                    newArrayWithoutTwoLines[i - 1, j - 1] = array[i,j];
                }
                else newArrayWithoutTwoLines[i - 1, j] = array[i,j]; 
            }
            else
            {
                if (j > coordinates[1]) 
                {
                    newArrayWithoutTwoLines[i, j - 1] = array[i,j];
                }
                else newArrayWithoutTwoLines[i, j] = array[i,j]; 
            }
        }
    }
    return newArrayWithoutTwoLines;
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
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Write2dArray(myArray);
int[] coordinates = FindArrayMin(myArray);
Console.Write(coordinates[0] + " ");
Console.WriteLine(coordinates[1]);
int[,] newArray = CreateNewArray(myArray, coordinates);
Write2dArray(newArray);
*/