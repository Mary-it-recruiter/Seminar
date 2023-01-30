

// Семинар от 28 января



// string s = "Hello World";
// string s1 = "Hello";
// string s2 = "World";

// int[] nums = {1, 2, 3, 4, 5};

// string s3 = s1 + " " + s2;

// string s4 = string.Concat(s1, s2);

// string s5 = string.Join(" ", nums);
//
// string s = "1, 2, 3, 4, 5, 6, 7";

// foreach (var item in s)
// {
// Console.WriteLine(item);
// }
// Console.WriteLine(s5);

// string s = "1, 2, 3, 4, 5, 6, 7.";

// string[] nums = s.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

// int[] n = nums.Select(Int32.Parse).ToArray();

// foreach (var item in nums)
// {
//     Console.WriteLine(item);
// }

// string s1 = "10 21 35 45 57 68 79";
// int[] num1 = Array.ConvertAll(s1.Split(), int.Parse);


// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] num = new int[12];
// for (int i = 0; i < num.Length; i++)
// {
//     num[i] = new Random().Next(-9, 10);
//     Console.Write($"{num[i]} ");
// }
// int sumotr = 0;
// int sumpol = 0;
// for (int i = 0; i < num.Length; i++)
// {

//     if (num[i] >= 0)
//     {
//         sumpol = sumpol + num[i];

//     }
//     else
//     {
//         sumotr = sumotr + num[i];
//     }

// }

// Console.WriteLine();
// Console.WriteLine($"Сумма положительных чисел равна {sumpol}");
// Console.WriteLine($"Сумма положительных чисел равна {sumotr}");

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
// Console.Write("Введите длинну массива:  ");
// int x = Convert.ToInt32(Console.ReadLine());
// int[] num = new int[x];

// for (int i = 0; i < num.Length; i++)
//     num[i] = new Random().Next(-9, 10);

// foreach (int n in num)
// {
//     Console.Write($"{n} ");

// }
// Console.Write("   --> это изначальный массив");
// for (int i = 0; i < num.Length; i++)
//     num[i] *= (-1);
// Console.WriteLine();
// foreach (int n in num)
// {
//     Console.Write($"{n} ");
// }
// Console.Write("   --> это измененный массив");


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// int[] array = new int[10];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-99, 100);
//     Console.Write($"{array[i]} ");
// }

// Console.WriteLine();


// Console.Write("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());

// string abc = "Нет такого значения";

// for (int j = 0; j < array.Length; j++)
// {
//     if (array[j] == num)
//     {
//         abc = "Да такое число есть в массиве ";

//     }

// }
// Console.WriteLine(abc);