using Tyuiu.SherenkovIR.Sprint2.Task4.V11.Lib;
namespace Tyuiu.SherenkovIR.Sprint2.Task4.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 22;
            double y = 20;
            double res = ds.Calculate(x,y);
            double wait = 3891794346.101;
            Assert.AreEqual(wait, res );
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 7;
            double y = 16;
            double res = ds.Calculate(x, y);
            double wait = 100500885.959;
            Assert.AreEqual(wait, res);
        }
    }
}
