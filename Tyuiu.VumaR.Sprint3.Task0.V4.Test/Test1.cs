
using Tyuiu.VumaR.Sprint3.Task0.V4.Lib;
namespace Tyuiu.VumaR.Sprint3.Task0.V4.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 7;

            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 28.699;

            Assert.AreEqual(wait, res);
        }
    }
}
