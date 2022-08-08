// // Программа для возведения числа в квадрат.

// int number = Convert.ToInt32(Console.ReadLine());

// // 5^2 = 5 * 5

// int square = number * number;   
// // double testResult = Math.Pow(number, 2) [Pow - power (число, степень)]

// // "Cw" + Tab выводит System.Console.WriteLine();
// Console.WriteLine("Результат: " + square); 
// //конкатенация: к левой строчке приписывается правая




// // Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
// // a = 25, b = 5 -> да
// // a =2, b = 10 -> нет

// Console.Write("Введите первое число ");
//     int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число ");
//     int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber == secondNumber * secondNumber)
// {
//     Console.WriteLine(firstNumber + " является квадратом от " + secondNumber);
// }
// else
// {
//     Console.WriteLine(firstNumber + " НЕ является квадратом от " + secondNumber);
// }




// // Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// // 3 -> Среда
// // 5 -> Пятница

// int dayNumber = Convert.ToInt32(Console.ReadLine());

// if(dayNumber == 1)
// {
//     Console.WriteLine("Поендельник");
// }
// if(dayNumber == 2)
// {
//     Console.WriteLine("Вторник");
// }
// if(dayNumber == 3)
// {
//     Console.WriteLine("Среда");
// }
// if(dayNumber == 4)
// {
//     Console.WriteLine("Четверг");
// }
// if(dayNumber == 5)
// {
//     Console.WriteLine("Пятница");
// }
// if(dayNumber == 6)
// {
//     Console.WriteLine("Суббота");
// }
// if(dayNumber == 7)
// {
//     Console.WriteLine("Воскресенье");
// }




// // Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// // 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// // 2 -> " -2, -1, 0, 1, 2"

// int number = Convert.ToInt32(Console.ReadLine()); // N
// // -N = N * (-1)
// if(number < 0)
// {
//     number = number * (-1);
// }
// int negativeNumber = number * (-1); // -N

// while (negativeNumber <= number)
// {
//     Console.WriteLine(negativeNumber);
//     negativeNumber++;
// }