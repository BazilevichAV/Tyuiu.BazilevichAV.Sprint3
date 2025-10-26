using System;
using Tyuiu.BazilevichAV.Sprint3.Task4.V1.Lib;

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

int startValue = -5;
int stopValue = 5;

Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine("Сумма ряда = " + ds.Calculate(startValue, stopValue));
Console.ReadKey();