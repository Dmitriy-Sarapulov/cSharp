//Функции продолжение
//Программа принимает на вход число А и выдает сумму чисел от 1 до А.
// int GetSumNums(int number) {
//     int sum = 0;
//     for(int i = 1;i <= number; i++) {
//         sum += i;
//     }
//     return sum;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");

//Программа которая принимает на вход число и выдает количество цифр в числе.

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int index = 0;
// if(num == 0)
// {
//     Console.Write("1");
// } else {

//     while(num != 0) {
//         num = num / 10;
//         index++;
//     }
//     Console.WriteLine(index);
// }

// Программа которая принимает на вход число N и выдает произведение чисел от 1 до N

// int GetSumNums(int number) {
//     int sum = 1;
//     for(int i = 1;i <= number; i++) {
//         sum *= i;
//     }
//     return sum;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");

// Программа которая выводит массив из 8 элементов,заполненный нулями и единицами в случайном порядке.

// int[] arr = new int[8];
// Random rnd = new Random();

//  for(int i = 0; i < arr.Length; i++) {
//     arr[i] = rnd.Next(0,2);
//     Console.Write(arr[i] + " ");
//  }


