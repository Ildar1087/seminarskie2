// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("введите число: ");
int numb = int.Parse(Console.ReadLine());
if (numb >= 10 && numb < 100)
{
  Console.WriteLine($"третьей цифры нет!");
  return;
} else if (numb >= 100 && numb < 1000)
{
  int result = numb;
  int result1 = result % 10;
  Console.Write($"{result1}");
}
else if (numb >= 1000 && numb < 10000)
{
  Console.WriteLine($"у числа нет середины");
  return;
}
else if (numb >= 10000 && numb < 100000)
{
  int result = numb % 1000;
  int result1 = result / 100;
  Console.Write($"{result1}");
}
else if (numb >= 100000 && numb < 10000000)
{
 Console.WriteLine($"дальше нам уже не надо)))");
}