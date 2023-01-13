/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите два целых числа через Enter");
Console.Write("Число 1 = ");
int a = Int32.Parse(Console.ReadLine());
Console.Write("Число 2 = ");
int b = Int32.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("max = " + a + ", min = " + b);
}
else if (a < b)
{
    Console.WriteLine("max = " + b + ", min = " + a);
} if (a == b)
{
    Console.WriteLine("Введены одинаковые числа = " + a);
}