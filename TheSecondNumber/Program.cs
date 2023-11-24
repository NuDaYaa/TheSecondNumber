using System;

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

int n = (number / 10) % 10;

Console.WriteLine($"Вторая цифра числа: {n}");
