using Tyuiu.RogovichID.Sprint2.Task3.V10.Lib;
namespace Tyuiu.RogovichID.Sprint2.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = -1;

            Assert.AreEqual(Math.Round(wait,3), res);

        }
    }
}
