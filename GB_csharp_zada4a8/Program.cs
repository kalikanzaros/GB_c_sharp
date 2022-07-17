/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int[] ints = new int[1];
int counter = 0;
while (counter < ints.Length)
{
  Console.Write("Введите трёхзначное число, для вывода значения второго порядка: ");
  string da = Console.ReadLine();
  if (Int32.TryParse(da, out int a) && da.Length == 3)
  {
    ints[counter] = a;
    counter++;
  }
  else
  {
    Console.WriteLine("{0} не похоже на трёхзначное число", a);
  }
}
//если значение меньше 2 или -2, смысла в итерации нет
if (ints[ints.Length - 1] > 2)
{
  Console.Write($"{ints[ints.Length - 1]} -> ");
  for (int i = 2; i < ints[ints.Length - 1]; i += 2 )
  {
    Console.Write($" {i} ");
  }
}
else
  Console.WriteLine($"Значение \"{ints[ints.Length - 1]}\" меньше двух.");
if (ints[ints.Length - 1] < -2)
{
  Console.Write($"{ints[ints.Length - 1]} -> ");
  for (int i = -2; i > ints[ints.Length - 1]; i -= 2)
  {
    Console.Write($" {i} ");
  }
}
else
  Console.WriteLine($"Значение \"{ints[ints.Length - 1]}\" меньше двух.");
Console.Read();