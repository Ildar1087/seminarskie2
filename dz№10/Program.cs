﻿// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine($"num = {num}");
int result = (num / 10);
int res2 = result % 10;
Console.Write($"{num} -> {res2 % 10}");