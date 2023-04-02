// СЕМИНАР 6.

/*
// void ShowNum(int num)
// {
//     num += 5;
//     Console.WriteLine(num); // 
// }
// int num = 5;
// ShowNum(num);
// Console.WriteLine(num);
void ShowNum(int[] num)
{
    num[0] += 5;
    Console.WriteLine(num[0]); // массивы - ссылочный тип данных, именно поэтому когда мы передем массив в функцию, не создается копия, как с числами, а меняется сам массив.
}
int[] array = {1, 2, 3};
ShowNum(array);
Console.WriteLine(array[0]);
*/

// Task 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
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
void ReverseArray(int[] array)
{
    for(int leftIndex = 0, rightIndex = array.Length - 1; 
    leftIndex < rightIndex; leftIndex++, rightIndex--)
    {
        int temp = array[leftIndex];
        array[leftIndex] = array[rightIndex];
        array[rightIndex] = temp;
    }
}
    Console.Write("Введите размер массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите нижнее значения для чисел массива: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите верхнее значения для чисел массива: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[] array = CreateRandomArray(length, minValue, maxValue);
    WriteArray(array);
    ReverseArray(array);
    WriteArray(array);
*/

// Task 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
// bool CheckSide(int NumA, int NumB, int NumC)
// {
//     if (NumA < NumB + NumC && NumB < NumA + NumC && NumC< NumA + NumB) return true;
//     return false;
// }
//     Console.Write("Введите сторону A: ");
//     int NumA = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите сторону B: ");
//     int NumB = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите сторону С: ");
//     int NumC = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(CheckSide(NumA, NumB, NumC));
*/

// Task 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
/*
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] CreateArrayFibonachi(int N, int First, int Second)
{
    int[] Array = new int[N];
    Array[0] = First;
    Array[1] = Second;
    for (int index = 2; index < N; index++)
    {
        Array[index] = Array[index - 1] + Array[index - 2];
    }
    return Array;
}
Console.Write("Введите размер ряда: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число последовательности: ");
int First = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число последовательности: ");
int Second = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayFibonachi(N, First, Second);
WriteArray(array);
*/

// Task 4. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
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
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] CopyArray(int[] OldArray)
{
    int[] NewArray = new int[OldArray.Length];
    for (int index = 0; index < OldArray.Length; index++)
    {
        NewArray[index] = OldArray[index];
    }
    return NewArray;
}
Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижнее значения для чисел массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхнее значения для чисел массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] OldArray = CreateRandomArray(length, minValue, maxValue);
int[] NewArray = CopyArray(OldArray);
*/
