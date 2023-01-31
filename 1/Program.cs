Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine($"Num = {num}");
int num1 = num / 100;
Console.WriteLine($"Num1 = {num1}");
int num2 = num % 100;
Console.WriteLine($"Num2 = {num2}");
int max = num2;
if (num1 > max)
{
  max = num1;
}
Console.WriteLine($"Max = {max}");