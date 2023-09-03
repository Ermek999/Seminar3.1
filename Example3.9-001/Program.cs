//Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// Console.WriteLine("Введите число ");
// int numbers = int.Parse(Console.ReadLine()!);
// Console.WriteLine(Ansver(numbers, 1));

// string Ansver(int A, int B)
// {  
//     if(A == 1) return A.ToString();
//     return (A + " , " + Ansver(A - 1, B)); 
// }

// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// Console.WriteLine("Введите число ");
// int m = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите число ");
// int n = int.Parse(Console.ReadLine()!);

// Console.WriteLine(STemp(m,n));
// int STemp( int m, int n)
// {   
//         if(m == n) return n;
//     return(m + STemp(m + 1,n));
// }
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Akkerman(m,n));

// // функция Аккермана
// int Akkerman( int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }