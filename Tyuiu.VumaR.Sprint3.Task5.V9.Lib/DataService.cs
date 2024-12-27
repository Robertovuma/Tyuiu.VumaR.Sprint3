
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VumaR.Sprint3.Task5.V9.Lib
{
    public class DataService : ISprint3Task5V9
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double SumSum = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int j = startValue2; j <= stopValue2; j++)
                {
                    SumSum = SumSum + (1 / Math.Sin(j)) + x;
                }
            }
            return Math.Round(SumSum, 3);
        }
    }
}
