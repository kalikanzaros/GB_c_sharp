/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write($"Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.\n");
Console.Write($"Введите значение M:");
int m = ParseIntInput();
Console.Write($"Введите значение N:");
int n = ParseIntInput();
int IncrementSumm = 0;

Console.Write($"M = {m};N = {n}.->\"");
Increment(m, n);
static int ParseIntInput()
{
  while (true)
  {
    if (int.TryParse(Console.ReadLine(), out int result) == true && result > 0)
    {
      return result;
    }
    else
    {
      Console.WriteLine($"Не int, введите ещё раз: ");
    }
  }
}
void Increment(int m, int n)
{
  if (m <= n)
  {
    IncrementSumm = IncrementSumm + m;
    Increment(m + 1, n);
  }
  if (m > n)
  {
    Console.Write($"{IncrementSumm}\"");
    return;
  }
}