// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Console.WriteLine("Введите длину массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите ширину массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] num = new double[m, n];

// for (int i = 0; i < num.GetLongLength(0); i++)
// {
//     for (int j = 0; j < num.GetLongLength(1); j++)
//     {
//         num[i, j] = Math.Round(new Random().NextDouble(), 1) + new Random().Next(-10, 10);
//         Console.Write($"{num[i, j]}  ");          //после } и перед закрытием кавычек ставим пропуск и красивый массив
//     }
//     Console.WriteLine();
// }



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17->такого числа в массиве нет


// Console.WriteLine("Введите длинну массива");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите ширину массива");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = Convert.ToInt32(new Random().Next(0, 10));
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }


// Console.WriteLine("Введите координаты оси массива x");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты оси массива y");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > m && b > n)
//     Console.WriteLine("такого числа нет");
// else
// {

//     Console.WriteLine($"Число на позиции существует");
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Console.WriteLine("Введите длину массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите ширину массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] num = new double[m, n];


// for (int i = 0; i < num.GetLongLength(0); i++)
// {
//     for (int j = 0; j < num.GetLongLength(1); j++)
//     {
//         num[i, j] = Math.Round(new Random().NextDouble(), 1);
//         Console.Write($"{num[i, j]}  ");
//     }
//     Console.WriteLine();
// }
// double sum = 0;
// for (int i = 0; i <= n - 1; i++)
// {
//     sum = (num[i, 0] + sum);

//     {
//         Console.WriteLine($"Среднее арифметическое каждого столбца {sum / n}");
//     }

// }



// Надо подумать, как оптимизировать 😊

// x1 ^ 5 + x2 ^ 5 + x3 ^ 5 + x4 ^ 5 = x5 ^ 5
// Сумма 4 чисел в 5 степени равна пятому числу в пятой степени
// Нужно найти эти числа

// int x1 = new Random().Next(1, 300);
// Надо подумать, как оптимизировать 😊
