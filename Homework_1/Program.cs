// HOMEWORK 1
// Task 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
    Console.WriteLine($"max = {num1}, min = {num2}");
else
    Console.WriteLine($"max = {num2}, min = {num1}");
*/

// Task 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3)
    Console.Write("max = " + num1);
else if (num2 > num1 && num2 > num3)
        Console.Write("max = " + num2);
    else
        Console.Write("max = " + num3);
*/

// Task 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
    Console.Write("Да!");
else
    Console.Write("Нет!");
*/

// Task 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count < num)
{
    Console.Write(count + " ");
    count = count + 2;
}
*/
