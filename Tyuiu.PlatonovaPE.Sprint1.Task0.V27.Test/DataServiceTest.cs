using Tyuiu.PlatonovaPE.Sprint1.Task0.V27.Lib;

namespace Tyuiu.PlatonovaPE.Sprint1.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(22, res);
        }
    }
}