// int a;
// for (int i = 0; i < 10; i++)
// {
//     a = new Random().Next(-110, 3);
//     Console.WriteLine(a);
// }

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int a = new Random().Next(10, 100);
// Console.WriteLine(a);
// // Console.WriteLine(a / 10);
// // Console.WriteLine(a % 10);
// if ((a / 10) > (a % 10))
// {
//     Console.WriteLine(a / 10);
// }
// else
// {
//     Console.WriteLine(a % 10);
// }

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int a = new Random().Next(100, 1000);
// Console.WriteLine(a);
// Console.Write($"Наш результат равен = {a / 100}");
// Console.WriteLine(a % 10);


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите число a = ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b = ");
int second = Convert.ToInt32(Console.ReadLine());

if (first % second == 0)
{
    Console.Write($"{first},{second} - кратно");
}
else
{
    Console.Write($"{first},{second} - некратно, остаток {first % second}");
}

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да