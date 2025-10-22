using Tyuiu.BazilevichAV.Sprint3.Task1.V5.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #3                                               *");
Console.WriteLine("* Тема: Оператор цикла while                              *");
Console.WriteLine("* Задание #1                                              *");
Console.WriteLine("* Вариант #5                                              *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Написать программу используя цикл for, которая вычисляет*");
Console.WriteLine("* сумму ряда по формуле                                   *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

double value = 5;
int startValue = 1;
int stopValue = 10;

Console.WriteLine("Переменная X = " + value);
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(startValue, stopValue));
Console.ReadKey();