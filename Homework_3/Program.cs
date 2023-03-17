// Task 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool checkPolindrom(int number, int SizeNumber)
{
    while (SizeNumber > 0)
    {
        if (number % 10 == Convert.ToInt32(number / Math.Pow(10, SizeNumber)) & (SizeNumber > 0)) 
        {
            number = number - Convert.ToInt32(number / Math.Pow(10, SizeNumber)) * Convert.ToInt32(Math.Pow(10, SizeNumber));
            number= number / 10;
        }
        else
        {
            return false;
        }
        SizeNumber = SizeNumber - 2; 
    };
    return true;
}

int SizeOfNumber(int LengthNumber)
{
    int counter = 0;
    while(LengthNumber > 0)
{
    LengthNumber = LengthNumber / 10;
    counter++;
}
return counter;
}

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int SizeNumber = SizeOfNumber(Number);
bool result = checkPolindrom(Number, SizeNumber-1);
Console.WriteLine(result);
*/


// Task 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double SearchDistance3D(int[] ArrayFirstPoint, int[] ArraySecondPoint)
{
    double sum = 0;
    for (int count = 0; count < ArrayFirstPoint.Length; count++)
    {
        sum = sum + Math.Pow(ArraySecondPoint[count] - ArrayFirstPoint[count], 2);
    }
    return Math.Sqrt(sum);
}

void EnterPoint(int[] CoordinatesOfPoint)
{
    int count = 0;
    while (count < 3)
    {
        CoordinatesOfPoint[count] =  Convert.ToInt32(Console.ReadLine());
        count++;
    }
}

Console.WriteLine("Введите координаты первой точки: ");
int[] FirstPoint = new int[3];
int[] SecondPoint = new int[3];
EnterPoint(FirstPoint);
Console.WriteLine("Введите координаты второй точки: ");
EnterPoint(SecondPoint);

double result = SearchDistance3D(FirstPoint, SecondPoint);
Console.WriteLine(Math.Round(result,2));
*/


// Task 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
int SearchCubeOfNumber(int num)
{
    num = Convert.ToInt32(Math.Pow(num, 3));
    return num;
}

Console.Write("Введите число для диапазон: ");
int Number = Convert.ToInt32(Console.ReadLine());
int temp = 0;
for(int count = 1; count <= Number; count++)
{
    temp = SearchCubeOfNumber(count);
    Console.WriteLine(temp);
}
*/
