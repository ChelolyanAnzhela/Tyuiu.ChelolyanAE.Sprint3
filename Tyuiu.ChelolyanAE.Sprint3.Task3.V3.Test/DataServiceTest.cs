using Tyuiu.ChelolyanAE.Sprint3.Task3.V3.Lib;

namespace Tyuiu.ChelolyanAE.Sprint3.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMinCharCount()
        {
            DataService ds = new DataService();
            string str = "cvbmzff orffgtrr dkfvfffdr";
            char item = 'f';
            int res = ds.GetMinCharCount(str, item);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}