/*
Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такого числа в массиве нет
За основу принят код задачи 47
nullable игнорируем
поставленная задача выполняется, но очень много ошибок Nullable
*/

Console.Write($"Введите цифры первого и второго индекса массива\nчерез пробел: ");
string strinput = Console.ReadLine();

Console.Write($"Генерируем массив рандомный двухмерный массив:\n ");
int[] ArrayIntIndex = new int[2];
for (int i = 0; i < ArrayIntIndex.Length ;i++)
{
  ArrayIntIndex[i] = GenRandomInt();
}
int[,] ResultArray = new int[ArrayIntIndex[0], ArrayIntIndex[1]];


static int GenRandomInt(int minval = 1, int maxval = 999)
{
  Random random = new();
  int result = random.Next(minval, maxval);
  return result;
}

static List<string>? ParseStrInput(string inputstring)
{
  try
  {
    return inputstring.Split().ToList();
  }
  catch(Exception ex)
  {
    Console.WriteLine(ex.Message);
    return null;
  }
}
void generatearray()
{
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
}

static int ParseIntInput(string pstring)
{
  Int32.TryParse(pstring, out int result);
  return result;
}

if (ParseStrInput(strinput) != null)
{
  generatearray(); 
  if(  ParseIntInput(ParseStrInput(strinput)[0]) >= 0 
    && ParseIntInput(ParseStrInput(strinput)[0]) <= ArrayIntIndex[0]
    && ParseIntInput(ParseStrInput(strinput)[1]) >= 0
    && ParseIntInput(ParseStrInput(strinput)[1]) <= ArrayIntIndex[1])
  {

    Console.WriteLine($"\nЗначение массива ResultArray с индексами: [{ArrayIntIndex[0]},{ArrayIntIndex[1]}]\n -> " +
      $"с запрошенными индексами: {ResultArray[ParseIntInput(ParseStrInput(strinput)[0]), ParseIntInput(ParseStrInput(strinput)[1])]}.");
  }
  else
  {
    Console.WriteLine($"Результат для двухмерного массива ResultArray[{ArrayIntIndex[0]}," +
      $"{ArrayIntIndex[1]}]\nОтсутствует.");
  }
}
else
{
  Console.WriteLine($"Ввод данных неверный, запустите программу ещё раз.");
}