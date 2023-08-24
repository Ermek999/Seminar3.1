/*Console.WriteLine("Введите значение первой точки");
int ax = int.Parse(Console.ReadLine());
int ay = int.Parse(Console.ReadLine());
int az = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение второй точки");
int bx = int.Parse(Console.ReadLine());
int by = int.Parse(Console.ReadLine());
int bz = int.Parse(Console.ReadLine());


double abc = Math.Sqrt(Math.Pow((ax-bx),2) + Math.Pow((ay-by),2) + Math.Pow((az-bz),2));
Console.WriteLine($"{abc:f2}");*/

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/
/*Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
int i = 1; 
while (i<=num)
{ 
    Console.Write($"{i*i*i} ");
    i++;
}*/

/*Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом(первое == последнему, второе == предпоследнему).*/

 Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"{number} - не является пятизначным");
}


