// // Напишите программу, 
// // которая выводит случайное трёхзначное число и удаляет 
// // вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98


// void FillArray(int[] randomNumbers)
// {
//     int length = randomNumbers.Length;
//     int index = 0;
//     while (index < length)
//     {
//         randomNumbers[index] = new Random().Next(1, 10);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(col[position]);
//         position++;
//     }
// }

// int[] array = new int[3];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine(array[0] + "" + array[2]);




// Напишите программу, 
// которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит 
// остаток от деления. 34, 5 -> не кратно, остаток 4; 16, 4 -> кратно


// Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// int FindResidue(int delimoe, int delitel)
// {
// int residue = 1;
//     while (residue < delitel)
//     {
//         int remainder = delimoe - residue;
//         if (remainder%delitel == 0)
//         {
//             break;
//         }
//         residue++;
//     }
// return residue;
// }

// if (firstNumber%secondNumber == 0)
// {
//     Console.WriteLine(firstNumber + " кратно " + secondNumber);
// }
// else
// {
//     Console.WriteLine("Не кратно, остаток равен: " + FindResidue(firstNumber, secondNumber));
// }




// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да


// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number%7 == 0)
// {
//     if (number%23 == 0)
//     {
//         Console.WriteLine("Число кратно 7 и 23");
//     }
//     else
//     {
//         Console.WriteLine("Число НЕ кратно 23");
//     }
// }
// else
// {
// Console.WriteLine("Число НЕ кратно 7 и 23");
// }




// Напишите программу, которая выводит 
// случайное число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8


// int number = new Random().Next(10,100);
// Console.WriteLine($"Рандомное число: {number}"); // Интерполяция
// int firstDigit = number / 10; // "/" - деление без остатка
// int secondDigit = number % 10; // "%" - остаток деления на 10
// int maximum = firstDigit;
// if (secondDigit > maximum)    maximum = secondDigit;
// Console.WriteLine($"Максимальная цифра в числе {number} - это {maximum}");




// Напишите программу, которая выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98


// int number = new Random().Next(100, 1000);
// int firstDigit = number / 100;
// int lastDigit = number % 10;
// Console.WriteLine($"Исходное число - {number}");
// Console.WriteLine($"Полученное число - {firstDigit}{lastDigit}");






// Напишите программу, которая будет принимать на вход два числа и 
// выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит 
// остаток от деления. 34, 5 -> не кратно, остаток 4 16, 4 -> кратно


// Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber % secondNumber == 0)
// {
//     Console.WriteLine($"Число {firstNumber} кратно {secondNumber}");
// }
// else
// {
//     int residue = firstNumber % secondNumber;
//     Console.WriteLine($"Число {firstNumber} НЕ кратно {secondNumber}, остаток равен {residue}");
// }




// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да


// Console.WriteLine("Введите число для проверки:");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 & number % 23 == 0)
// {
//     Console.WriteLine("Число кратно 7 и 23");
// }
// else
// {
//     Console.WriteLine("Число НЕ кратно 7 и 23");
// }




// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.


// Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// // if (secondNumber == Math.Pow(firstNumber, 2))
// // {
// //     Console.WriteLine($"Число {secondNumber} является квадратом числа {firstNumber}");
// // }
// // else Console.WriteLine($"Число {secondNumber} НЕ является квадратом числа {firstNumber}");

// if (secondNumber > firstNumber)
// {
//     if (secondNumber == Math.Pow(firstNumber, 2))
//     {
//         Console.WriteLine($"Число {secondNumber} является квадратом числа {firstNumber}");
//     }
//     else Console.WriteLine($"Число {secondNumber} НЕ является квадратом числа {firstNumber}");
// }
// else
// {
//     if (firstNumber == Math.Pow(secondNumber, 2))
//     {
//         Console.WriteLine($"Число {firstNumber} является квадратом числа {secondNumber}");
//     }
//     else Console.WriteLine($"Число {firstNumber} НЕ является квадратом числа {secondNumber}");
// }