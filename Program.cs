// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите некоторое количество чисел от -1000 до 1000 через пробел: ");

void CountingPositiveNumbers(string values)
{
  int[] arrayNumbers = Array.ConvertAll(values.Split(), int.Parse);

  int count = 0;
  for (int i = 0; i < arrayNumbers.Length; i++)
  {
    if (arrayNumbers[i] > 0)
    {
      count += 1;
    }
  }

  Console.WriteLine($"Количество введенных чисел больше 0 -> {count}");
}


string? acceptedValues = Console.ReadLine();

if (String.IsNullOrEmpty(acceptedValues))
{
  Console.WriteLine("Не введено ни одного числа");
}
else
{
  CountingPositiveNumbers(acceptedValues);
}