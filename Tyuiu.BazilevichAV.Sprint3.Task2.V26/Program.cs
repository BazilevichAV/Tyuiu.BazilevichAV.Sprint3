using Tyuiu.BazilevichAV.Sprint3.Task2.V26.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #3                                               *");
Console.WriteLine("* Тема: Оператор цикла while                              *");
Console.WriteLine("* Задание #2                                              *");
Console.WriteLine("* Вариант #26                                             *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Написать программу используя цикл do...while, которая   *");
Console.WriteLine("* вычисляет сумму ряда по формуле, при х=0,25             *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

double value = 0.25;
int startValue = 1;
int stopValue = 10;

Console.WriteLine("Переменная X = " + value);
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
Console.ReadKey();