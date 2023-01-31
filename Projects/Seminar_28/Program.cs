

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


//Семинар от 29 января
// int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// foreach (var item in nums)
// {
//     Console.WriteLine(item);
// }

// int[,] nums2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 0, 4, 2 } };

// // int[,] nums3 = new int[4, 3];
// // foreach (var item in nums2)
// // {
// //     Console.WriteLine(item);
// // }
// for (int i = 0; i < nums2.GetLength(0); i++)
// {
//     Console.WriteLine(nums2[i, 0]);
// }

// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// foreach (var item in a.Reverse())
// {
//     Console.Write($"{item} ");
// }

// Второй способ:

// int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// int temp;
// int j = nums.Length - 1;
// for (int i = 0; i < nums.Length / 2; i++)
// {
//     temp = nums[j];
//     nums[j] = nums[i];
//     nums[i] = temp;
//     j = j - 1;
// }

// foreach (var item in nums)
// {
//     Console.Write($"{item} ");
// }



// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

// bool FindTriangle(int a, int b, int c)
// {
//     if (a < b + c && b < a + c && c < a + b)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
// Console.Write("Введите длинну первой стороны треугольника: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите длинну второй стороны треугольника: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите длинну третьей стороны треугольника: ");
// int z = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindTriangle(x, y, z));

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.WriteLine("Введите число: ");
// string A = Console.ReadLine();
// int from = 10;
// int to = 2;

// string binary = Convert.ToString(Convert.ToInt32(A, from), to);
// Console.WriteLine(binary);

// Второе рещение:
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string result = "";
while (num > 0)
{
    result = Convert.ToString(num % 2) + result;
    num = num / 2;
}
Console.WriteLine(result);


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.