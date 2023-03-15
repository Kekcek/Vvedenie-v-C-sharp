// Math.Pow(a,b) = a^b
// Math.Sqrt(a) = корень из а
// Math.Round(a, b) - выводит информацию пользователяю. Позволяет сделать укорачивание числа. 1-аргумент - самое число. 
// 2-аргумент указывается количество цифр, которые должны быть после запятой

// Task 1. Напишите программу, которая по заданному номеру четверти, покажет диапазон координат точек в этой четверти
/*
void ShowDiapazone(int quadNum)
{
    if (quadNum == 1)       Console.WriteLine($"On {quadNum} quadrant there are x > 0 and y > 0");
    else if (quadNum == 2)  Console.WriteLine($"On {quadNum} quadrant there are x < 0 and y > 0");
    else if (quadNum == 3)  Console.WriteLine($"On {quadNum} quadrant there are x < 0 and y < 0");
    else if (quadNum == 4)  Console.WriteLine($"On {quadNum} quadrant there are x > 0 and y < 0");
    else  Console.WriteLine("Wrong number of quadrant: ");
}
Console.Write("Input a number of quadrant: ");
int quadrant = Convert.ToInt32(Console.ReadLine());
ShowDiapazone(quadrant);
*/

// Task 2. Напишите программу, которая принимает на вход координаты точки и выдает номер четверти в которой находится эта точка.
/*
int SearchQuadran (double x, double y)
{
    int result = 0;
    if (x > 0 && y > 0)         result = 1;
    else if (x < 0 && y > 0)    result = 2;
    else if (x < 0 && y < 0)    result = 3;
    else if (x > 0 && y < 0)    result = 4;
    return result;
}

Console.Write("Введите первый аргумент координаты:");
double arg1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второй аргмуент координаты: ");
double arg2 = Convert.ToDouble(Console.ReadLine());
int result = SearchQuadran(arg1, arg2);
Console.WriteLine($"Точка {arg1},{arg2} находится в {result} четверти");
*/

// Task 3. Напишите программу которая принимает на вход некоторое число и выдает таблицу квадратов от 1 до N.
/*
void tableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine(count + " - " + count*count);
        count++;
    }
}

Console.Write("Введите число: ");
int square = Convert.ToInt32(Console.ReadLine());
tableSquare(square);
*/
// Task 4. Программа принимает на вход координаты двух точек и находит расстояние между ними в двумерном пространстве.
/*
double Distance(double x1, double y1, double x2, double y2)
{
    double dist = Math.Sqrt(Math.Pow( x1 - x2 , 2) +  Math.Pow(y1 - y2 , 2));
    return dist;
}

Console.Write("Введите кординаты первый точки: ");
double argx1 = Convert.ToDouble(Console.ReadLine());
double argy1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординаты второй точки: ");
double argx2 = Convert.ToDouble(Console.ReadLine());
double argy2 = Convert.ToDouble(Console.ReadLine());

double result = Distance(argx1, argy1, argx2, argy2);
Console.Write($"Расстояние между двумя координатами = {result}");
*/