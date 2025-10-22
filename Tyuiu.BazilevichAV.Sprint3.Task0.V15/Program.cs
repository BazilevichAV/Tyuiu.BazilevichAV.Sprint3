using Tyuiu.BazilevichAV.Sprint3.Task0.V15.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #3                                               *");
Console.WriteLine("* Тема: Оператор цикла for                                *");
Console.WriteLine("* Задание #0                                              *");
Console.WriteLine("* Вариант #15                                             *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Написать программу используя цикл for, которая вычисляет*");
Console.WriteLine("* сумму ряда по формуле, при t = 0,7                      *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

double value = 0.7;
int startValue = 1;
int stopValue = 10;

Console.WriteLine("Переменная X = " + value);
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));
Console.ReadKey();