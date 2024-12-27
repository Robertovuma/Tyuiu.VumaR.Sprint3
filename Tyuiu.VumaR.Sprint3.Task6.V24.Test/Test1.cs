
using Tyuiu.VumaR.Sprint3.Task6.V24.Lib;
namespace Tyuiu.VumaR.Sprint3.Task6.V24.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 17;
            int stopValue = 26;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 41;
            Assert.AreEqual(wait, res);
        }
    }
}
