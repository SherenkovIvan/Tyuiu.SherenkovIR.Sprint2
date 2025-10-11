using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SherenkovIR.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            if (k < 1 || k > 365)
            {
                throw new ArgumentException($"День должен быть от 1 до 365. Значение {k}");
            }
            int DayOfWeek = (k - 1) % 7 + 1;

            string res;
                switch (DayOfWeek)
                {
                    case 1:
                        res = "Понедельник";
                        break;
                    case 2:
                        res = "Вторник";
                        break;
                    case 3:
                        res = "Среда";
                        break;
                    case 4:
                        res = "Четверг";
                        break;
                    case 5:
                        res = "Пятница";
                        break;
                    case 6:
                        res = "Суббота";
                        break;
                    case 7:
                        res = "Воскресенье";
                        break;
                    default:
                        throw new ArgumentException($"Некорректный расчет дня недели: {DayOfWeek}");
                }
                return res;
            
            
        }
    }
}
