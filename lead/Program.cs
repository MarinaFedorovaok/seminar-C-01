﻿// Почувствуй себя лидом

// 41. Выяснить являются ли три числа сторонами треугольника 
// Сумма длин двух любых сторон треугольника больше длины оставшейся стороны:
// a + b > c
// b + c > a
// c + a > b

bool triangle(int a, int b, int c)
{
 return((a+b>c)||(b + c > a)||c + a > b);
}
Console.WriteLine(triangle(2,4,5));
// a + b > c
// b + c > a
// c + a > b

// 42. Определить сколько чисел больше 0 введено с клавиатуры
    // int countAlements(int n)
    // {
    // string a;
    //         int[] b = new int[n];
    //         for (int i=0; i<n; i++)
    //         {a = Console.ReadLine();
    //         b[i] = Convert.ToInt32(a);
    //         }

    //         // while ((a = Console.ReadLine()) != "end") //Получаем строку и проверяем ее содержание
    //         //     b[i++] = Convert.ToInt32(a); //в стркое нет "конца" - значит конвертим и пишем в массив
    //         int count = 0;
    //         for (int k = 0; k < n; k++) //вывод заполненных ячеек массива
    //         {
    //         if (b[k]>0) count++;
    //             Console.WriteLine(b[k]);
    //         }
    //     return count;
    //  }
    // Console.WriteLine($"Количество положительных элементов:{countAlements(5)}");
          //  Console.ReadKey(true);

// 43. Написать программу преобразования десятичного числа в двоичное
// 44. Найти точку пересечения двух прямых заданных уравнением y1=k1x1+b1, y2=k2x2+b2 и b2 и k2 заданы

// найти точку (x, y), x=x1=x1, y=y1=y2
//x=(y-b1)/k1
//y=k2*(y-b1)/k1+b2 
//y=k2y/k1-k2b1/k1+b2
//y(1-k2/k1)=b2-k2b1/k1
//y=(b2-k2b1/k1)/(1-k2/k1)

// double Find ((int b1, int k1) x, (int b2, int k2) y) 
//double[] FuncPow(int n) 
// { 
//     double [] array = new double [n]; 
//     for(int i = 1; i <= n; i++) 
//     { 
//         array[i - 1] = Math.Pow(i, 2); 
//     } 
//     return array; 
// } 

// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
// 47. Написать программу копирования массива