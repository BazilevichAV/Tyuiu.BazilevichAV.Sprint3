using System;
using Tyuiu.BazilevichAV.Sprint3.Task6.V10.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #3                                               *");
Console.WriteLine("* Тема: Обработка целочисленной информации                *");
Console.WriteLine("* Задание #6                                              *");
Console.WriteLine("* Вариант #10                                             *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,     *");
Console.WriteLine("* принадлежащих числовому отрезку [20, 32] сумму          *");
Console.WriteLine("* всех делителей больше 12                                *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

int startValue = 20;
int stopValue = 32;

Console.WriteLine("Начало отрезка = " + startValue);
Console.WriteLine("Конец отрезка = " + stopValue);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
Console.ReadKey();