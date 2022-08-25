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
СТРАННЫЙ ПОРЯДОК УБЫВАНИЯ 
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
  
  Console.Write($"задан массив:\n");
  GenArray();
  Console.Write($"В итоге получается вот такой массив:\n");

  SortArray(ResultArray);

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
        ResultArray[j, i] = GenRandomDigit();
        Console.Write($"\t{ResultArray[j, i]}");
      }
      Console.Write($"\t\n");
    }
  }

  void SortArray(int[,] arr)
  {
    int[] tmp_sortarray = new int[IndexFromList[0]];
    int count_cols = 0;
    int count_rows = 0;
   
    for (int i = 0; i < IndexFromList[1]; i++)
    {
      for (int a = 0; a < IndexFromList[0]; a++)
      {
        tmp_sortarray[a] = arr[a, i];
        count_rows++;
      }
      Array.Sort(tmp_sortarray);
      //Array.Reverse(tmp_sortarray);
      Console.WriteLine();
      SetArrayRows(tmp_sortarray, count_cols, false);
      count_cols++;
    }
  }

  void SetArrayRows(int[] tmp_arr, int col, bool sign = true)
  {
    if(sign)
    { 
      for (int i = 0; i < tmp_arr.Length; i++)
      {
        SortedArray[i, col] = tmp_arr[i];
        Console.Write($"{SortedArray[i,col]}\t");
      }
    }
    if (!sign)
    {
      Array.Reverse(tmp_arr);
      for (int i = 0; i < tmp_arr.Length; i++)
      {
        SortedArray[i, col] = tmp_arr[i];
        Console.Write($"{SortedArray[i, col]}\t");
      }
    }
  }
}