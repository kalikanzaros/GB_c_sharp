/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
 */

int[] ints = new int[1];
int counter = 0;
while (counter < ints.Length)
{
  Console.Write("Введите значение для определения чётности: ");
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
if(ints[ints.Length-1]%2 == 0)
  Console.WriteLine("Значение ({0} -> да) четное", ints[ints.Length - 1]);
else
  Console.WriteLine("Значение ({0} -> нет) нечетное", ints[ints.Length - 1]);
Console.Read();