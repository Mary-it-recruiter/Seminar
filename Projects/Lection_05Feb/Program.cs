// //Обходим дирикторию

// string path = "C:/Users/mivanova/Desktop/Гикбрейнс Иванова М/Csharp projects/Projects/Lection_05Feb"; // обязательно слэш в сторону /
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);

// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }




//Опишем рекурсию, метод CatalogInfo, где принимаем аргументы: путь к текущей папке и второй аргумент отступы(для обхода дериктории)

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);

//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + "  ");
//     }
//     FileInfo[] files = catalog.GetFiles();
//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");
//     }
// }
// string path = "C:/Users/mivanova/Desktop/Гикбрейнс Иванова М/Csharp projects/Projects";
// CatalogInfo(path);

//Задача со шпилями и переставлеием(кружочки разных размеров) для пирамидок(count = 3, если три блина)

// void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with}>>{on}");
//     if (count > 1) Towers(with, some, on, count - 1);
// }

// Towers();


//Задача на обход полного уравнения ((4-2) * (1+3)) / 10

// string emp = String.Empty;
// string[] tree = { emp, "/", "*", "10", " - ", " + ", emp, emp, "4", "2", "1", "3" };
// //                 0    1    2   3     4      5    6   7   8   9   10   11

// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int right = 2 * pos + 1;
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         Console.WriteLine(tree[pos]);
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }
// InOrderTraversal();


//Задача на Фибоначчи и скоровть работы с рекурсией
// decimal fREC = 0;
// decimal fIte = 0;
// decimal FibonacciRecursion(int n)
// {
//     fREC++;
//     return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
// }

// decimal FibonacciIteration(int n)
// {
//     fIte++;
//     decimal result = 1;
//     decimal f0 = 1;
//     decimal f1 = 1;
//     for (int i = 2; i <= n; i++)
//     {
//         result = f0 + f1;

//         f0 = f1;
//         f1 = result;
//         fIte++;
//     }
//     return result;
// }

// //# 1 2 3 4 5 6 
// //V 1 1 2 3 5 8



// Console.ReadLine();

// DateTime dt = DateTime.Now;
// for (int n = 10; n < 40; n++)
// {
//     Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"),-15} ");
//     fIte = 0;
// }
// Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

// Console.WriteLine();
// Console.ReadLine();

// DateTime st = DateTime.Now;

// for (int n = 10; n < 40; n++)
// {
//     Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fREC.ToString("### ### ###"),-15}");
//     fREC = 0;
// }
// Console.ReadLine();
// Console.WriteLine((DateTime.Now - st).TotalMilliseconds);

//Переполнение стека
// void Rec()
// {
//     Rec();
// }
// Rec();  // и при вызоые dotnet run: PS C:\Users\mivanova\Desktop\Гикбрейнс Иванова М\Csharp projects\Projects\Lection_05Feb> dotnet run
// Stack overflow.

// int i = 0;
// void Rec()
// {
//     System.Console.WriteLine(i++);
//     Rec();

// }
// Rec();


//Лекция от 06 февраля. Задача с треугольников Паскаля

// int row = 5;
// int[,] triangle = new int[row, row];
// const int cellWidth = 3;

// void FillTriangle()
// {
//     for (int i = 0; i < row; i++)
//     {
//         triangle[i, 0] = 1;
//         triangle[i, i] = 1;
//     }

//     for (int i = 2; i < row; i++)
//     {
//         for (int j = 1; j <= i; j++)
//         {
//             triangle[i, j] =
//             triangle[i - 1, j - 1] + triangle[i - 1, j];
//         }
//     }
// }


// void PrintTriangle()
// {
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < row; j++)
//         {
//             if (triangle[i, j] != 0)
//                 Console.Write($"{triangle[i, j],cellWidth}");
//         }
//         Console.WriteLine();
//     }
// }

// void Magic()
// {
//     int col = cellWidth * row;
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j <= i; j++)
//         {
//             Console.SetCursorPosition(col, i + 1);
//             // if (triangle[i, j] != 0) Console.Write($"{triangle}");
//             if (triangle[i, j] != 0) Console.Write("*");
//             col += cellWidth * 2;
//         }
//         col = cellWidth * row - cellWidth * (i + 1);
//     }
// }

// Console.ReadLine();
// FillTriangle();
// PrintTriangle();
// Console.ReadLine();
// Magic();
