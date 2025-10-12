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
            Assert.AreEqual("01-01-2024", ds.FindDateOfNextDay(2023, 12, 31));
            Assert.AreEqual("01-03-2023", ds.FindDateOfNextDay(2023, 2, 28));
            Assert.AreEqual("01-05-2023", ds.FindDateOfNextDay(2023, 4, 30));
            Assert.AreEqual("16-05-2023", ds.FindDateOfNextDay(2023, 5, 15));

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
