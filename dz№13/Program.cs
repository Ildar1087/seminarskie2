// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("введите число: ");
int numbDayWeek = int.Parse(Console.ReadLine());
//Console.Write($"{numbDayWeek} -> {res2 % 10}");
if (numbDayWeek >= 10 && numbDayWeek < 100)
{
  Console.WriteLine($"третьей цифры нет!");
} else if (numbDayWeek >= 100 && numbDayWeek < 1000)
{
  int result = numbDayWeek;
  int result1 = result % 10;
  Console.Write($"{result1}");
}
else if (numbDayWeek >= 1000 && numbDayWeek < 10000)
{
  Console.WriteLine($"у числа нет середины");
}
else if (numbDayWeek >= 10000 && numbDayWeek < 100000)
{
  int result = numbDayWeek % 1000;
  int result1 = result / 100;
  Console.Write($"{result1}");
}
else if (numbDayWeek >= 100000 && numbDayWeek < 10000000)
{
 Console.WriteLine($"дальше нам уже не надо)))");
}


