// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Console.WriteLine("Введите положительное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int m = 1;

// int NaturalNumber(int n, int m)
// {
//     if (n == m)
//         return n;
//     else
//         Console.Write($"{NaturalNumber(n, m + 1)}, ");
//     return m;
// }

// Console.Write($"{NaturalNumber(n, m)} ");

// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите положительное число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите положительное число N: ");
// int N = Convert.ToInt32(Console.ReadLine());


// int InputInt(int M, int N)
// {
//     if (M == N)
//         return N;
//     else

//         return N + InputInt(M, N - 1);
// }

// Console.Write($"Сумма натуральных элементов в промежутке от {M} до {N} : {InputInt(M, N)}");



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29 


// Console.WriteLine("Введите положительное число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите положительное число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int AkkermanFunc(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     if (m > 0 && n == 0)
//     {
//         return AkkermanFunc(m - 1, 1);
//     }
//     return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
// }

// Console.WriteLine(AkkermanFunc(m, n));
