// Напишите цикл, который принимает на вход два числа А и В и возводит число А в натуральную степень В.
// Console.WriteLine("введите число ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число ");
// int B = Convert.ToInt32(Console.ReadLine());
// int st=1;
// Console.WriteLine($"A в степени B равна {Method(st)} ");
// int Method(int step)
// {
//     int st = A;
//     for (int i = 1; i < B; i++)
//     {
//         st = st * A;
//     }
//     return st;
// }


// // //Напишите программу которая принимает число и выдает сумму чисел в числе
// Console.Write("Введите число: ");
//   int n = Convert.ToInt32(Console.ReadLine());
//   int sum = 0;
//   while (n != 0) {
//    sum += n % 10;
//    n /= 10;
//   }
//   Console.WriteLine($"Сумма цифр числа равна  {sum}");

  // Напишите программу,которая выдает массив из 8 элементов и выводит его на экран
int [] array = GetRange(8);
Console.WriteLine($"[{String.Join(" ", array)}]");
 

 int [] GetRange(int size){
    int [] massive = new int [size];
    for(int i = 0; i < size ; i++){
        massive[i]=new Random().Next(0,80);
    }
    return massive;
 }


