// // Задача 2: Напишите программу, 
// //           которая на вход принимает два числа и выдаёт, 
// //           какое число большее, а какое меньшее.

// Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber > secondNumber)
// {
//     Console.WriteLine(firstNumber + " больше " + secondNumber);
// }
// if (secondNumber > firstNumber)
// {
//     Console.WriteLine(secondNumber + " больше " + firstNumber);
// }
// if (firstNumber == secondNumber)
// {
//     Console.WriteLine(firstNumber + " равно " + secondNumber);
// }




// // Задача 4: Напишите программу, 
// //           которая принимает на вход три числа и 
// //           выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третье число: ");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());

// int max = firstNumber;
// if (secondNumber > max)
// {
//     max = secondNumber;
// }
// if (thirdNumber > max)
// {
//     max = thirdNumber;
// }
// Console.WriteLine("Максимальное число: " + max);




// // Задача 6: Напишите программу, 
// //           которая на вход принимает число и выдаёт, 
// //           является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number%2 == 0)
// {
//     Console.WriteLine("Число " + number + " четное");
// }
// else
// {
//     Console.WriteLine("Число " + number + " НЕчетное");
// }




// // Задача 8: Напишите программу, 
// //           которая на вход принимает число (N), 
// //           а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Введите число: ");
// int number1 = Convert.ToInt32(Console.ReadLine()); // N
// int number2 = 2;
// if (number1 > 1)
// {
//    while (number2 <= number1)
//    {
//         Console.Write(number2 + " ");
//         number2+=2;
//    }   
// }
// else
// {
//     Console.WriteLine("Четных чисел в промежутке НЕТ");
// }