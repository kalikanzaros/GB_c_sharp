/*
Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такого числа в массиве нет
За основу принят код задачи 47
nullable игнорируем + почти  не обрабатываем и не генерим эксепшн
поставленная задача выполняется, но очень много ошибок
*/

Console.Write($"Введите цифры первого и второго индекса массива\nчерез пробел: ");
string strinput = Console.ReadLine();

Console.Write($"Генерируем двухмерный массив:\n ");
int[] ArrayIntIndex = new int[2];
for (int i = 0; i < ArrayIntIndex.Length ;i++)
{
  ArrayIntIndex[i] = GenRandomInt();
}
int[,] ResultArray = new int[ArrayIntIndex[0], ArrayIntIndex[1]];

//minvalue < 2 = exception in func generatearray: if (counter_baxpace == ArrayIntIndex[1] - 1) 
// красота не наводiтsya: if val1.len != val2.len
static int GenRandomInt(int minval = 10, int maxval = 99)
{
  Random random = new();
  int result = random.Next(minval, maxval);
  return result;
}

static List<string> ParseStrInput(string inputstring)
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

    Console.WriteLine($"\nЗначение ResultArray[{ArrayIntIndex[0]},{ArrayIntIndex[1]}] -> {ResultArray[ParseIntInput(ParseStrInput(strinput)[0]), ParseIntInput(ParseStrInput(strinput)[1])]}.");
  }
  else
  {
    Console.WriteLine($"\n Значение ResultArray[{ArrayIntIndex[0]}, {ArrayIntIndex[1]}] -> oтсутствует.");
  }
}
else
{
  Console.WriteLine($"Ввод данных неверный, запустите программу ещё раз.");
}