// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;
using static System.Console;

Clear();

WriteLine("Введите число:");
int n = int.Parse(ReadLine());
int array = sum(n);
WriteLine($"{n} -> {array}");

int sum (int r)
{
    int result = 0;
    string str = r.ToString();
    int[] sum = new int[str.Length];
    int i = 0;
    for(i=0; i< str.Length; i++)
    {
        sum[i] = int.Parse(str[i].ToString());
        result+=sum[i]; 
    }
    return result;
}


