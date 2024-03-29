﻿using System.Globalization;

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
                      y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/
//global variable not ice 
string[] name_numbers = new string[] {"b1","b2","k1","k2"};
double[] double_numbers = new double[name_numbers.Length];

for (int i = 0; i < name_numbers.Length; i++ )
{
  Console.Write($"Введите значение переменной\"{name_numbers[i]}\": ");
  double_numbers[i] = input_worker();
}

double x = - (double_numbers[0] - double_numbers[1]) / (double_numbers[2] - double_numbers[3]);
double y = (double_numbers[2] * x + double_numbers[3]);
//если пары элементов одинаковые получим  NaN
if (!double.IsNaN(x) && !double.IsNaN(y))
{
  x = Math.Round(x, 3);
  y = Math.Round(y, 3);
  Console.WriteLine($"Пересечение в точке: x:{x.ToString("0.00", CultureInfo.InvariantCulture)}," +
                                        $" y:{y.ToString("0.00", CultureInfo.InvariantCulture)}");
}
else
{
  Console.WriteLine($"Никогда им наверно не встретиться, не взглянуть друг другу в глаза\nотрезки беспомощно бесятся, пересечься никак нельзя\n" +
    $"x:{x.ToString("0.00", CultureInfo.InvariantCulture)}, y:{y.ToString("0.00", CultureInfo.InvariantCulture)}");
}

static double input_worker()
{
  while (true)
  {
    if (double.TryParse(Console.ReadLine(), out double outduble) == true)
    {
      return outduble;
    }
    Console.WriteLine($"На дубль не похоже, вводим ещё раз: ");
  }
}