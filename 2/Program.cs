Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine($"num = {num}");
int result = (num / 100) * 10 + num % 10;
Console.WriteLine($"{num} -> {result}");
Console.Write($"{num} -> {num / 100} {num % 10}");

// Напишите программу которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа

// 456 -> 46
// 782 -> 72 
// 918 -> 98

