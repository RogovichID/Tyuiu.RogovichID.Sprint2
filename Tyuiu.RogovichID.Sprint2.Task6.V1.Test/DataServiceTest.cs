using Tyuiu.RogovichID.Sprint2.Task6.V1.Lib;
namespace Tyuiu.RogovichID.Sprint2.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthDaysCount()
        {
            DataService ds = new DataService();

            int value = 7;

            int res = ds.FindMonthDaysCount(value);

            int wait = 31;

            Assert.AreEqual(wait, res);
        }
    }
}
