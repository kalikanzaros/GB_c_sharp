/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
 */


zada4a60();
void zada4a60()
{
  Console.Write($"Задача 60.Формируем трёхмерный массив из неповторяющихся двузначных чисел:\n");
  int[,,] TreeArraay = new int[2, 2, 2];
  int digitplus = 0;
  GenArray();
  
  void GenArray()
  {
    for (int a = 0; a < 2; a++)
    {
      for (int b = 0; b < 2; b++)
      {
        for (int c = 0; c < 2; c++)
        {
          TreeArraay[a, b, c] = GenInt();
          Console.Write($"{TreeArraay[a,b,c]}({a},{b},{c})\t");
        }
      }
      Console.WriteLine();
    }
  }
  int GenInt()
  {
    digitplus = digitplus + 1;
    return digitplus;
  }
}