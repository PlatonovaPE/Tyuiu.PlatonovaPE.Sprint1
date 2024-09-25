using Tyuiu.PlatonovaPE.Sprint1.Task1.V3.Lib;
namespace Tyuiu.PlatonovaPE.Sprint1.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.00;
            double y = 1.00;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3.2, res);
        }
    }
}