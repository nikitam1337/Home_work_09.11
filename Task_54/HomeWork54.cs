﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);

Console.WriteLine();

SortingArray(array);

PrintArray(array);

//////////////////////// Methods///////////////////////////
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortingArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int sort = j + 1; sort < inArray.GetLength(1); sort++)
            {
                if (inArray[i, j] < inArray[i, sort])
                {
                    temp = inArray[i, j];
                    inArray[i, j] = inArray[i, sort];
                    inArray[i, sort] = temp;
                }
            }
        }
    }
}
