Console.Clear();
Console.Write("введите цифру дня недели: ");
int numbDayWeek = int.Parse(Console.ReadLine());
if (numbDayWeek < 1 || numbDayWeek > 7)
{
  Console.WriteLine("не то ввели, аккуратней");
}
if (numbDayWeek == 1)
{
  Console.WriteLine("нет, понедельник рабочий день");
}
if (numbDayWeek == 2)
{
  Console.WriteLine("нет, вторник рабочий день");
}
if (numbDayWeek == 3)
{
  Console.WriteLine("нет, среда рабочий день");
}
if (numbDayWeek == 4)
{
  Console.WriteLine("нет, четверг рабочий день");
}
if (numbDayWeek == 5)
{
  Console.WriteLine("нет, пятница рабочий день");
}
if (numbDayWeek == 6)
{
  Console.WriteLine("Да - Суббота выходной");
}
if (numbDayWeek == 7)
{
  Console.WriteLine("Да - Воскресенье выходной");
}