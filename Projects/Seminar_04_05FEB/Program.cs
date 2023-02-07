//Семинар от 04 февраля

//  Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.WriteLine("Введите длину массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите ширину массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] num = new int[m, n];

// for (int i = 0; i < num.GetLongLength(0); i++)
// {
//     for (int j = 0; j < num.GetLongLength(1); j++)
//     {
//         num[i, j] = new Random().Next(1, 10);
//         Console.Write($"{num[i, j]}  ");          //после } и перед закрытием кавычек ставим пропуск и красивый массив
//     }
//     Console.WriteLine();
// }




// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.WriteLine("Введите длину массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите ширину массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] num = new int[m, n];

// for (int i = 0; i < num.GetLongLength(0); i++)
// {
//     for (int j = 0; j < num.GetLongLength(1); j++)
//     {
//         num[i, j] = i + j;
//         Console.Write($"{num[i, j]}  ");          //после } и перед закрытием кавычек ставим пропуск и красивый массив
//     }
//     Console.WriteLine();
// }


// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Console.WriteLine("Введите длину массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите ширину массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] num = new int[m, n];

// for (int i = 0; i < num.GetLongLength(0); i++)
// {
//     for (int j = 0; j < num.GetLongLength(1); j++)
//     {

//         num[i, j] = new Random().Next(1, 10);
//         Console.Write($"{num[i, j]}  ");          //после } и перед закрытием кавычек ставим пропуск и красивый массив
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();
// for (int i = 0; i < num.GetLongLength(0); i++)
// {
//     for (int j = 0; j < num.GetLongLength(1); j++)
//     {
//         if (i % 2 == 0 && j % 2 == 0)
//         {
//             num[i, j] = num[i, j] * num[i, j];
//             Console.Write($"{num[i, j]}  ");
//         }
//         else
//         {
//             num[i, j] = num[i, j];
//             Console.Write($"{num[i, j]}  ");

//         }
//     }
//     Console.WriteLine();
// }


// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Console.WriteLine("Введите длину массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите ширину массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] num = new int[m, n];
// int temp = 0;

// for (int i = 0; i < num.GetLongLength(0); i++)
// {
//     for (int j = 0; j < num.GetLongLength(1); j++)
//     {
//         num[i, j] = new Random().Next(1, 10);
//         Console.Write($"{num[i, j]}  ");          //после } и перед закрытием кавычек ставим пропуск и красивый массив

//         if (i == j)
//         {
//             temp = temp + num[i, j];
//         }
//     }
//     Console.WriteLine();
// }

// Console.WriteLine($"Сумма элементов главной диагонали: {temp}");

// Надо подумать, как оптимизировать 😊

// x1 ^ 5 + x2 ^ 5 + x3 ^ 5 + x4 ^ 5 = x5 ^ 5
// Сумма 4 чисел в 5 степени равна пятому числу в пятой степени
// Нужно найти эти числа

// int x1 = new Random().Next(1, 300);


//Семинар от 05 февраля
// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


// int n = 3;
// int m = 4;
// Console.WriteLine("Масив чисел: ");
// int[,] num = new int[n, m];
// for (int i = 0; i < num.GetLength(0); i++)
// {
//     for (int j = 0; j < num.GetLength(1); j++)
//     {
//         num[i, j] = new Random().Next(0, 10);
//         Console.Write($"{num[i, j]} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// int k = 0;

// for (int j = 0; j < num.GetLength(1); j++)
// {
//     int string0 = num[k, j];
//     num[k, j] = num[n - 1, j];
//     num[n - 1, j] = string0;
// }


// for (int i = 0; i < num.GetLength(0); i++)
// {
//     for (int j = 0; j < num.GetLength(1); j++)
//     {
//         Console.Write($"{num[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


// void PrintArray(int n, int m)
// {

//     int[,] array = new int[n, m];
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array[i, j] = new Random().Next(1, 6);
//                 Console.Write($"[{array[i, j]}]");
//             }
//             Console.WriteLine();
//         }

//     }
// }
// int lines = new Random().Next(2, 5);
// int columns = new Random().Next(2, 5);
// PrintArray(lines, columns);

// int[,] array = new int[lines, columns];
// if (array.GetLength(0) == array.GetLength(1))
// {
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         for (int j = 1; j < array.GetLength(1); j++)
//         {
//             if (i == array.GetLength(0))
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;
//             }
//         }
//     }
//     PrintArray(lines, columns);
// }
// Console.WriteLine("Поменять строки и столбцы невозможно");

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимум рандома: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, A);
//         Console.Write($"{array[i, j]}");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();
// int count = 0;

// while (count < A)
// {
//     int demph = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == count)
//             {
//                 demph++;
//             }
//         }
//     }
//     if (demph == 0)
//     {
//         Console.WriteLine($"Цифра {count} не встречается");
//     }
//     else
//     {
//         Console.WriteLine($"Цифра {count} повторяется {demph} раз");
//     }
//     count++;
// }


// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника