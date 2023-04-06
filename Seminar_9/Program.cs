// SEMINAR 9

// Task 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNum(int num)
{
    if(num > 1) ShowNum(num - 1);
    Console.Write(num + " ");
}
ShowNum(5);
*/

// Task 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр
/*
int SumOfDigit(int num)
{
    if (num != 0) return SumOfDigit(num / 10) + num % 10;
    return 0;
}
Console.WriteLine(SumOfDigit(1234));
*/

// Task 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void NumInterval(int numM, int numN)
{
    if (numM < numN)
    {
        Console.Write(numM + " ");
        NumInterval(numM + 1, numN);
    }
    if (numM > numN)
    {
        Console.Write(numM + " ");
        NumInterval(numM - 1, numN);
    }
    if (numM == numN) Console.WriteLine(numM);
}
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
NumInterval(m, n);
void Range(int m, int n) 
{
    Console.Write(m + " ");
    if(m>n) Range(m-1, n);
    else if (n>m) Range(m+1, n);
}
*/

// Task 4. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
/*
double Multy(int A, int B)
{
    if (B > 0) return Multy(A, B - 1) * A;
    if (B < 0) return Multy(A, B + 1) / A;
    return 1;
}
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Multy(A, B));
*/

// Быстрая сортировка
// Сортировка рекурсии