using Tyuiu.BazilevichAV.Sprint3.Task0.V15.Lib;
namespace Tyuiu.BazilevichAV.Sprint3.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 2;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 2.651;

            Assert.AreEqual(wait, res);
        }
    }
}

