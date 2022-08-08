/*
 
 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
 6, 1, 33 -> [6, 1, 33]
 
 */
int[] ints = new int[8];
int i = 0;
Console.Write("[ ");
while (rand_array().Length > i)
{
  if(i < rand_array().Length)
    Console.Write($"{rand_array()[i]},");
  i++;
}
Console.WriteLine($"{ rand_array()[rand_array().Length - 1]} ]");
int[] rand_array()
{
  Random r = new Random();
  for (int s = 0; ints.Length > s; s++)
  {
    ints[s] = r.Next(s,s+s);
  }
  return ints;
}