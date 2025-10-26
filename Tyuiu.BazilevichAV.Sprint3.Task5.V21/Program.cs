using System;
using Tyuiu.BazilevichAV.Sprint3.Task5.V21.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #3                                               *");
Console.WriteLine("* Тема: Использование операторов continue и break в циклах*");
Console.WriteLine("* Задание #4                                              *");
Console.WriteLine("* Вариант #1                                              *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5,        *");
Console.WriteLine("* вычислить значение функции y=sin(x)/x. При х = 0        *");
Console.WriteLine("* прервать цикл. Полученные значения суммировать.         *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

int x = 2;
int startValue1 = 1;
int startValue2 = 5;
int stopValue1 = 10;
int stopValue2 = 20;

Console.WriteLine("Переменная Х = " + x);
Console.WriteLine("Старт шага первой суммы ряда = " + startValue1);
Console.WriteLine("Конец шага первой суммы ряда = " + stopValue1);
Console.WriteLine("Старт шага второй суммы ряда = " + startValue2);
Console.WriteLine("Конец шага второй суммы ряда = " + stopValue2);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
Console.ReadKey();