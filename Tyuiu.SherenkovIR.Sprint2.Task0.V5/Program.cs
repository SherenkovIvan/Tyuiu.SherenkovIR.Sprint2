using Tyuiu.SherenkovIR.Sprint2.Task0.V5.Lib;

DataService ds = new DataService();
Console.Title = "Спринт #0| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
// Длинна строки 75 символов
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #2                                        *");
Console.WriteLine("* Тема: Создание итогового решения по спринту      *");
Console.WriteLine("* Задание #1                                       *");
Console.WriteLine("* Вариант #5                                       *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("* Написать программу из операций сравнений         *");
Console.WriteLine("*(==, !=, <, >, <=, >=, последовательность операций*");
Console.WriteLine("* не должна нарушаться) и арифметических выражений,*");
Console.WriteLine("* которая вернет логическую последовательность     *");
Console.WriteLine("* (массив) ((False, True, True, True, False, True) *");
Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");

int x = 105;
int y = 223;
bool[] res = new bool[6];
res = ds.GetCompareOperations(x, y);

Console.WriteLine("X = " + x);
Console.WriteLine("Y = " + y);

Console.WriteLine("****************************************************");
Console.WriteLine("*РЕЗУЛЬТАТ:                                        *");
Console.WriteLine("****************************************************");

for (int i=0; i<6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();