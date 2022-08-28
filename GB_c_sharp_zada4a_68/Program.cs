/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3->A(m, n) = 29

как в примере:  м поменяно местами с н... илии... да нет, не может быть)
Ну и стэк оверфлоу привет.
 */


Console.Write($"Введите значение n:");
UInt64 n = ParseUIntInput();
Console.Write($"\nВведите значение m:");
UInt64 m = ParseUIntInput();
Console.Write($"m = {m},n = {n}->A({m},{n}) = {AccermanFunc(m, n)}");

static UInt64 ParseUIntInput()
{
  while (true)
  {
    if (UInt64.TryParse(Console.ReadLine(), out UInt64 result) == true && result > 0)
    {
      return result;
    }
    else
    {
      Console.WriteLine($"Не long, введите ещё раз: ");
    }
  }
}

static UInt64 AccermanFunc(UInt64 m, UInt64 n)
{
  if (m == 0)
  {
    return n + 1;
  }
  if (m > 0 & n == 0)
  {
    return AccermanFunc(m - 1, 1);
  }
  if (m > 0 & n > 0)
  {
    return AccermanFunc(m - 1, AccermanFunc(m, n - 1));
  }
  return AccermanFunc(m, n);
}
