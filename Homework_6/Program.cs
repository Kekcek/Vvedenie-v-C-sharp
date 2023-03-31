// HOMEWORK 6.

// Task 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int CountNumbersMoreZero(int size)
{
    int counter = 0;
    int temp = 0;
    while (size > 0)
    {
        temp = Convert.ToInt32(Console.ReadLine());
        if (temp > 0) counter++;
        size --;
    }
return counter;
}

Console.WriteLine("Введите количество чисел");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чисел больше нуля: " + CountNumbersMoreZero(size));
*/


// Task 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
string CheckOnParalelOrIdent(double k1, double k2, double b1, double b2)
{
    string result = "";
    if (k1 == k2)
    {
        if (b1 == b2)
            result = "Каждая точка функция является точкой пересечения";
        else
            result = "Фукнции параллельны, поэтому обших точек нет";
    }
return result;
}

double[] SerchCommonPoints(double k1, double k2, double b1, double b2) 
{
    double x = ((b2-b1)/(k1-k2));
    double y = k1 * x + b1;
    double[] result = {x,y};
return result;
}

Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

string result = CheckOnParalelOrIdent(k1, k2, b1, b2);

if (result == "")
{
    double[] resultpoint = SerchCommonPoints(k1, k2, b1, b2);
    Console.WriteLine("{" + resultpoint[0] + ", " + resultpoint[1] + "}");
}
else
{
    Console.WriteLine(result);
}
*/

