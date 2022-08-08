/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

long 	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 	Signed 64-bit integer 	System.Int64
ulong 	0 to 18,446,744,073,709,551,615                         Unsigned 64-bit integer 	System.UInt64
*/

Console.WriteLine("Программа принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine($"Сумма чисел: {summ(digital_input().ToString())}");

int digital_input()
{
  int a;
  while (true)
  {
    Console.Write("Введите число: ");
    string da = Console.ReadLine().Replace("-", "");
    if (int.TryParse(da, out a))
    {
      return a;
    }
    else
    {
      Console.WriteLine($"{da} не похоже на число");
    }
  }
}

int summ(string input_1)
{
  if (input_1.ToString().Length <= 1)
  {
    Console.WriteLine($"Операция не имеет смысла!!! В числе один элемент: {input_1} !!!");
    return 0;
  }
  int len = input_1.Length;
  int s = 0;
  while (len > 0)
  {
    //  ничего более %странного% в жизни не писал 
    //  понимаю что нужна рекурсия одной функции, но как всегда откладывал до последнего, мои извинения
    int.TryParse(input_1.ToCharArray().GetValue(len - 1).ToString(), out int a);
    s += a;
    len--;
  }
  return s;
}

