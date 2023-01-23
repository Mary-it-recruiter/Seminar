// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
// Console.WriteLine("Введите пятизначное число: ");
// int[] n = Convert.ToInt32(Console.ReadLine());

// if (n.Length > 4)
// {
//     Console.WriteLine("Введите пятизначное число!");
// }
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
void palindrom()
{
    int num1 = number / 10000 % 10;
    int num2 = number / 1000 % 10;
    int rev1 = number / 10 % 10;
    int rev2 = number % 10;
    int nul = number / 10000;
    if (nul < 1 || nul > 9)
    {
        Console.WriteLine(number + " -> " + "Не пятизначное число");
    }
    else if (num1 == rev2 && num2 == rev1)
    {
        Console.WriteLine(number + " -> Да, число палиндром");
    }
    else
    {
        Console.WriteLine(number + " -> Нет, число не палиндром");
    }
}
for (int i = 0; i < 10; i++)
{
    palindrom();
}
// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");
// int Coordinate(string a, string b)
// {
//     Console.Write($"Введите координату {a} точки {b}: ");
//     return Convert.ToInt16(Console.ReadLine());
// }
// double Decision(double x1, double x2,
//                 double y1, double y2,
//                 double z1, double z2)
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) +
//                      Math.Pow((y2 - y1), 2) +
//                      Math.Pow((z2 - z1), 2));
// }
// double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);
// Console.WriteLine($"Длина отрезка  {segmentLength}"); ;//Math.Round - округление до трех знаков

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Console.WriteLine("Введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i <= n; i++)
// {
//     Console.WriteLine(Math.Pow(i, 3));
// }
