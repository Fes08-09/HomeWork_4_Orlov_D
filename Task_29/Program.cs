// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using System;
using static System.Console;

Clear();

WriteLine("Введите число элементов массива:");
int[] array = FillArray(int.Parse(ReadLine()), 0, 100);
WriteLine($"{String.Join(", ", array)} -> [{String.Join(", ", array)}]");


int[] FillArray(int size, int minValue, int maxValue)
{
    int [] result = new int[size];
    for(int i=0; i<size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}

