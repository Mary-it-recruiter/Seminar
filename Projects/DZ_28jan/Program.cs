// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] num = new int[12];
// for (int i = 0; i < num.Length; i++)
// {
//     num[i] = new Random().Next(100, 1000);
//     Console.Write($"{num[i]} ");
// }
// int count = 0;
// for (int i = 0; i < num.Length; i++)
// {

//     if (num[i] % 2 == 0)
//     {
//         count++;
//     }

// }
// Console.WriteLine();
// Console.WriteLine($"Количество чётных чисел в массиве {count}");





// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
// int[] num = new int[10];
// for (int i = 0; i < num.Length; i++)
// {
//     num[i] = new Random().Next(1, 15);
//     Console.Write($"{num[i]} ");
// }

// int sumcmount = 0;
// for (int i = 0; i < num.Length; i++)
// {

//     if (num[i] % 2 != 0)
//     {

//         sumcmount = sumcmount + num[i];

//     }

// }
// Console.WriteLine();
// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {sumcmount}");




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int x = new Random().Next(1, 10);
int[] num = new int[x];
Console.Write("[ ");
for (int i = 0; i < num.Length; i++)
{
    int a = new Random().Next(10, 999);
    num[i] = a;
    Console.Write($"{num[i]} ");
}

int min = num.Min();
int max = num.Max();

Console.Write($"] -> Разница между максимальным и минимальным элементов массива {max - min}");
