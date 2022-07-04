// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System;
using static System.Console;

Clear();

WriteLine("Введите число А: ");
int A = int.Parse(ReadLine());
WriteLine("Введите число B: ");
int B = int.Parse(ReadLine());
double res = 0;
WriteLine($"{A}, {B} -> {grade(res)}");

double grade(double r)
{
    double result = Math.Pow(A, B);
    return result;
}
