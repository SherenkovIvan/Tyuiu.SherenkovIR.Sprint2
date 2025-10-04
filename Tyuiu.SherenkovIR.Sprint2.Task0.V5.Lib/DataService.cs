using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SherenkovIR.Sprint2.Task0.V5.Lib
{
    public class DataService : ISprint2Task0V5
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 11 == y;
            res[1] = x != y;
            res[2] = x < y;
            res[3] = x + 200 > y;
            res[4] = x + 200 <= y;
            res[5] = x + 300 >= y;

            return res;
        }
    }
}
