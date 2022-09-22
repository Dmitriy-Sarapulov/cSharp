// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// int Func(string message)
// {
//     Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// void Check(int number)
// {
//     if(number > 0)
//     {
//         int[]oneArray = InputArray(number);
//         PrintArray(oneArray);
//         Console.WriteLine($"Количество положительных чисел равно {PlusNumbers(oneArray)}");
//     }
//     else
//     {
//         Console.WriteLine("Количество не может быть отрицательным или равным нулю");
//     }
// }

// int[] InputArray(int number)
// {
//     int[] oneArray = new int[number];
//     int i = 0;
//     while (i < number)
//     {
//         Console.Write("Введите число: ");
//         oneArray[i] = int.Parse(Console.ReadLine());
//         i++;
//     }
//     return oneArray;
// }

// int PlusNumbers(int[]oneArray)
// {
//     int count = 0;
//     for(int i = 0; i < oneArray.Length; i ++)
//     {
//         if(oneArray[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// void PrintArray(int[] oneArray)
// {
//     for(int i = 0; i < oneArray.Length; i++)
//     {
//         Console.Write($"{oneArray[i]} ");
//     }
// }

// int number = Func("Выберите количество чисел ");
// Check(number);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, 
// k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("введите значение b1");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("введите число k1");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("введите значение b2");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("введите число k2");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x = (b2 - b1)/(k1 - k2);
// double y = k1 * x + b1;

// Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");