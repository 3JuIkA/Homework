// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число");
int x1 = Convert.ToInt32(Console.ReadLine());

if (x1 == 1)
{
    Console.WriteLine("нет");
}
if(x1 == 2)
{
    Console.WriteLine("нет");
}
if(x1 == 3)
{
    Console.WriteLine("нет");
}
if(x1 == 4)
{
    Console.WriteLine("нет");
}
if(x1 == 5)
{
    Console.WriteLine("нет");
}
if(x1 == 6)
{
    Console.WriteLine("да");
}
if(x1 == 7)
{
    Console.WriteLine("да");
}
if(x1 > 8 || x1 <= -1)
{
    Console.WriteLine("Такого дня недели нет.) ");
}