// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine("Введите A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите B: ");
// int B = Convert.ToInt32(Console.ReadLine());

// int Exponentiation(int A, int B)
// {
//     int result = 1;
//     for (int i = 1; i <= B; i++)
//     {
//         result = result * A;
//     }

//     return result;
// }

// int x = Exponentiation(A, B);
// Console.WriteLine(x);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumNumber(int number)
// {

//     int count = Convert.ToString(number).Length;
//     int advance = 0;
//     int result = 0;

//     for (int i = 0; i < count; i++)
//     {
//         advance = number - number % 10;
//         result = result + (number - advance);
//         number = number / 10;
//     }
//     return result;
// }

// int sumNumber = SumNumber(number);
// Console.WriteLine("Сумма цифр в числе: " + sumNumber);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// Console.WriteLine("Введите количество цифр в рандомном массиве: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[x];


// Console.WriteLine($"Длинна массива ={array.Length}");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 10);
//     Console.Write($"[ {array[i]} ] ");
// }

