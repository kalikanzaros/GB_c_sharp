/*
  Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/

zada4a54();
void zada4a54()
{
  Console.Write($"Задача 54.Введите цифры первого и второго индекса массива\nчерез пробел: ");
  List<string> ListInputString = new List<string>();
  int[] IndexFromList = new int[2];
  ParseStrInput(Console.ReadLine());
  int[,] ResultArray = new int[IndexFromList[0], IndexFromList[1]];
  int[,] SortedArray = new int[IndexFromList[0], IndexFromList[1]];
  Console.Write($"Генерируем двухмерный массив:\n");
  generatearray();
  void ParseStrInput(string inputstring)
  {
    bool whilecounter = false;

    while (whilecounter == false)
    {
      if (inputstring.Split().ToList().Count() == 2 && !inputstring.Contains("-") && inputstring.Length >= 3)
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
  
  static int GenRandom(int minndex = 2, int maxindex = 10)
  {
    Random random = new();
    int result = random.Next(minndex, maxindex);
    return result;
  }
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
        ResultArray[j, i] = GenRandom();
        Console.Write($"\t{ResultArray[j, i]}");
      }
      Console.Write($"\t\n");
    }
  }
  //sortarray();
  sortarray2(ResultArray);
  void sortarray()
  {

    void swapindex(int indexmax, int indexmin)
    {

    }
  }
  void sortarray2(int[,] arr)
  {
    int[] tmp_array = new int[IndexFromList[0]];
    
    int count_cols = 0;
    int count_rows = 0;
    for (int i = 0; i < IndexFromList[1]; i++)
    {
      
      for (int a = 0; a < IndexFromList[0]; a++)
      {
        tmp_array[a] = ResultArray[a, i];
        count_rows++;
      }
      Array.Sort(tmp_array);
      Array.Reverse(tmp_array);
      varr(tmp_array, count_cols);
      count_cols++;
    }
    
  }
  void varr(int[] tmp_arr, int col)
  {
    for (int ii = 0; ii < tmp_arr.Length; ii++)
    {
      SortedArray[col, ii] = tmp_arr[ii];
    }
  }
}

void zada4a52()
{
  Console.Write($"Задача 52.Введите цифры первого и второго индекса массива\nчерез пробел: ");
  List<string> ListInputString = new List<string>();
  int[] IndexFromList = new int[2];
  ParseStrInput(Console.ReadLine());
  double[,] ResultArray = new double[IndexFromList[0], IndexFromList[1]];
  Console.Write($"Генерируем двухмерный массив:\n");
  generatearray();
  void ParseStrInput(string inputstring)
  {
    bool whilecounter = false;

    while (whilecounter == false)
    {
      if (inputstring.Split().ToList().Count() == 2 && !inputstring.Contains("-") && inputstring.Length >= 3)
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
  static int[] GenArrayIndex(int len = 2)
  {
    int[] ArrayIntIndex = new int[len];
    for (int i = 0; i < len; i++)
    {
      ArrayIntIndex[i] = GenRandom();
    }
    return ArrayIntIndex;
  }
  static int GenRandom(int minndex = 2, int maxindex = 10)
  {
    Random random = new();
    int result = random.Next(minndex, maxindex);
    return result;
  }
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

  //Решение
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
  for (int i = 0; i < rndarray.Length; i++)
  {
    tmpsumm += rndarray[i];
    Console.Write($"{rndarray[i]}; ");
  }
  Console.Write($"{tmpsumm / rndarray.Length:0.00}.");
  Console.ReadLine();
}