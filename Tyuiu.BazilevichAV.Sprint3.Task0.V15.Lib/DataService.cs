using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BazilevichAV.Sprint3.Task0.V15.Lib
{
    public class DataService : ISprint3Task0V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + ((Math.Pow(0.7,i + 2/(i+1))) * Math.Sin(0.7) * value);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}