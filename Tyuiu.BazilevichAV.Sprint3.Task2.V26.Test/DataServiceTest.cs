using Tyuiu.BazilevichAV.Sprint3.Task2.V26.Lib;
namespace Tyuiu.BazilevichAV.Sprint3.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 1555.992;

            Assert.AreEqual(wait, res);
        }
    }
}

