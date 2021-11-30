﻿// Двумерные массивы
// 48. Показать двумерный массив размером m×n заполненный целыми числами
int[,] Array(int m, int n) // метод создания массива
{
    int[,] Array = new int[m, n];
    return Array;
}
int[,] FillArray(int[,] Arr) // метод заполения массива 
{

    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLongLength(1); j++)
        {
            Arr[i, j] = (new Random().Next(-100, 100));
        }
    }
    return Arr;
}
void PrintArray(int[,] Arr) // метод вывода массива в консоль
{

    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLongLength(1); j++)
        {
            Console.Write($"*{Arr[i, j]}");
        }
        Console.WriteLine();
    }
}

//int[,] Arr = Array(4, 5);
//PrintArray(Arr);



//49.  Показать двумерный массив размером m×n заполненный вещественными числами
double[,] ArrayD(int m, int n) // метод создания массива вещественны чисел
{
    double[,] Array = new double[m, n];
    return Array;
}

void PrintArrayDouble(double[,] Arr)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLongLength(1); j++)
        {
            double n = new Random().Next(10, 90) + new Random().NextDouble();
            Console.Write($"{n}*");
        }
        Console.WriteLine();
    }
}
//double[,] Arr2 = ArrayD(4, 5);
//PrintArray(Arr2);


// 50. В двумерном массиве n×k заменить четные элементы на противоположные
int[,] СhangeArray(int[,] arr) // метод замены четных элементов на противоположные
{
    int[,] arrChanged = new int[arr.GetLength(0), arr.GetLongLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLongLength(1); j++)
        {
            arrChanged[i, j] = -arr[i, j];
        }
    }
    return arrChanged;
}
int[,] arr = Array(5, 5);
// PrintArray(FillArray(arr));
// Console.WriteLine();
// PrintArray(СhangeArray(arr));

// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n
int[,] FillArray2(int[,] Arr) // метод задания массива по правилу Aₘₙ = m+n
{

    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLongLength(1); j++)
        {
            Arr[i, j] = i+j;
        }
    }
    return Arr;
}
PrintArray(FillArray2(arr));
// Console.WriteLine();
// PrintArray(СhangeArray(arr));
// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
// В матрице чисел найти сумму элементов главной диагонали
// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
// Написать программу, которая обменивает элементы первой строки и последней строки
// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить
// В прямоугольной матрице найти строку с наименьшей суммой элементов.
// Составить частотный словарь элементов двумерного массива
// Найти произведение двух матриц
// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
// Спирально заполнить двумерный массив:
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 