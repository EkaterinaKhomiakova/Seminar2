﻿// Напишите программу, которая на вход принимает число и выдает,
// является ли число четным, делится 
// ли оно на 2 без остатка
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
  Console.WriteLine($"четное ");
else
  Console.WriteLine($"нечетное ");
