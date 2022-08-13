//  Напишите программу, 
//  которая принимает на вход координаты точки (X и Y), 
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//  в которой находится эта точка.


// Console.WriteLine("Введите координату по оси X: ");
// int x = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите координату по оси Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("Точка находится в I четверти.");
// if (x < 0 && y > 0) Console.WriteLine("Точка находится в II четверти.");
// if (x < 0 && y < 0) Console.WriteLine("Точка находится в III четверти.");
// if (x > 0 && y < 0) Console.WriteLine("Точка находится в IV четверти.");




// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).


// Console.WriteLine("Введите номер четверти на коорд. плоскости: ");
// int quater = int.Parse(Console.ReadLine());


// if (quater == 1 || quater == 2 || quater == 3 || quater == 4)
// {
//     if (quater == 1) Console.WriteLine("X>0; Y>0");
//     if (quater == 2) Console.WriteLine("X<0; Y>0");
//     if (quater == 3) Console.WriteLine("X<0; Y<0");
//     if (quater == 4) Console.WriteLine("X>0; Y<0");
// }
// else Console.WriteLine("Четверти не существует.");




// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.


// Console.WriteLine("Введите координату по оси X для первой точки: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату по оси Y для первой точки: ");
// double y1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите координату по оси X для второй точки: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату по оси Y для второй точки: ");
// double y2 = Convert.ToDouble(Console.ReadLine());

// double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
// Console.WriteLine("Расстояние между точками: " + Math.Round(distance, 3));
// Math.Round(число, кол-во знаков после запятой) - округляет число
// Console.WriteLine($"Расстояние между точками: {distance:f3}");
// {переменная:f кол-во знаков} -> {distance:f3} - остается 3 знака после запятой




// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.


// void PrintArray(int[] col)
// {
//     int size = col.Length;
//     int count = 0;
//     while (count < size)
//     {
//         Console.Write(col[count] + "; ");
//         count ++;
//     }
// }

// Console.WriteLine("Введите число: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// int index = 0;
// int digit = 1;
// while (index < size)
// {
//     array[index] = digit;
//     digit++;
//     index++;

// }
// int position = 0;
// while (position < size)
// {
//     array[position] = array[position] * array[position];
//     //array[index] = Math.Pow(array[index], 2);
//     position++;
// }
// PrintArray(array);
// ...........................
// int number = Convert.ToInt32(Console.ReadLine());
// for (начало, условие цикла, действие по окончании цикла)
// for (int i = 1; i <= number; i++)
// {
//     Console.Write(Math.Pow(i , 2) + "\t"); 
// Литералы - "\t" (Табуляция - 4 пробела)
//            "\n" (Переход на новую строку)
// }
// ...........................
// int number = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (i <= number)
// {
//     Console.Write(Math.Pow(i , 2) + "\t");
//     i++;
// }




