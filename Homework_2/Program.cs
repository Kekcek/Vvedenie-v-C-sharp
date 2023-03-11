// HOMEWORK 2
// Task 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int splitNumber(int centerNumber)
{
    int cutNumber = centerNumber / 10;
    cutNumber = cutNumber % 10;
    return cutNumber;
}

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number / 100 > 0 && Number / 100 <10)
    Console.WriteLine(splitNumber(Number));
else
    Console.WriteLine("Число должно быть трехначным");
*/

// Task 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int search_Third_Number(int thirdNumber)
{
    while(thirdNumber / 1000 > 0)
    {
        thirdNumber = thirdNumber / 10;
    }
    thirdNumber = thirdNumber % 10;
    return thirdNumber;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 100 > 0)
    Console.WriteLine($"Третье число: {search_Third_Number(number)}");
else
    Console.Write("Третьей цифры нет");
    */

// Task 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool isWeekend(int daysNumber)
{
     if (daysNumber > 0 && daysNumber < 6)
        return false;
     else
        return true;
}
Console.Write("Введите день недели: ");
int daysNumber = Convert.ToInt32(Console.ReadLine());
if (daysNumber > 7)
    Console.WriteLine("Ну это точно не день недели. По крайней мерее не в солнечной системе.");
else if (isWeekend(daysNumber))
        Console.WriteLine("Хватит сидеть за компом. Пора отдыхать");
    else 
        Console.WriteLine("Я знаю, что не хочется, но пора на работу(");