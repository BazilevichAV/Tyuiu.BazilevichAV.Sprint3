using System;
using Tyuiu.BazilevichAV.Sprint3.Task3.V24.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнила: Базилевич А.В. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #3                                               *");
Console.WriteLine("* Тема: Оператор цикла foreach                            *");
Console.WriteLine("* Задание #3                                              *");
Console.WriteLine("* Вариант #24                                             *");
Console.WriteLine("* Выполнила: Базилевич Алёна Владимировна | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Используя цикл foreach заменить буквы g  на * в строке: *");
Console.WriteLine("* gft hggt ntg                                            *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

string value = "gft hggt ntg";
char replaceable = 'g';
char replacement = '*';

Console.WriteLine("Исходная строка = " + value);
Console.WriteLine("Исходный символ = " + replaceable);
Console.WriteLine("Символ для замены = " + replacement);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine("Новая строка = " + ds.ReplaceCharInString(value, replaceable, replacement));
Console.ReadKey();