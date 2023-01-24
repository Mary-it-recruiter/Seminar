// string f1 = "Anna";
// string f2 = "Bob";
// string f3 = "Alex";
// string f4 = "Ira";
// string f5 = "Mila";

// // string[] f; //создала массив пустой

// string[] f = { f1, f2, f3, "Jhon", f5 };//заполнила массив

// //int[] num;
// //int[] num = new int[5];
// int[] num = { 1, 2, 3, 4, 5 };

// Console.WriteLine(f[4]);//вывели нужный элемент массива
// f[4] = "Roman";//переприсвоили
// Console.WriteLine(f[4]);//вывели переприсвоенный элемент массива
// Console.WriteLine(f.Length);//вывели длинну массива

// for (int i = 0; i < f.Length; i++)
// {
//     Console.WriteLine(f[i]);
// }//вывели все элементы массива

// //Цикл форич:
// foreach (int n in num)
// {
//     Console.WriteLine(n);
// }

// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Write("Введите первую координату: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите вторую координату: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x == 0 || y == 0)
// {
//     Console.Write("Невозможно");
// }
// else if (x > 0 && y > 0)
// {
//     Console.Write("Первая четверть");
// }
// else if (x < 0 && y < 0)
// {
//     Console.Write("Третья четверть");
// }

// else if (x < 0 && y > 0)
// {
//     Console.Write("Четвертая четверть");
// }
// if (x > 0 && y < 0)
// {
//     Console.Write("Вторая четверть");
// }

// Задача №18.Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.Write("Введите номер четверти от 1 до 4: ");
// int x = Convert.ToInt32(Console.ReadLine());

// if (x == 1)
// {
//     Console.Write("В первой четверти x принимает положительные значения от 0 до бесконечноcти, y принимает положительные значения от 0 до бесконечноcти");
// }
// else if (x == 2)
// {
//     Console.Write("Во второй четверти x принимает положительные значения от 0 до бесконечноcти, y принимает  отрицательные значения от 0 до минус бесконечности");
// }
// else if (x == 3)
// {
//     Console.Write("В третьей четверти x принимает отрицательные значения от 0 до минус бесконечноcти, y принимает отрицательные значения от 0 до минус бесконечности");
// }
// else if (x == 4)
// {
//     Console.Write("В четвертой четверти x принимает отрицательные значения от 0 до минус бесконечноcти, y принимает положительные значения от 0 до бесконечноcти");
// }

// else
//     Console.Write("Введите от 1 до 4!");


// Задача 21) Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.AB = √(xb - xa)2 + (yb - ya)2
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите x первой точки");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y первой точки");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите x второй точки");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y второй точки");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double distance2D = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
// Console.WriteLine($"{Math.Round(distance2D, 3)}");//Math.Round - округление до трех знаков


//а можно и так:
// int a = x1 - x2;
// int b = y1 - y2;

// int c = a * a;
// int d = b * b;
// int i = c + d;

// Console.WriteLine(Math.Sqrt(i));

// Задача 22)Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i <= n; i++)
// {
//     Console.WriteLine(Math.Pow(i, 2));
// }


//Семинар от 22 января

// 24) Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());

// int Sum(int A)
// {
//     // int count = A;
//     int sum = 0;
//     for (int i = 0; i <= A; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }

// Console.WriteLine($"Сумма чисел от 1 до А -> {Sum(A)}");

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int Count(int number)
// {
//     int count = 0;
//     if (number == 0)
//     {
//         count = 1;
//     }

//     while (number != 0)
//     {
//         number = number / 10;
//         count = count + 1;
//     }
//     return count;
// }


// int x = Count(number);
// Console.WriteLine(x);



// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
// Console.WriteLine("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());

// int Sum(int A)
// {
//     int sum = 1;
//     for (int i = 1; i <= A; i++)
//     {
//         sum = sum * i;
//     }
//     return sum;
// }

// int x = Sum(A);
// Console.WriteLine(x);




// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];

// Console.WriteLine($"Длинна массива ={array.Length}");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 2);
//     Console.Write($"{array[i]} ");
// }



