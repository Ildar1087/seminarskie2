Console.Clear();
Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine());
int n1 =7, n2 = 23;
if (x % n1 == 0 && x % n2 == 0) 
Console.WriteLine("да, кратно");
else
Console.WriteLine("не кратно");
  //Console.WriteLine($"не кратно остаток - {x % y}");