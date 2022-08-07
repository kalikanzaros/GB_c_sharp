/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4-> 16
*/
int counter = 0;
ulong a = 0;

uint[] digital_input(string input)
{
    uint[] result = new uint[] {0,0};
    while (counter < 1)
    {
      Console.Write("Введите первое цифровых значения : ");
      string da = Console.ReadLine();
      if (ulong.TryParse(da, out a))
      {
        Console.Write($"{2}");
        counter++;
      }
      else
      {
        Console.WriteLine($"{da} не похоже на число");
      }
      return result;
    }

  return result;
}


ulong input_long(ulong input_1 = 1 , ulong input_2 = 1)
{
  ulong result = 0;
  return result;
}