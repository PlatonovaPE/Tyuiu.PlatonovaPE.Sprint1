using Tyuiu.PlatonovaPE.Sprint1.Task2.V19.Lib;
namespace Tyuiu.PlatonovaPE.Sprint1.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            var res = ds.ConvertInchToKm(x);
            Assert.AreEqual(10.27, res);
        }
    }
}