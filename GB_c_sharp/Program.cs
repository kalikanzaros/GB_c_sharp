/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
Без обработки ошибок
*/

int[] ints = new int[2];
int counter = 0;
while(counter < ints.Length)
{
  Console.Write("Введите значение для сравнения: ");
  string da = Console.ReadLine();
  if (Int32.TryParse(da, out int a))
  {
    ints[counter] = a;
    counter++;
  }
  else
  {
    Console.WriteLine("{0} не похоже на число", a);
  }
}
Array.Sort(ints);
Console.WriteLine("Максимальное значение: {0}",ints[ints.Length-1]);
Console.Read();