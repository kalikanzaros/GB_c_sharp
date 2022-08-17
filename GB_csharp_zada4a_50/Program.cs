/*
Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такого числа в массиве нет
За основу принят код задачи 47
Если это вещественные числа то навеоное можно с double не заморачиваться * условия задачи выполняются
 */


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
    ResultArray[j, i] = GenRandomInt();
    Console.Write($" {ResultArray[j, i]} ");
  }
  if (counter_baxpace == ArrayIntIndex[1] - 1)
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

static int GenRandomInt(int minval = 0, int maxval = 999)
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
  while (true)
  {
    if (Int32.TryParse(Console.ReadLine(), out int result) == true && result > 0)
    {
      return result;
    }
    else
    {
      Console.WriteLine($"Не INT, введите ещё раз: ");
    }
  }
}