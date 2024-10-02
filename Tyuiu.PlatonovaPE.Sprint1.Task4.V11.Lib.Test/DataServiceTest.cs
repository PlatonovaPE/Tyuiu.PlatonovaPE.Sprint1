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
            double x = 5;
            double y = 5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0,001, res);
        }
    }
}