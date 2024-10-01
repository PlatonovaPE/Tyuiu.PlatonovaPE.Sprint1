using Tyuiu.PlatonovaPE.Sprint1.Task3.V9.Lib;

namespace Tyuiu.PlatonovaPE.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int minutes = 60;
            var res = ds.ConvertMinutesToHours(minutes);
            Assert.AreEqual(2.30, res);
        }
    }
}