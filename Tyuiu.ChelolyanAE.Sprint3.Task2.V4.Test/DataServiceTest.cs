using Tyuiu.ChelolyanAE.Sprint3.Task2.V4.Lib;

namespace Tyuiu.ChelolyanAE.Sprint3.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 9;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 0.021;
            Assert.AreEqual(wait, res);
        }
    }
}