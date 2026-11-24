using Tyuiu.RogovichID.Sprint2.Task4.V6.Lib;
namespace Tyuiu.RogovichID.Sprint2.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            
            double x = 2;
            double y = 11;

            double res = ds.Calculate(x,y);

            double wait = 128;

            Assert.AreEqual(wait,res);
        }
    }
}
