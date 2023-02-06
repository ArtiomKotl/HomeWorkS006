// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


void PrintArray(int[] arrayPrint)
{
  Console.Write("Полученный массив: [");
  for (int index = 0; index < arrayPrint.Length; index++)
  {
    Console.Write($"{arrayPrint[index]}");
    if (index < arrayPrint.Length - 1)
    {
      Console.Write(", ");
    }
  }
  Console.WriteLine("]");
}

int CountPositiveNumbers(string input)
{
    string[] numbers = input.Split(' ');
    int count = 0;
    foreach (string number in numbers)
    {
        if (double.TryParse(number, out double value) && value > 0)
        {
            count++;
        }
    }
    return count;
}


Console.WriteLine("Введите массив целых чисел через пробел:");
string input = Console.ReadLine()!;
string[] numberStrings = input.Split(" ");
int[] numbers = new int[numberStrings.Length];

for (int i = 0; i < numbers.Length; i++)
    numbers[i] = int.Parse(numberStrings[i]);

PrintArray(numbers);
int count = CountPositiveNumbers(input);
Console.WriteLine($"Введено положительных чисел: {count}");
