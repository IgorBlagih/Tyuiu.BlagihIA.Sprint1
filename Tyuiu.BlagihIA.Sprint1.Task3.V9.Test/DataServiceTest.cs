using Tyuiu.BlagihIA.Sprint1.Task3.V9.Lib;
namespace Tyuiu.BlagihIA.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int m = 150;
            int h;
            var res = ds.ConvertMinutesToHours(m);
            Assert.AreEqual(2 ,res);
        }
    }
}