// Напишите программу, которая принимает на вход два числа и 
// проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


Console.Clear();
Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = int.Parse(Console.ReadLine());
int n1 =7, n2 = 23;
if (x * x == y && y /x == x ) 
Console.WriteLine("да");
else
Console.WriteLine("не");
 
