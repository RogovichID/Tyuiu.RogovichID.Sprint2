using Tyuiu.RogovichID.Sprint2.Task7.V12.Lib;
namespace Tyuiu.RogovichID.Sprint2.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.5;
            double y = 0.5;
            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(true, res);
        }
    }
}
