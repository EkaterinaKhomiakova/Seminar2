// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все четные числа от 1 до N;

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= N; i += 2)
  if (i % 2 == 0)
    Console.WriteLine($"{i}");

