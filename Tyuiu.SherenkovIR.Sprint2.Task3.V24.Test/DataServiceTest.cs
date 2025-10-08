using Tyuiu.SherenkovIR.Sprint2.Task3.V24.Lib;
namespace Tyuiu.SherenkovIR.Sprint2.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 6.332;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0;
            Assert.AreEqual(wait, res);

        }
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -24;
            double res = ds.Calculate(x);
            double wait = 1.042;
            Assert.AreEqual(wait, res);

        }
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -30;
            double res = ds.Calculate(x);
            double wait = -1199.966;
            Assert.AreEqual(wait, res);

        }
    }
}
