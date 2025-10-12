using Tyuiu.SherenkovIR.Sprint2.Task6.V11.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #2| Выполнил: Шеренков И. Р. | ИБКСБ-25-1";
// Длинна строки 75 символов
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #2                                        *");
Console.WriteLine("* Тема:*  Получение результата на switch           *");
Console.WriteLine("* Задание #6                                       *");
Console.WriteLine("* Вариант #11                                      *");
Console.WriteLine("* Выполнил: Шеренков Иван Романович | ИБКСБ-25-1   *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("* Написать программу, которая использует           *");
Console.WriteLine("* сокращенную форму записи switch вычисляет        *");
Console.WriteLine("* требуемое значение и возвращает результат        *");

Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");

Console.WriteLine("Введите день: ");
int day = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите месяц: ");
int month = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите год: ");
int year = Convert.ToInt32(Console.ReadLine());

string res;
if ((year < 1) || (month < 1 || month > 12) || (day < 1 || day > 31))
{
    res = "Введено неверное значение";
}
else
{
    res = "Следующий день: " + ds.FindDateOfNextDay(year, month, day);
}
Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");
Console.WriteLine(res);

Console.ReadKey();