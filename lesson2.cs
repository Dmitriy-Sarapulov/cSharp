//Массивы и функции
// Задача 1 Напишите программу, которая выводит слуяайное число из отрезка (10,99) и показывает наидульшую цифру из двухзначного числа.
// int num = new Random().Next(10,99);
// Console.WriteLine(num);
// int a = num % 10; // Нахождение перого числа из 2-ух
// int b = num / 10; // Нахождение второго числа из 2-ух
// if (a > b) {
//     Console.WriteLine("Max = " + a);
// }
// else{
//     Console.WriteLine("Max = " + b);
// }


// Задача 2 Программа которая выводит 3-ех значное число и удаляет из него вторую цифру и выводит число из двух оставшихся.

int num = new Random().Next(100, 999);
Console.WriteLine(num);
int a = num / 100;
int b = num / 10;
int c = num % 10;

Console.WriteLine($"{a}{c}");