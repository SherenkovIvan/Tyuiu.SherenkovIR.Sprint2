using Tyuiu.SherenkovIR.Sprint2.Task5.V15.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #2| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
// Длинна строки 75 символов
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #2                                        *");
Console.WriteLine("* Тема:*  Оператор Switch                          *");
Console.WriteLine("* Задание #5                                       *");
Console.WriteLine("* Вариант #15                                      *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("* Написать программу, которая использует оператор  *");
Console.WriteLine("* Switch вычисляет требуемое значение и возвращает *");
Console.WriteLine("* результат.                                       *");

Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");

Console.WriteLine("Введите значение дня недели: ");
int numDay = Convert.ToInt32(Console.ReadLine());

string res;
if ((numDay < 1) || (numDay > 365))
{
    res = "Введенно неверное значение";
}
else
{
    res = "Это день: "  + ds.FindDayName(numDay);
}
Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");

Console.WriteLine(res);

Console.ReadKey();