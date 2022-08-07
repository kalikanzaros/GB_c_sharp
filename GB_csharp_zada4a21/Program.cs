/*

Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

Формула для нахождения расстояния между двумя точками A(xa, ya, za) и B(xb, yb, zb) в пространстве:

{d=\sqrt{{(x_b — x_a)}^2 + {(y_b — y_a)^2} + {(z_b — z_a)^2}} 

где xa, ya и za — координаты первой точки A, xb, yb и zb — координаты второй точки B.

 */
Dictionary<string, double> all_values = new Dictionary<string, double>();
all_values.Add("X точки A", 0);
all_values.Add("Y точки A", 0);
all_values.Add("Z точки A", 0);
all_values.Add("X точки B", 0);
all_values.Add("Y точки B", 0);
all_values.Add("Z точки B", 0);

int count = 0;
while (count < all_values.Count)
{
    Console.Write($"Введите число {all_values.ToArray()[count].Key}: ");
    string dig = Console.ReadLine();

    if (double.TryParse(dig, out double a))
    {
      all_values[all_values.ToArray()[count].Key] = a;
      count++;
    }
    else
    {
      Console.WriteLine($"{dig} не похоже на число, нам срочно нужно значение {all_values.ToArray()[count].Key} !!! ");
    }
}
count = 0;
Console.Write("\nТочка A( ");
while (all_values.Count > count)
{
  if (count < all_values.Count / 2)
  {
    Console.Write($"{all_values.ToArray()[count].Value} ");
  }
  if (count == all_values.Count / 2) Console.Write(") \nТочка B( ");
  if (count >= all_values.Count / 2)
  {
    Console.Write($"{all_values.ToArray()[count].Value} ");
  }
  if (count == all_values.Count -1) Console.WriteLine(")");
  count++;
}
if (count == 6)
{
  Console.WriteLine($"Длина отрезка в цифрах: {Math.Sqrt(Math.Pow(all_values.ToArray()[0].Value - all_values.ToArray()[3].Value, 2) +  Math.Pow(all_values.ToArray()[1].Value - all_values.ToArray()[4].Value, 2) + Math.Pow(all_values.ToArray()[2].Value - all_values.ToArray()[5].Value, 2)):F}");
}
 