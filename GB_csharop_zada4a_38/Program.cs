/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int[] ints = new int[rand()];
int index = 0;
int min_ints;
int max_ints;
Console.Write($"Количество объектов в массиве {ints.Length}\n[");
while (index < ints.Length -1)
{
  Console.Write($"{ints[index] = rand()}");
  if (index == 0)
  {
    min_ints = ints[0];
    max_ints = ints[0];
  }
  
  #region определение максимального элемента
  if ((max_ints < ints[index]) && (index > 0))
  {
    Console.Write($"(max:{max_ints}<{ints[index]}:{ints[index]})");
    max_ints = ints[index];
  }
  #endregion
  
  #region определение минимального элемента
  if ((min_ints > ints[index]) && (index > 0) )
  {
    Console.Write($"(min:{min_ints}>{ints[index]}:{ints[index]})");
    min_ints = ints[index];
  }
  #endregion 
  
  if (index < ints.Length - 1)
  {
    Console.Write($",");
  }
  index++;
}
Console.WriteLine($"]  разницу максимального и минимального элемента массива -> {max_ints} - {min_ints} = {max_ints - min_ints}");

static int rand()
{
  Random r = new();
  return r.Next(0, 100);
}
