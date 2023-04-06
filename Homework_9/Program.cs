// HOMEWORK 9

// Task 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ReduceNumber(int N)
{
    Console.Write(N + " ");
    if (N > 1) ReduceNumber(N - 1);
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
ReduceNumber(N);
*/

// Task 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SearchSum(int m, int n)
{
    if (m!=n)
    {
        if (m > n)
        {
            return SearchSum(m - 1, n) + m;
        }
        else
        {
            return SearchSum(m + 1, n) + m;
        }
    }
    return m;
}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SearchSum(M,N));
*/

// Task 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Write("Введите первый аргумент M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй аргумент N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akkerman(M, N));
*/