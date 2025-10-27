using Tyuiu.BazilevichAV.Sprint3.Task7.V26.Lib;
namespace Tyuiu.BazilevichAV.Sprint3.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 20.19;
            valueWaitArray[1] = 17.21;
            valueWaitArray[2] = 14.13;
            valueWaitArray[3] = 11.02;
            valueWaitArray[4] = 8.06;
            valueWaitArray[5] = 7.00;
            valueWaitArray[6] = 0.77;
            valueWaitArray[7] = -1.55;
            valueWaitArray[8] = -4.21;
            valueWaitArray[9] = -7.03;
            valueWaitArray[10] = -10.00;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}