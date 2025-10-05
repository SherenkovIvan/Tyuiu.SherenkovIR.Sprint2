using Tyuiu.SherenkovIR.Sprint2.Task1.V3.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #0| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
// Длинна строки 75 символов
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #2                                        *");
Console.WriteLine("* Тема: Создание итогового решения по спринту      *");
Console.WriteLine("* Задание #1                                       *");
Console.WriteLine("* Вариант #3                                       *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("* Написать программу из операций сравнений         *");
Console.WriteLine("*(==, !=, <, >, <=, >=, последовательность операций*");
Console.WriteLine("* можно чередовать, но использовать один раз в     *");
Console.WriteLine("* выражении)  и логических операций (|, &, ||, &&,!*");   
Console.WriteLine("*^,последовательность операций не должна нарушаться*");
Console.WriteLine("*, а также арифметических выражений,которая вернет *");
Console.WriteLine("*логическую последовательность                     *");
Console.WriteLine("* (массив)(True, False, False, False, False, False)*");

int a = 185;
int b = 316;
int c = 134;
int d = 134;
bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);

Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");

Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = " + c);
Console.WriteLine("d = " + d);

Console.WriteLine("****************************************************");
Console.WriteLine("*РЕЗУЛЬТАТ:                                        *");
Console.WriteLine("****************************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();

