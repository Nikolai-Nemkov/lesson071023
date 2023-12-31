﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача 40");

// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// "Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон".

Console.Write("Введите первую сторону: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите вторую сторону: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третью сторону: ");
int numC = Convert.ToInt32(Console.ReadLine());

bool IsExistTriangle(int a, int b, int c) // используем метод bool, т.к.по условию нужен ответ, да или нет.
{
    return a < b + c && b < a + c && c < a + b; // Можно без if и else, return - это использует и сразу взвращает значения.  || - или, && - И
}
bool res = IsExistTriangle(numA, numB, numC);

Console.WriteLine(res ? "Треугольник существует" : "Треугольник не существует");
// res ? - тернарный оператор, либо да, либо нет.
