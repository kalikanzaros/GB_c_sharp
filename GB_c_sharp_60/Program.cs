/*


 */


zada4a58();
void zada4a58()
{
  Console.Write($"Задача 58.Введите две цифры через пробел: ");
  List<string> ListInputString = new List<string>();
  int[] IndexFromList = new int[2];
  ParseStrInput(Console.ReadLine());
  int[,] ArrayOne = new int[IndexFromList[0], IndexFromList[1]];
  int[,] ArrayTwo = new int[IndexFromList[0], IndexFromList[1]];
  int[,] ArrayResult = new int[IndexFromList[0], IndexFromList[1]];
  GenArray();
  Console.Write($"Первый массив:\n");
  PrintArray(ArrayOne);
  Console.Write($"Второй массив:\n");
  PrintArray(ArrayTwo);
  Console.Write($"Результат умножения:\n");
  PrintArray(ArrayResult);



  void ParseStrInput(string inputstring)
  {
    bool whilecounter = false;

    while (whilecounter == false)
    {
      if (inputstring.Split().ToList().Count() == 2 && !inputstring.Contains("-") && inputstring.Length >= 3
          && (inputstring.Split()[0] != inputstring.Split()[1]))
      {
        ListInputString.AddRange(inputstring.Split().ToList());
        whilecounter = true;
      }
      else
      {
        Console.Write($"Не похоже на два числа через пробел или цифры одинаковые, попробуем ещё раз: ");
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

  static int GenRandomDigit(int minndex = 2, int maxindex = 10)
  {
    Random random = new();
    int result = random.Next(minndex, maxindex);
    return result;
  }

  void GenArray()
  {
    for (int i = 0; i < IndexFromList[1]; i++)
    {
      for (int j = 0; j < IndexFromList[0]; j++)
      {
        ArrayOne[j, i] = GenRandomDigit();
        ArrayTwo[j, i] = GenRandomDigit();
        ArrayResult[j, i] = ArrayOne[j, i] * ArrayTwo[j, i];
      }
    }
  }

  void PrintArray(int[,] ints)
  {
    for (int i = 0; i < IndexFromList[1]; i++)
    {
      for (int j = 0; j < IndexFromList[0]; j++)
      {
        Console.Write($"{ints[j, i]}\t");
      }
      Console.Write($"\t\n");
    }
  }
}
