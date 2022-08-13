// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

//Решил сделать сразу универсальную программу

// Console.WriteLine("Введите число: ");
// string? number = Console.ReadLine();
// int index = 0;
// int rightSideIndex = number.Length - 1;
// int iterrationCount = 0;
// while (index < number.Length / 2)
// {
//     if (number[index] == number[rightSideIndex])
//     {
//         index++;
//         rightSideIndex--;
//         iterrationCount++;
//     }
//     else 
//     {
//         Console.WriteLine($"Число {number} НЕ является палиндромом"); 
//         break; 
//     }
// }
// if (iterrationCount == number.Length / 2) Console.WriteLine($"Число {number} является палиндромом"); // Можно не вводить переменную iterrationCount, а сделать проверку через index

//............................................

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату по оси Х для первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату по оси Y для первой точки: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату по оси Z для первой точки: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату по оси Х для второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату по оси Y для второй точки: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату по оси Z для второй точки: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.WriteLine($"Расстояние от точки A({x1}; {y1}; {z1}) до точки B({x2}; {y2}; {z2}) равно {result:f3}.");

// ...........................................

// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// for (double i = 1; i <= number; i++)
// {
//     Console.WriteLine($"Куб числа {i} равен {Math.Pow(i, 3)}.");
// }
