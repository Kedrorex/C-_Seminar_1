﻿// Задача №14. Работа в группах
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите  число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int number7 = numberA % 7;
int number23 = numberA % 23;

if (number7 == 0 && number23 == 0)
{
  Console.Write("да");
} else
{
  Console.Write("нет");
}