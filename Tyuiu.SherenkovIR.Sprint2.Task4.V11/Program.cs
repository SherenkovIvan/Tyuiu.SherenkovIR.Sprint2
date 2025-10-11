using Tyuiu.SherenkovIR.Sprint2.Task4.V11.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #2| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
// Длинна строки 75 символов
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #2                                        *");
Console.WriteLine("* Тема:* Тернарный оператор                        *");
Console.WriteLine("* Задание #4                                       *");
Console.WriteLine("* Вариант #11                                      *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое  *");
Console.WriteLine("* значение с использованием тернарного оператора   *");
Console.WriteLine("* где пользователь вводит значение переменных      *");
Console.WriteLine("* x, y с клавиатуры.         Ответ окгруглить до 3 *");
Console.WriteLine("* знаков после запятой.                            *");

Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");

Console.WriteLine("Введите значение переменной X");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение переменной y");
double y = Convert.ToDouble(Console.ReadLine());

double res = ds.Calculate(x, y);

Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");
Console.WriteLine("Значение функции = " + res);

Console.ReadKey();