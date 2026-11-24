using Tyuiu.RogovichID.Sprint2.Task5.V5.Lib;
namespace Tyuiu.RogovichID.Sprint2.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardValue()
        {
            DataSerivce ds = new DataSerivce();

            int value = 11;

            string res = ds.FindCardValue(value);
            string wait = "валет";

            Assert.AreEqual(wait, res);
        }
    }
}
