using Tyuiu.PlatonovaPE.Sprint1.Task6.V3.Lib;
namespace Tyuiu.PlatonovaPE.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string StrTest = "������ ��� ����";
            DataService ds = new DataService();
            string res = ds.LastLetterWord(StrTest);
            string wait = "���";
            Assert.AreEqual(wait, res);

        }
    }
}