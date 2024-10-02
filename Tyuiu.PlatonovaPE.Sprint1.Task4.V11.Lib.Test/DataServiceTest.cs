using System;
using Tyuiu.PlatonovaPE.Sprint1.Task4.V11.Lib;

namespace Tyuiu.PlatonovaPE.Sprint1.Task4.V11.Lib.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0, 062, res);
        }
    }
}