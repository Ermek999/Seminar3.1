/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
(Если решаете математически максимум берем 100000)*/
int num = new Random().Next(100000);
string NumStr = num.ToString();

if(NumStr.Length == 5){
    Console.WriteLine($"В числе {num} третья цифра равнa {NumStr[2]}");
    }
    else{
        Console.WriteLine($"Третьей цифры нет");
    }