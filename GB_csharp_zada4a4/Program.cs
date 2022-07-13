/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
Клон задачи на два числа = GB_csharp_zada4a2
 */


int[] ints = new int[3];
int counter = 0;
while (counter < ints.Length)
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
Console.WriteLine("Максимальное значение: {0}", ints[ints.Length - 1]);
Console.Read();