﻿// 1. Задача сложения двух чисел
// 2. Я хочу получить то и то... 
// 3. Я делаю так и так...
// 4. Я ожидаю получить такой-то результ.. или получают ошибку
// 5. Я получаю 23...
// 6. Почему?
/// 1. **Типы данных**
// int double string bool - вшиты в .net
/// 2. Переменные
/// 3. Задача 1. 
/// **Обмен значений двух переменных**
int a = 123;
int b = 3213;
//Console.Write("a= ");
//Console.WriteLine(a);
///Console.Write("b= ");
//Console.WriteLine(b);

Console.WriteLine("a = " + a + "\nb = " + b);
//Console.WriteLine($"a = " + a + "\nb = " + b);
a = a +b;
b = a-b;
a = a-b;
Console.WriteLine($"Стало a = {a} b={b}");
