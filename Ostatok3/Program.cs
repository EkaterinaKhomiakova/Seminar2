// Напишите программу, которая принимает на вход 2 числа
// и проверяет, является ли одно число квадратом другого
// 5, 25 -> да
// 6, 9 -> нет
Console.WriteLine("Введите число x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x * x == y || y * y == x)
  Console.WriteLine("да");
else
  Console.WriteLine("нет");
