
// Task 1. Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.

int CutNumber(int num)
{
    int hundreds = num / 100;
    int units = num % 10;

    int result = hundreds * 10 + units;
    return result;
}

int randomNumber = new Random().Next(100, 1000);
int newNumber = CutNumber(randomNumber);
Console.WriteLine($"Число полученное рандомом {randomNumber} и число полченное в результате функции {newNumber}");


// Task 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int GetMaxNumber(int num)
{
    int num1 = num /10;
    int num2 =  num % 10;
    if(num1 < num2) 
            return num2;
    else return num1 ;
}
int randNumber = new Random().Next(10, 100);
Console.WriteLine(randNumber);
Console.WriteLine(GetMaxNumber(randNumber));

// Task 3. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
bool Kratnoe(int num , int div1 , int div2)
{
    if(num % div1 == 0 && num % div2 == 0)
    {
        return true;
    }

    return false;
}
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первый делитель ");
int div1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй делитель ");
int div2 = Convert.ToInt32(Console.ReadLine());
bool result = Kratnoe(num , div1, div2);
Console.WriteLine($"Результат: {result}");

// Task 4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool SquareNumber(int num1 , int num2)
{
    if(num1 == num2 * num2 || num2 == num1 * num1)
    {
        return true ; 
    }
    return false ;
}
Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
bool result = SquareNumber(num1 , num2);
Console.WriteLine($"Результат работы: {result}");
