int count = 0;
while (count++ < 1)
{
  Console.Write("Введите число: ");
  string dig = Console.ReadLine();
if ( Int32.TryParse(dig, out int a))
  {
    if (a > 0)
    {
      Console.Write(a + "-> ");
      for (int counter = 1; counter < a + 1; counter++)
      {
        if (a == counter)
        {
          Console.Write(Math.Pow(counter, 3) + ".\n");
        }
        else
        {
          Console.Write(Math.Pow(counter, 3) + ",");
        }
      }
    }
    if (a < 0)
    {
      a = a * -1;
      Console.Write("-" + a + "-> ");
      for (int counter = 1; counter < a + 1; counter++)
      {
        if (a == counter)
        {
          Console.Write(Math.Pow(counter, 3)*-1 + ".\n");
        }
        else
        {
          Console.Write(Math.Pow(counter, 3) *-1 + ",");
        }
      }
    }
    if (a == 0)
    {
      Console.Write("ноль не возводится\n");
      return;
    }
    count++;
  }
  else
  {
    Console.WriteLine($"{dig} не похоже на число");
  }
}