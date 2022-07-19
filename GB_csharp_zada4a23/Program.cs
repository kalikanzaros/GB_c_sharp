int res = 0;
while (res < 1)
{
  Console.Write("Введите пятизначное число: ");
  string da = Console.ReadLine().Replace("-", "");
  if ( Int32.TryParse(da, out int a) )
  {

    if ((da.ToArray()[4].ToString() + da.ToArray()[3].ToString()) == (da.ToArray()[0].ToString() + da.ToArray()[1].ToString()))
    {
      Console.WriteLine($"Полином: {da.ToArray()[4].ToString() + da.ToArray()[3].ToString()} == {da.ToArray()[0].ToString() + da.ToArray()[1].ToString()}");
      res++;
      Console.ReadLine();
    }
  }
  else
  {
    Console.WriteLine($"{da} не похоже на пятизначное число");
  }
}