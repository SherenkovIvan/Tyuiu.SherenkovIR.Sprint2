using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SherenkovIR.Sprint2.Task2.V15.Lib
{
    public class DataService : ISprint2Task2V15
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((x >= 3) && (x <= 5) && (y >= 3 && y <= 4)) || ((x >= 9) && (x <= 12) && (y >= 3 && y <= 4)) || ((x >= 5) && (x <= 12) && (y == 5)))
            {     
                res = true;
            }
            else
            {
                 res = false;
            }
            return res;
        }       
    }
}
