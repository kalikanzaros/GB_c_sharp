/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

 */


int counter = 0;
int a = -1;  

while (counter < 1) 
{
  Console.Write("Введите номер дня недели: ");
  string da = Console.ReadLine();
  if (Int32.TryParse(da, out a) && a < 8 && a > 0)
  {
    Console.Write($"{fundays(a)}.");
    counter++;
  }
  else
  {
    Console.WriteLine($"{da} не похоже на число дня недели");
  }
}

string fundays(int day) 
{
  string result = "нет, будни";
  if (day == 6 || day == 7)
  {
    result = "да, выходной";
  }
  return result;
}