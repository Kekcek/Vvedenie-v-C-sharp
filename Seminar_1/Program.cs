/*
int intgerNum = 32;
double doubleNum = 2.31234;

string word = "sfsdf";
char symbol = 'f'; // Здесь можно только символы и только один

bool check = true; // Логический тип данных, используется для проверки условий


int num = 5;
Console.WriteLine($"My number is {num}"); // $ и {} используется для того, чтобы можно было выводить значение переменных без конкатенации

Console.Write("Input a number: ");
num = Convert.ToInt32(Console.ReadLine());
*/

// Seminar 1 
// Task 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if (num1 == quad2)
    Console.WriteLine("Yes!");
else
    Console.WriteLine("No!");


// Task 2. Напишите программу, которая принимает на вход одно число N, а на выходе показывает все целые числа от -N до N.

Console.Write("Input a positive number:");
int number = Convert.ToInt32(Console.ReadLine()); // Так как readline принимает строку, то чтобы записать число с клавиатуры в переменную инт, нам нужно воспользовать конвертером

int current = -number;

while (current <= number)
{
    Console.Write(current + " ");
    current++;
}
