// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double getVar(string name)
{
  double value;
  Console.Write($"Введите значение для {name}: ");
  while (!double.TryParse(Console.ReadLine(), out value))
  {
    Console.WriteLine($"Неверный ввод. Введите значение для {name}: ");
  }

  return value;
}

double Intersectionline1(double b1, double k1, double b2, double k2)
{
  if (k1 == k2)
  {
    Console.WriteLine("Прямые пралельны.");
    return double.NaN;
  }

  return (b2 - b1) / (k1 - k2);
}

double Intersectionline2(double x, double k1, double b1)
{
  return k1 * x + b1;
}

double b1 = getVar("b1");
double k1 = getVar("k1");
double b2 = getVar("b2");
double k2 = getVar("k2");

double x = Intersectionline1(b1, k1, b2, k2);
if (double.IsNaN(x))
{
  return;
}
double y = Intersectionline2(x, k1, b1);


Console.WriteLine("Точка пересечения: (" + x + ", " + y + ")");
