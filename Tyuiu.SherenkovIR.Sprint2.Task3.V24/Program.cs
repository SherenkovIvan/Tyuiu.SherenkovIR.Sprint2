using Tyuiu.SherenkovIR.Sprint2.Task3.V24.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #2| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
// Длинна строки 75 символов
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #2                                        *");
Console.WriteLine("* Тема:* Вложенные операторы if - else             *");
Console.WriteLine("* Задание #3                                       *");
Console.WriteLine("* Вариант #24                                      *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое  *");
Console.WriteLine("* значение Y с использованием вложенных операторов *");
Console.WriteLine("* if-else, где пользователь вводит значение        *");
Console.WriteLine("* переменной X с клавиатуры. Ответ окгруглить до 3 *");
Console.WriteLine("* знаков после запятой.                            *");

Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");

Console.WriteLine("Введите значение переменной X: ");
double x = Convert.ToDouble(Console.ReadLine());
double res = ds.Calculate(x);

Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");

Console.WriteLine(" Значение функции = " + res);

Console.ReadKey ();