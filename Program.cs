// Напишите программу, которая на вход принимает число и выдает его квадрат
//Console.Clear();

//Console.Write("Введите число");

// int number = Convert.ToInt32(Console.ReadLine());

// int sqrt = number * number;
//int sqrt = Convert.ToInt32(Math.Pow(number, 2));

// Console.Write("Число в квадрате: " + sqrt);

// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число 
Console.Write("Input first number: ");
int num1  = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number:");
int num2  = Convert.ToInt32(Console.ReadLine());
int square = num2 * num2;
if(num1 == square)
    Console.Write("First number is a square of second number");
else
    Console.Write("First number is not a square of second number");
        