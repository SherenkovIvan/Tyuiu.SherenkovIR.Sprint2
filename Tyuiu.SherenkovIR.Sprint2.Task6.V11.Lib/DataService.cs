using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SherenkovIR.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            if (g < 1) throw new ArgumentException("Год не может быть отрицательным");
            if (m < 1 || m > 12) throw new ArgumentException("Месяц должен быть от 1 до 12");
            if (n < 1 || n > 31) throw new ArgumentException("День должен быть от 1 до 31");

            int year = g;
            int month = m;
            int day = n + 1;

            int maxDays = month switch
            {
                2 => 28,
                4 or 6 or 9 or 11 => 30,
                _ => 31
            };

            if (day > maxDays)
            {
                day = 1;
                month++;
                if (month > 12)
                {
                    month = 1;
                    year++;
                }
            }

            return $"{year}-{month}-{day}";
        }
    }
}
