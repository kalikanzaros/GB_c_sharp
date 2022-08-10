/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6]-> 0 */


int[] ints = new int[rand()];
int a = 0;
int b = 0;
Console.Write($"Количество объектов в массиве {ints.Length}\n[");
while (a < ints.Length )
{
  Console.Write($"{ints[a] = rand()}");
  if (a % 2 == 1)
  {
    b += ints[a];
    Console.Write($"({a}%2=1)");
  }
  else
  {
    Console.Write($"({a}%2=0)");
  }
  if (a > 0 )
  {
    Console.Write($",");
  }
  a++;
}
Console.WriteLine($"] Сумма нечётных элементов -> {b}");
int rand()
{
  Random r = new Random();
  return r.Next(0, 100); ;
}
