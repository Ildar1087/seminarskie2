// Напишите программу, которая принимает на вход два числа и 
// проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


Console.Clear();
Console.Write("Введите x1 число: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y1 число: ");
int y = int.Parse(Console.ReadLine());
if (x * x == y)
{
Console.WriteLine("y1 квадрат x1");
return;
} 
if (y * y == x)
{
  Console.WriteLine("x1 квадрат y1");

}
else
{
  Console.WriteLine("не является");
}
 
// int n1 =7, n2 = 23;