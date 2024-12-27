using Tyuiu.VumaR.Sprint3.Task1.V8.Lib;
namespace Tyuiu.VumaR.Sprint3.Task1.V8.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 7;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 558.503;
            Assert.AreEqual(wait, res);
        }
    }
}
