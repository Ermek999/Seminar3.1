﻿// нАПИШИТЕ ПРОГРАММУ, КОТОРАЯ НА ВХОД ПРИНИМАЕТ ДВА ЧИСЛА И ВЫДАЕТ,какое число большее, ам какоее меньшее

Console.Write("Введите первое число ");
int num1 = int.Parse((Console.ReadLine()));
Console.Write("Введите второе число ");
int num2 = int.Parse((Console.ReadLine()));



if (num1>num2)
{

    Console.WriteLine($"число {num1} больше чем число {num2}");
}
else if (num1<num2)
{
    Console.WriteLine($"число {num1} меньше чем число {num2}");
}

else
{

    Console.WriteLine($"число {num1} и {num2} равны");
}


