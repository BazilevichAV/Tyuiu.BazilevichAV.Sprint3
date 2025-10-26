using Tyuiu.BazilevichAV.Sprint3.Task5.V21.Lib;
namespace Tyuiu.BazilevichAV.Sprint3.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 5;
            int stopValue1 = 10;
            int stopValue2 = 20;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = 484.727;

            Assert.AreEqual(wait, res);
        }
    }
}