/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */

List<string> ListInputString = new List<string>();
int[] IndexFromList = new int[2];

Console.Write($"Задача 52.Введите цифры первого и второго индекса массива\nчерез пробел: ");
ParseStrInput(Console.ReadLine());

double[,] ResultArray = new double[IndexFromList[0], IndexFromList[1]]; 
Console.Write($"Генерируем двухмерный массив:\n");
generatearray();

void ParseStrInput(string inputstring)
{
  bool whilecounter = false;
 
  while (whilecounter == false)
  {
    if (inputstring.Split().ToList().Count() == 2 && !inputstring.Contains("-") && inputstring.Length >= 3 )
    {
      ListInputString.AddRange(inputstring.Split().ToList());
      whilecounter = true;
    }
    else
    {
      Console.Write($"Не похоже на два числа через пробел, попробуем ещё раз: ");
      ListInputString.Clear();
      whilecounter = false;
      inputstring = null;
      ParseStrInput(Console.ReadLine());
      break;
    }
  }
  for (int i = 0; i < 2; i++)
  {
    if (ParseIntInput(ListInputString[i]) > 0)
    {
      IndexFromList[i] = ParseIntInput(ListInputString[i]);
    }
    else 
    {
      Console.WriteLine($"Индексы меньше 1 не допускаются\nвведём индексы ещё раз:");
      ListInputString.Clear();
      inputstring = null;
      ParseStrInput(Console.ReadLine());
      break;
    }
  }
}
//массив индексов для массива(ResultArray) который будем генерить для подсчёта с.а.
static int[] GenArrayIndex( int len = 2 )
{
  int[] ArrayIntIndex = new int[len];
  for (int i = 0; i < len; i++ )
  {
    ArrayIntIndex[i] = GenRandom();
  }
  return ArrayIntIndex;
}
//Генерируем рандом int для заполнения массива
static int GenRandom(int minndex = 2, int maxindex = 10)
{
  Random random = new();
  int result = random.Next(minndex, maxindex);
  return result;
}
//Парсим строку в инт
static int ParseIntInput(string pstring)
{
  try
  {
    Int32.TryParse(pstring, out int result);
    return result;
  }
  catch (Exception e)
  {
    Console.WriteLine($"ParseIntInput Error: {e.Message}");
    return -1;
  }
}

void generatearray()
{
    for (int i = 0; i < IndexFromList[1]; i++)
    {
      for (int j = 0; j < IndexFromList[0]; j++)
      {
        ResultArray[j, i] = Convert.ToDouble(GenRandom());
      //Ну раз принято ставить запятые вместо точек, то провайдера менять не будем))
      Console.Write($"\t{ResultArray[j, i]:0.0}");
      }
      Console.Write($"\t\n");
    }
}


double[] rndarray = new double[ParseIntInput(ListInputString[0])];

for (int c = 0; c < ParseIntInput(ListInputString[0]); c++)
{
  for (int b = 0; b < ParseIntInput(ListInputString[1]); b++)
  {
    rndarray[c] = (rndarray[c] + ResultArray[c, b]);
  }
  rndarray[c] = (rndarray[c]) / ParseIntInput(ListInputString[1]);
}
double tmpsumm = 0;
Console.Write("\nСреднее арифметическое каждого столбца: ");
for (int i = 0; i < rndarray.Length; i++ )
{
  tmpsumm += rndarray[i];
  Console.Write($"{rndarray[i]}; ");
}
Console.Write($"{tmpsumm/rndarray.Length:0.00}.");
Console.ReadLine();
