/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] ints = new int[rand()];
int a = ints.Length - 1;
int b = 0;
Console.Write($"Количество объектов в массиве {ints.Length}\n[");
while (a > 0)
{
  Console.Write($"{ints[a] = rand()}");
  if (ints[a] % 2 == 0)
  {
    b++;
    Console.Write($"(%2=0)");
  }
  else
  {
    Console.Write($"(%2=1)");
  }
  if (a > 0)
  {
    Console.Write($",");
  }
  a--;
}
Console.WriteLine($"] -> {b}");
int rand()
{
  Random r = new Random();
  return r.Next(100, 999); ;
}
