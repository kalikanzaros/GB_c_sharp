/* 
Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/*
 * Если это вещественные числа то навеоное можно с double не заморачиваться * условия задачи выполняются
 */

int[] ArrayIntIndex = new int[2];
Console.Write($"Введите цифру первого индекса массива:");
ArrayIntIndex[0] = ParseIntInput();
Console.Write($"Введите цифру второго индекса массива:");
ArrayIntIndex[1] = ParseIntInput();
int[,] ResultArray = new int[ArrayIntIndex[0], ArrayIntIndex[1]];

int counter_baxpace = 0;
for (int i = 0; i < ArrayIntIndex[1]; i++)
{
  counter_baxpace++;
  if (counter_baxpace == ArrayIntIndex[1] || counter_baxpace == 1)
  {
    Console.Write("\t");
  }
  else 
  {
    Console.Write("\n\t");
  }
    for (int j = 0; j < ArrayIntIndex[0]; j++)
    {
      ResultArray[j,i] = GenRandomInt();
      Console.Write($" {ResultArray[j,i]} ");
    }
  if (counter_baxpace == ArrayIntIndex[1] -1)
  {
    Console.Write("\n");
  }
  else
  {
    Console.Write("\t");
  }
}
// вывод выглядит не очень, просчитывать длину символов в строке как-то не очень хочется))
// минус функция красивого вывода

static int GenRandomInt(int minval=0, int maxval=999)
{ 
  Random random = new();
  int result = random.Next(minval, maxval);
  if (GenRandomSign() == 0)
  {
    return result;
  }
  else
  {
    return result * -1;
  }
}

static int GenRandomSign()
{
  Random random = new();
  int result = random.Next(0, 2);
  return result;
}

static int ParseIntInput()
{
  while(true)
  {
    if(Int32.TryParse(Console.ReadLine(), out int result) == true && result > 0)
    {
      return result;
    }
    else
    {
      Console.WriteLine($"Не INT, введите ещё раз: ");
    }
  }
}