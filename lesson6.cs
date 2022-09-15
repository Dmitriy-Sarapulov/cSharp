//Двумерные массивы и рекурсия

//Задача 39 Программа переворачивает массив(первый элемент в конце, последний в начале и т.д.).

// Console.Clear();

// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));

// int[] reversArray = ReversArray2(array);
// Console.WriteLine(String.Join(" ", reversArray));

// ReversArray1(array);
// Console.WriteLine(String.Join(" ", array));

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for(int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue +1);
//     }
//     return res;
// }

// void ReversArray1(int[] inArray)
// {
//     for(int i = 0; i < inArray.Length / 2; i++)
//     {
//         int k = inArray[i];
//         inArray[i] = inArray[inArray.Length - i - 1];
//         inArray[inArray.Length - i - 1] = k;
//     }
// }

// int[] ReversArray2(int[] inArray)
// {
//     int[] result = new int[inArray.Length];
//     for(int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[inArray.Length - 1 - i];
//     }
//     return result;
// }

//Задача 40 Программа, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите третье число: ");
// int num3 = int.Parse(Console.ReadLine()!);

// if(num1 < num2 + num3 && num2 < num1 + num3 && num3 < num2 + num1)
// {
//     Console.WriteLine("Будет существовать");
// }

// else
// {
//     Console.WriteLine("не будет");
// }
//Задача 42 Напишите программу, которая будет преобразовывать деситичное число в двоичное.
// Console.Write("Введите число");
// double num = double.Parse(Console.ReadLine()!);

// double[] array = new double[9];
// array[0] = num;

// for(int i = 0; i < array.Length; i++)
// {
//     if(num >= 1)
//     {
//     array[i] = num/2;
//     Console.Write(num + ", ");
//     num = num/2;
//     }
//     else
//     {
//         array[i] = 0;
//     }
// }
// int [] array1 = new int[100];
//     for(int i = 0; i <array1.Length; i++)
//     {
//         if(array[i] % 2 ==0)
//         {
//             array1[i] = 0;
//         }
//         else
//         {
//             array1[i] = 1;
//         }
//         Console.Write($"[{String.Join(", ", array1)}]");        
//     }//Не Решено

//Задача 44 Не используя рекурсию, выведите первые N числел Фибоначи. Первые 2 числа Фибоначи: 0 и 1.

//Задача 45 Напишите программу, которая будет создавать копию заданного массива 
//с помощью поэлементного копирования.