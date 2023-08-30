// // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Console.WriteLine("Введите количество строк в массиве ");
// int rows = Convert.ToInt32(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов в массиве ");
// int columns = Convert.ToInt32(Console.ReadLine()!);

// double [,] array = GetArray(rows, columns, 0, 1);
// PrintArray(array);
// //
// double [,] GetArray (int rows, int columns, int minValue, int maxValue){
//     double [,] result = new double[rows, columns];
//     for(int i = 0; i < rows; i++){
//         for( int j = 0; j < columns; j++){
//             result[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 100;
//         }
//     }
//     return result;
// }
//  //
// void PrintArray(double [,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Console.WriteLine("Введите номер строки ");
// int n = Convert.ToInt32(Console.ReadLine()!);

// Console.WriteLine("Введите номер столбцa ");
// int m= Convert.ToInt32(Console.ReadLine()!);

// int [,] array = new int [5,5];
// GetArray(array);

// if (n > array.GetLength(0) || m > array.GetLength(1))
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {array[n-1,m-1]}");
// }

// PrintArray(array);




// //Создание массива
// int[,] GetArray(int [,] array)
// {
//         for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0,10);
//         }
//     }
//     return array;
// }
//     //Печать массива
//     void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write($"{array[i, j]} ");
//             }
//             Console.WriteLine();
//         }
//     }
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Console.WriteLine($"Введите количество строк");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Введите количество столбцов");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// for (int j = 0; j < array.GetLength(1); j++)
// {
//     double avarage = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         avarage = avarage + array[i, j];
//     }
//     avarage = avarage / rows;
//     Console.Write(avarage + ", ");
// }
// Console.WriteLine();


// //
// int[,] GetArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] res = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             res[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return res;
// }

// //
// void PrintArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }