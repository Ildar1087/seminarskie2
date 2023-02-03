Console.Clear();
Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine());
if (x % 7 == 0 && x % 23 == 0) 
Console.WriteLine("да, кратно");
else
Console.WriteLine("не кратно");
  //Console.WriteLine($"не кратно остаток - {x % y}");