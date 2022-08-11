//Задача 10
int num = new Random().Next(100, 999);
Console.WriteLine(num);
int a = num / 10;
a = a % 10;
Console.WriteLine("Вторая цифра выбранного числа: " + a);