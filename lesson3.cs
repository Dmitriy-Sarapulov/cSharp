//Функции и массивы второй семинар

Console.WriteLine ("Введите координату х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) {
    Console.WriteLine("Первая четверть");
}
else if (x < 0 && y > 0) {
    Console.WriteLine("Вторая четверть");
}
else if (x < 0 && y < 0) {
    Console.WriteLine("Третья четверть");
}
else if (x > 0 && y < 0) {
    Console.WriteLine("Четвертая четверть");
}
else {
    Console.WriteLine("Невозможно определить четверть");
}
