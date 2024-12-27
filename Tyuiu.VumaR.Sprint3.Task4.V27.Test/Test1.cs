using Tyuiu.VumaR.Sprint3.Task4.V27.Lib;

namespace Tyuiu.VumaR.Sprint3.Task4.V27.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = -44.313;
            Assert.AreEqual(wait, res);
        }
    }
}
