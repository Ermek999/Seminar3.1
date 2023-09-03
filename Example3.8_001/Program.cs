// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Console.WriteLine($"Введите количество строк");
// int m = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Введите количество столбцов");
// int n = int.Parse(Console.ReadLine()!);

// int[,] matrix = GetArray(m, n, 0, 10);
// PrintArray(matrix);

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1) - 1; j++)
//     {
//         for (int z = 0; z < matrix.GetLength(1) - 1; z++)
//         {
//             if (matrix[i, z] < matrix[i, z + 1]) 
//             {
//                 int temp = 0;
//                 temp = matrix[i, z];
//                 matrix[i, z] = matrix[i, z + 1];
//                 matrix[i, z + 1] = temp;
//             }
//         }
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Массив с упорядоченными значениями");
// PrintArray(matrix);


// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue +1);
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Console.WriteLine($"Введите количество строк");
// int m = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Введите количество столбцов");
// int n = int.Parse(Console.ReadLine()!);

// int[,] matrix = GetArray(m, n, 0, 10);
// PrintArray(matrix);





// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// //
// int SumLine(int[,] array, int i)
// {
//     int sum = array[i, 0];
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         sum += array[i, j];
//     }
//     return sum;
// }

// int minSum = 1;
// int sum = SumLine(matrix, 0);
// for (int i = 1; i < matrix.GetLength(0); i++)
// {
//     if (sum > SumLine(matrix, i))
//     {
//         sum = SumLine(matrix, i);
//         minSum = i + 1;
//     }
// }
// Console.WriteLine($"Строка c наименьшей суммой элементов: { minSum}");

// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Console.WriteLine($"Введите количество строк 1 матрицы");
// int m = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Введите количество столбцов 1 матрицы");
// int n = int.Parse(Console.ReadLine()!);

// int[,] matrix = GetArray(m, n, 0, 10);
// PrintArray(matrix);

// Console.WriteLine($"Введите количество строк 1 матрицы");
// int k = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Введите количество столбцов 1 матрицы");
// int l = int.Parse(Console.ReadLine()!);

// int[,] matrix2 = GetArray(m, n, 0, 10);
// PrintArray(matrix2);
// int[,] resultArray = new int[i,j];

// if (matrix.GetLength(0) != matrix2.GetLength(1))
// {
//     Console.WriteLine(" Нельзя перемножить ");
//     return;
// }
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix2.GetLength(1); j++)
//     {
//         resultArray[i, j] = 0;
//         for (int k = 0; k < matrix.GetLength(1); k++)
//         {
//             resultArray[i, j] += matrix[i, k] * matrix2[k, j];
//         }
//     }
// }



// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue +1);
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] GetArray2(int k, int l, int minValue, int maxValue)
// {
//     int[,] matrix = new int[k, l];
//     for (int i = 0; i < k; i++)
//     {
//         for (int j = 0; j < l; j++)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue +1);
//         }
//     }
//     return matrix;
// }

// void PrintArray2(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] array3D = new int[2, 2, 2];
GetArray(array3D);
PrintArray(array3D);


// Функция вывода индекса элементов 3D массива
void PrintArray(int[,,] arr)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

// Функция заполнения 3D массива не повторяющимеся числами
void GetArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}