﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 % 2 == 0) Console.WriteLine ("Данное число четное!");
else Console.WriteLine ("Данное число нечетное!");
