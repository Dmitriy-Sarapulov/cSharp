//ДЗ 5

// Задача 34

// Console.Write("Введите размер массива: ");
// int a = Convert.ToInt32(Console.ReadLine());

// int[] arr = new int[a];
// Random rand = new Random();
// for(int i = 0; i < arr.Length; i++) {
//     arr[i] = rand.Next(100, 1000);
//     Console.Write(arr[i] + " ");
// }
// int chet = 0;
// for(int i = 0; i < arr.Length; i++) {
//     if(arr[i] % 2 == 0) {
//         chet = chet + 1;
//     }
    
// }
// Console.Write(chet);

//Задача 36

// Console.Write("Введите размер массива: ");
// int a = Convert.ToInt32(Console.ReadLine());

// int[] arr = new int[a];
// Random rand = new Random();
// for(int i = 0; i < arr.Length; i++) {
//     arr[i] = rand.Next(0, 99);
//     Console.Write(arr[i] + " ");
    
// }
// Console.WriteLine();
// int chet = 0;
// for(int i = 0; i < arr.Length; i++) {
//     if(i % 2 == 0) {
//         chet = chet + arr[i];
//     }
// }
// Console.WriteLine(chet);

//Задача 38
// Console.Write("Введите размер массива: ");
// int a = Convert.ToInt32(Console.ReadLine());

// double[] arr = new double[a];
// Random rand = new Random();
// for(int i = 0; i < arr.Length; i++) {
//     arr[i] = rand.Next(0, 100);
//     Console.Write(arr[i] + " ");
// }
// Console.WriteLine();
// double min = arr[0];
// double max = arr[0];
// for(int i = 0; i < arr.Length; i++){
//     if(min > arr[i]) {
//         min = arr[i];
//     }
//     if(max < arr[i]) {
//         max = arr[i];
//     }
// }
// Console.WriteLine(max-min);