using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SherenkovIR.Sprint2.Task3.V24.Lib
{
    public class DataService : ISprint2Task3V24
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 0)
            {
                y = x * Math.Pow((10 + Math.Sin(Math.Sqrt(x + 1))) / x, x);
            }
            else if (x == 0)
            {
                y = Math.Cos(x) + (12 / (x * x)); 
            }
            else if (x > -28 && x < 0) 
            {
                y = Math.Pow(1 + 1 / (x * x), x);
            }
            else 
            {
                y = x * x + 10 * x - (1.0 / x);
            }

            return Math.Round(y, 3);
        }

           
        
    }
}