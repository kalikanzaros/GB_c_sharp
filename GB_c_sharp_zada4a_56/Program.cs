/*
 Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Что такое прямоугольный массив слегка не понятно))) будем считать что не одинаковые индексы
*/
zada4a56();
void zada4a56()
{
  Console.Write($"Задача 56.Введите цифры первого и второго ПРЯМОУГОЛЬНОГО)) массива\nчерез пробел: ");
    List<string> ListInputString = new List<string>();
    int[] IndexFromList = new int[2];
    ParseStrInput(Console.ReadLine());
    int[] MinSummArray = new int[IndexFromList[0]];
    int[,] ResultArray = new int[IndexFromList[0], IndexFromList[1]];
    GenArray();
    Console.WriteLine();
    int MinimalDig = int.MaxValue;
    int MinimalIndex = 0;
    for (int i = 0; i < MinSummArray.Length; i++)
    {
      Console.Write($"index:{i},val:{MinSummArray[i]}\t");
      if (MinSummArray[i] < MinimalDig)
      {
        MinimalDig = MinSummArray[i];
        MinimalIndex = i;
      }
    }
    Console.WriteLine($"\nНомер строки с наименьшей суммой элементов: {MinimalIndex + 1}");

    static int GenRandomDigit(int minndex = 2, int maxindex = 10)
    {
      Random random = new();
      int result = random.Next(minndex, maxindex);
      return result;
    }
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
    void GenArray()
    {
      for (int i = 0; i < IndexFromList[0]; i++)
      {
        for (int j = 0; j < IndexFromList[1]; j++)
        {
        ResultArray[i,j] = GenRandomDigit();
        MinSummArray[i] += ResultArray[i,j];
        Console.Write($"\t{ResultArray[i,j]}");
        }
        Console.Write($"\t\n");
      }
    }
}
  
  