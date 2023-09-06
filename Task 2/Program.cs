// Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Введите число a : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c : ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max)
  max = b;
if (c > max)
  max = c;
Console.WriteLine($"max = {b}");

