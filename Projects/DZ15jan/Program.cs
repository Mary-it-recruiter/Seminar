// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int a = new Random().Next(100, 1000);
// Console.WriteLine(a);
// Console.Write($"Наш результат равен = {(a / 10) % 10}");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите число от 1 до 7 = ");
// int number = Convert.ToInt32(Console.ReadLine());

// if ((number >= 1) && (number <= 5))
// {
//     Console.Write("Будний день,работаем");
// }
// else if ((number >= 6) && (number <= 7))
// {
//     Console.Write("Выходной");
// }
// else
// {
//     Console.Write("Введите число от 1 до 7");
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number >= 100 && number <= 999)

// {
//     Console.Write($"Третья цифра: {number % 10} ");
// }

// else if (number < 100)
// {
//     Console.Write("Третьей цифры нет");
// }

// else
// {

//     Console.Write($"Третья цифра: {(number / 10) % 10} ");
// }


Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
    Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}
