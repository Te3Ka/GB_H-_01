﻿/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Программа показывает максимальное число из трёх целых чисел");

Console.WriteLine("Введите три целых числа через Enter");
Console.Write("Число 1 = ");
int num1 = Int32.Parse(Console.ReadLine());
Console.Write("Число 2 = ");
int num2 = Int32.Parse(Console.ReadLine());
Console.Write("Число 3 = ");
int num3 = Int32.Parse(Console.ReadLine());

int max = num1;

if (num2 > max)
    max = num2;
if (num3 > max)
    max = num3;

Console.WriteLine("Максимальное число = " + max);