//Задача 10
// int num = new Random().Next(100, 999);
// Console.WriteLine(num);
// int a = num / 10;
// a = a % 10;
// Console.WriteLine("Вторая цифра выбранного числа: " + a);

//Задача 15
Console.Write("Введите номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 1 && a <= 5) {
    Console.WriteLine("Этот день не является выходным");
}
else if (a == 6 | a == 7) {
    Console.WriteLine("Этот день является выходным");
}
else {
    Console.WriteLine("Введено не верное число");
}