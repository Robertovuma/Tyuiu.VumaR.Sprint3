﻿
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VumaR.Sprint3.Task6.V24.Lib
{
    public class DataService : ISprint3Task6V24
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int sum = 1;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int i = 1; i * i < x; i++)
                {
                    if (x % i == 0)
                        sum = sum + 2;
                    if (i * i == x)
                        sum = sum + 1;
                }
            }
            return sum;
        }
    }
}
