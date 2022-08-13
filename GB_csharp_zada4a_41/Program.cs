/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
 */

int while_counter = 0;
int upzero_counter = 0;
while (while_counter == 0)
{
  Console.Write("Введите цифры через запятую,без пробелов: ");
  try
  {
    string[] parses_array = Console.ReadLine().Trim().Replace(",", " ").Split();

    for (int i = 0; i < parses_array.Length; i++)
    {
      if (Int32.TryParse(parses_array[i], out int a))
      {
        if (a > 0)
        {
          upzero_counter++;
        }
        while_counter++;
      }
      else
      {
        Console.WriteLine($"Массива Int из этого не полчится, поробуйте снова.\n:");
      }
    }
  }
catch (Exception exception)
  {
    Console.WriteLine($"{exception.Message}\nМассива Int из этого не полчится, поробуйте снова.\n:");
  }
  Console.Write($"->{upzero_counter}");
}
Console.ReadLine();
