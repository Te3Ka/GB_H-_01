﻿/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите одно целое положительное число");
Console.Write("Число = ");
int N = Int32.Parse(Console.ReadLine());

if (N > 1)
{
    for (int i = 2; i <= N; i += 2)
    {
        if ((i > (N - 2)))
            Console.Write(i);
        else
            Console.Write(i + ", ");
    }
}
else
    Console.WriteLine("Простите, но введено число меньше 2. Невозможно вывести целые положительные числа больше 1.");