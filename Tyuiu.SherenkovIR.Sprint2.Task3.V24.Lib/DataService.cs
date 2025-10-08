using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SherenkovIR.Sprint2.Task3.V24.Lib
{
    public class DataService : ISprint2Task3V24
    {
        public double Calculate(double x)
        {
            double y = 0;
            if ( x > 0)
            {
                y = ((10 + Math.Sin(Math.Sqrt(x) + 1)) / x) + 1;
            }
            else
            {
                if (x == 0) 
                {
                   y = Math.Cos(x);
                }
                else
                {
                    if (x >= 0 || x <= -28)
                    {
                        y = 1 + 1 / (x * x);
                    }
                    else
                    {
                        if (x < -28)
                        {
                            y = x * x +10 * x - 1.0 / x;
                        }
                    }
                }
            }
            return Math.Round(y, 3);
        }
    }
}
