// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// // 0, 7, 8, -2, -2 -> 2

// // 1, -7, 567, 89, 223-> 3


// Console.WriteLine("Введите некоторое количество чисел от -1000 до 1000 через пробел: ");

// void CountingPositiveNumbers(string values)
// {
//   int[] arrayNumbers = Array.ConvertAll(values.Split(), int.Parse);

//   int count = 0;
//   for (int i = 0; i < arrayNumbers.Length; i++)
//   {
//     if (arrayNumbers[i] > 0)
//     {
//       count += 1;
//     }
//   }

//   Console.WriteLine($"Количество введенных чисел больше 0 -> {count}");
// }


// string? acceptedValues = Console.ReadLine();

// if (String.IsNullOrEmpty(acceptedValues))
// {
//   Console.WriteLine("Не введено ни одного числа");
// }
// else
// {
//   CountingPositiveNumbers(acceptedValues);
// }



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1) / (-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Две прямые пересекутся в точке с координатами -> ({x}; {y})");