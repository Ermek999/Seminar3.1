/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
(Проверка выхода за пределы значений недели, т.е. < 1 и > 7)*/
Console.WriteLine("Введите цифру : ");
int number = int.Parse((Console.ReadLine()));

if (number == 1 ) Console.WriteLine ("Понедельник");
if (number == 2 ) Console.WriteLine ("Вторник");
if (number == 3 ) Console.WriteLine ("Среда");
if (number == 4 ) Console.WriteLine ("Четверг");
if (number == 5 ) Console.WriteLine ("Пятница");
if (number == 6 ) Console.WriteLine ("Суббота");
if (number == 7 ) Console.WriteLine ("Воскресенье");
else if(number<1 || number>7) Console.WriteLine("День недели не существует ");
if (number==6 || number==7)
{
       Console.WriteLine("является выходным");
       
}
else 
{
    Console.WriteLine("Не выходной");
}