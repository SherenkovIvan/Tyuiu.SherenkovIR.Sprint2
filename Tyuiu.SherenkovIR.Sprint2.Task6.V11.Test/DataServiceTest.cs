using Tyuiu.SherenkovIR.Sprint2.Task6.V11.Lib;
namespace Tyuiu.SherenkovIR.Sprint2.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("2024-1-1", ds.FindDateOfNextDay(2023, 12, 31));
            Assert.AreEqual("2023-3-1", ds.FindDateOfNextDay(2023, 2, 28));
            Assert.AreEqual("2023-5-1", ds.FindDateOfNextDay(2023, 4, 30));
            Assert.AreEqual("2023-5-16", ds.FindDateOfNextDay(2023, 5, 15));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(-1, 1, 1); 
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(2023, 13, 1); 
            });
        }
    }
}
