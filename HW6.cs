// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

int Func(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void Check(int number)
{
    if(number > 0)
    {
        int[]oneArray = InputArray(number);
        PrintArray(oneArray);
        Console.WriteLine($"Количество положительных чисел равно {PlusNumbers(oneArray)}");
    }
    else
    {
        Console.WriteLine("Количество не может быть отрицательным или равным нулю");
    }
}

int[] InputArray(int number)
{
    int[] oneArray = new int[number];
    int i = 0;
    while (i < number)
    {
        Console.Write("Введите число: ");
        oneArray[i] = int.Parse(Console.ReadLine());
        i++;
    }
    return oneArray;
}

int PlusNumbers(int[]oneArray)
{
    int count = 0;
    for(int i = 0; i < oneArray.Length; i ++)
    {
        if(oneArray[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] oneArray)
{
    for(int i = 0; i < oneArray.Length; i++)
    {
        Console.Write($"{oneArray[i]} ");
    }
}

int number = Func("Выберите количество чисел ");
Check(number);
