// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2
// int [] array = GetArray(4, 100, 1000);
// Console.WriteLine($"[{String.Join(" , ", array)}]");
// int count = 0;
// for(int i = 0; i < array.Length; i++){
//    if(array[i]%2 == 0){
//     count = count + 1;
//     }
// }       
// Console.WriteLine($"Количество четных чисел в массиве равно: {count} ");
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++) 
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] array = GetArray(4, 100, 1000);
// Console.WriteLine($"[{String.Join(" , ", array)}]");
// int sum = 0;
// for(int i = 0; i < array.Length; i = i + 2){
    
//     sum = sum + array[i];
    
// }
// Console.WriteLine(sum);
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++) 
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }
// Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 4, 1, 77, 65] => 77 - 1 = 76

// int [] array = GetArray(4, 100, 1000);
// Console.WriteLine($"[{String.Join(" , ", array)}]");
// int max = 0;
// int min = 0;
// for (int i = 0; i < array.Length; i++){
//     if(array[i] > max){
//         max = array[i];
//     }
//     if(array[i] < min){
//         min = array[i];
//     }
// }

// Console.WriteLine($"Разница между максимальным и минимальным равна : ({max - min})");
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++) 
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }