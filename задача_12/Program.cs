﻿// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли первое число кратным второму. Если число 1 не кратно числу 2, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA % numberB == 0)
{
    Console.WriteLine("кратно");
}
else 
{
    Console.WriteLine($"не кратно, остаток {numberA % numberB}");
}