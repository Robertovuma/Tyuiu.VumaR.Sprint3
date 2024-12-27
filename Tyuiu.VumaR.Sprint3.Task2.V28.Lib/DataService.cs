
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VumaR.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multSeries = 1;

            do
            {
                multSeries *= (Math.Pow(2, startValue) / (startValue + 1)) * Math.Cos(1.8);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(multSeries, 3);
        }
    }
}
