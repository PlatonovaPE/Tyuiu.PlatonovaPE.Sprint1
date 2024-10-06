using System.Numerics;
using Tyuiu.PlatonovaPE.Sprint1.Task5.V1.Lib;

namespace Tyuiu.PlatonovaPE.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x1 = 18;
            double y1 = 29;
            double x2 = 16;
            double y2 = 26;
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            int result =  Convert.ToInt32(res);
            Assert.AreEqual(9, result);

        }
    }
}