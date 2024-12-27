﻿
using Tyuiu.VumaR.Sprint3.Task2.V28.Lib;

namespace Tyuiu.VumaR.Sprint3.Task2.V28.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 9;

            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = -15.642;

            Assert.AreEqual(wait, res);
        }
    }
}
