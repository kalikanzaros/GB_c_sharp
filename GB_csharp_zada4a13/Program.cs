/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645-> 5
78-> третьей цифры нет
32679-> 6

 Поскольку не требуется математических манипуляций с выводом
 то можно обойтись одной проверкой на соответствие типу 
 -- Задача идентична десятой, кроме длины переменной и её значения, 
 об экономии ресурсов так-же как и в десятой задаче речи не идёт.
*/


string res = "";
string da = "";
int counter = 0;
while (counter < 1)
{
  Console.Write("Введите число, для вывода третьей цифры: ");
  da = Console.ReadLine();
  if (Int32.TryParse(da, out int a))
  {
    if (a < -99 && a < 1 )
    {
      res = (a * -1).ToString();
      res = res.ToString().Remove(0, 2).Remove(1, res.Length - 3);
      counter++;
    }
    if (a > -1 && a > 99 )
    {
      res = a.ToString();
      res = res.ToString().Remove(0, 2).Remove(1, res.Length - 3);
      counter++;
    }
    if ((a < 0 && a > -99) || (a > 0 && a < 99 ) || a == 0)
    {
      res = "отсутстует";
      counter++;
    }
  }
  else
  {
    Console.WriteLine($"{da} не похоже на число");
  }
}

Console.WriteLine($"Третье число в {da}:  {res}\n");
Console.ReadKey();