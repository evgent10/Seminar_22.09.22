//           Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет     12821 -> да     23432 -> да

// Console.WriteLine("Введите число");  // 12321
// string n = Console.ReadLine()!;
// System.Boolean result = true;
//     for (int i = 0; i < (n.Length - 1) / 2; i++)
//     if (n[i] != n[n.Length - i - 1])
//     {
//         result = false;
//     }    
//     if (result)
//     {
//         Console.WriteLine("Палиндром");
//         return;
//     }
//     else 
//     {
//         Console.WriteLine("Не палиндром");
//         return;
//     }

 
    



//           Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве. 
// AB = √(xb - xa)**2 + (yb - ya)**2 + (zb - za)**2
// A (3,6,8); B (2,1,-7), -> 15.84       A (7,-5, 0); B (1,-1,9) -> 11.53
// Console.WriteLine("Введите координаты х1");
// int x1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координаты y1");
// int y1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координаты z1");
// int z1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координаты х2");
// int x2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координаты y2");
// int y2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координаты z2");
// int z2 = int.Parse(Console.ReadLine()!);
// double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.WriteLine($"Расстояние между двумя точками равно {dist:f2}");




//          Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27       5 -> 1, 8, 27, 64, 125
// Console.Write("Введите N: ");
// int number = int.Parse(Console.ReadLine()!);

// for (int index = 1; index <= number; index++)
// {
//   double result = Math.Pow(index,3);
//   Console.Write($"{result} "); 
// }



















//Напиши программу, которая по заданому номеру четверти показывает дапазон возможных
//координат точек в этой четверти (х и у)
// Console.WriteLine("Введите четверть: ");
// int number = int.Parse(Console.ReadLine()!);

// switch(number)
// {
//     case 1:
//     {
//         Console.WriteLine("Диапазон возможных четвертей x > 0, y > 0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("Диапазон возможных четвертей x < 0, y > 0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("Диапазон возможных четвертей x < 0, y < 0");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("Диапазон возможных четвертей x > 0, y < 0");
//         break;
//     }
//     default:
//     {
//         Console.WriteLine("Такой четверти нет, глаза разуй!");
//         break;
//     }

// }





//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// Console.WriteLine("Введите координаты х");
// int x = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координаты y");
// int y = int.Parse(Console.ReadLine()!);
// if ((x > 0) && (y > 0))
// {
//     Console.WriteLine("Точка находится в первой четверти");
// }
// if ((x < 0) && (y > 0))
// {
//     Console.WriteLine("Точка находится во второй четверти");
// }
// if ((x < 0) && (y < 0))
// {
//     Console.WriteLine("Точка находится в третей четверти");
// }
// if ((x > 0) && (y < 0))
// {
//     Console.WriteLine("Точка находится в четвёртой четверти");
// }
// else
// {
//     Console.WriteLine("Точка находится в нулевой позиции");
// }




// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите координаты х1");
// int x1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координаты y1");
// int y1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координаты х2");
// int x2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координаты y2");
// int y2 = int.Parse(Console.ReadLine()!);
// double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
// Console.WriteLine($"Расстояние между двумя точками равно {dist:f3}");





// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов
//  чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
//          Пример 1
//Console.Write("Введите N: ");
//int N = int.Parse(Console.ReadLine()!);
// int i = 1;
// Console.WriteLine("Промежуток четных чисел: ");
// while (i <= N)
// {
//     if (i%2 == 0)
//     {
//         Console.Write($"{i} ");
//     }
//     i++;
// }
//        Пример 2
// Console.Write("Введите N: ");
// int N = int.Parse(Console.ReadLine()!);
// for (int i = 1; i <= N; i++)
// {
//     if (i%2 == 0)
//     {
//              Console.Write($"{i} ");
//     }
// }
//       Решение 
// Console.Write("Введите N: ");
// int number = int.Parse(Console.ReadLine()!);

// for (int index = 1; index <= number; index++)
// {
//   double result = Math.Pow(index,2);
//   Console.Write($"{result} "); 
// }
