// Напишите программу, которая будет приниматиь на вход  
// два числа и выводить является ли второе число 
// кратным первому
// если число 2 не кратно числу 1, то программа выводит остаток от деления
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.WriteLine("Введите число n1 =");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n2 =");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 % n2 == 0)
  Console.WriteLine("кратно");
else
  Console.WriteLine($"остаток= {n1 % n2}");

