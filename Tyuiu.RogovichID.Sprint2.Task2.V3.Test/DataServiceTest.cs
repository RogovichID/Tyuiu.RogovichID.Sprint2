using Tyuiu.RogovichID.Sprint2.Task2.V3.Lib;
namespace Tyuiu.RogovichID.Sprint2.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 5;
            int y = 7;

            bool res = ds.CheckDotInShadedArea(x,y);
            bool wait = false;

            Assert.AreEqual(wait, res);
        }
    }
}
