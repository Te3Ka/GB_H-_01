﻿/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите одно целое число");
Console.Write("Число = ");
int num = Int32.Parse(Console.ReadLine());

if (num % 2 == 0)
    Console.WriteLine("Введённое число - чётное");
else
    Console.WriteLine("Введённое число - нечётное");