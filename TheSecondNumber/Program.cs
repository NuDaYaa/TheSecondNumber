using System;

Console.Write("Введите целое число: ");
int x = int.Parse(Console.ReadLine());

int n = (x / 10) % 10;

Console.WriteLine($"Вторая цифра числа(Десяток): {n}");
