/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16
Защита от переполнения к сожалению тащит за собой функ-ции проверки типов, но поскольку задача теоретическая,
надеюсь на зачёт в таком не нормальном виде
long 	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 	Signed 64-bit integer 	System.Int64
ulong 	0 to 18,446,744,073,709,551,615                         Unsigned 64-bit integer 	System.UInt64

*/
long counter = 0; 
long a = 0;
long[] array_n = new long[2];
long pow_result = 0;
long counter_pow = 0;

Console.WriteLine("Цикл принимает на вход два числа (A и B)\nи возводит число A в натуральную степень B.");
start();

void start()
{
  while (counter < 2)
  {
    Console.Write("Введите число: ");
    array_n[counter] = digital_input();
    counter++;
  }
  pow_input(array_n[0], array_n[1]);
}

long digital_input()
{
    while (true)
    {
      string da = Console.ReadLine();
      if (long.TryParse(da, out a))
      {
        return a;
      }
      else
      {
        Console.WriteLine($"{da} не похоже на число");
      }
    }
}

long pow_input(long input_1, long input_2)
{
  if (input_2 == 0 || input_2 == 1 || input_1 == 0 || input_1 == 1)
  {
    Console.WriteLine($"Операция не имеет смысла!!!\nОдин из элементов итерации \"0 || 1\"");
    return 0;
  }
  while (counter_pow < input_2 - 1)
  {
    try
    {
      if (counter_pow == 0)
      {
        pow_result = input_1 * array_n[0];
      }
      else
      {
        pow_result *= array_n[0];
      }
      counter_pow++;
      pow_input(pow_result, input_2);
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
      return 0;
    }
  }
  return pow_result;
}


  Console.WriteLine($"Результат: {pow_result}");
