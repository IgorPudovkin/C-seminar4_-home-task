﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
Console.Clear();
Console.Write("Array of 8 elements: ");
int num = 8;
int[] array = GetBinArray(num);
Console.Write($"[{String.Join(", ", array)}]");
Console.Write($"[");
for (int i = 0; i < num - 1; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.Write($"{array[num - 1]}]");
int[] GetBinArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 10);
    }
    return result;
}