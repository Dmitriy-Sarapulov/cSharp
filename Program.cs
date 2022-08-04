// Напишите программу, которая на вход принимает число и выдает его квадрат
Console.Clear();

Console.Write("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

int sqrt = number * number;
//int sqrt = Convert.ToInt32(Math.Pow(number, 2));

Console.Write("Число в квадрате: " + sqrt);