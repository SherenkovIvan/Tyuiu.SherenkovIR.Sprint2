using Tyuiu.SherenkovIR.Sprint2.Task7.V14.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #2| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
// Длинна строки 75 символов
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #2                                        *");
Console.WriteLine("* Тема:Оператор IF - полная и краткаяя форма записи*");
Console.WriteLine("* Задание #7                                       *");
Console.WriteLine("* Вариант #14                                      *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("* Написать программу на C#, которая запрашивает    *");
Console.WriteLine("* исходные данные (вещественные значения) и        *");
Console.WriteLine("* вычисляет, находится ли точка с координатами     *");
Console.WriteLine("* X,Y в заштрихованной области.                    *");

Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");

Console.WriteLine("Введите значение переменной X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение переменной Y: ");
double y = Convert.ToDouble(Console.ReadLine());

bool res = ds.CheckDotInShadedArea(x, y);

Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");

if (res)
{
    Console.WriteLine("Точка находиться в заштрихованной области");
}
else
{
    Console.WriteLine("Точка не находиться в заштрихованной области");
}
Console.ReadKey();