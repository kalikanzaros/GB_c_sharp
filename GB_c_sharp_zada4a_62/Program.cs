/*Задача 62.Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:

1 2 3 4             0,0 0,1 0,2 0,3
12 13 14 5          2,3 3,0 3,1 1,0
11 16 15 6          2,2 3,3 3,2 1,1
10 9 8 7            2,1 2,0 1,3 1,2

 */

zada4a62();
void zada4a62()
{
  int a = 4;
  int b = 4;
  int z = 1;
  int[,] SpiritualArray = new int[a, b];

  for (int y = 0; y < b; y++)
  {
    SpiritualArray[0, y] = z;
    z++;
  }
  for (int x = 1; x < a; x++)
  {
    SpiritualArray[x, b - 1] = z;
    z++;
  }
  for (int y = b - 2; y >= 0; y--)
  {
    SpiritualArray[a - 1, y] = z;
    z++;
  }
  for (int x = a - 2; x > 0; x--)
  {
    SpiritualArray[x, 0] = z;
    z++;
  }

  int c = 1;
  int d = 1;

  while (z < a * b)
  {
    while (SpiritualArray[c, d + 1] == 0)
    {
      SpiritualArray[c, d] = z;
      z++;
      d++;
    }
    while (SpiritualArray[c + 1, d] == 0)
    {
      SpiritualArray[c, d] = z;
      z++;
      c++;
    }

    while (SpiritualArray[c, d - 1] == 0)
    {
      SpiritualArray[c, d] = z;
      z++;
      d--;
    }

    while (SpiritualArray[c - 1, d] == 0)
    {
      SpiritualArray[c, d] = z;
      z++;
      c--;
    }
  }

  for (int x = 0; x < a; x++)
  {
    for (int y = 0; y < b; y++)
    {
      if (SpiritualArray[x, y] == 0)
      {
        SpiritualArray[x, y] = z;
      }
    }
  }
  for (int x = 0; x < a; x++)
  {
    for (int y = 0; y < b; y++)
    {
      Console.Write($"{SpiritualArray[x, y]} ");
    }
    Console.WriteLine();
  }
}