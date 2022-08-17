// Задача 19
Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString(a);
if(b.Length != 5) {
    Console.WriteLine("Введено не верное значение!");
}
else if (b[0] == b[4] && b[1] == b[3]) {
    Console.WriteLine("Данное число является палиндромом");
}
else {
    Console.WriteLine("Данное число не является палиндромом");
}