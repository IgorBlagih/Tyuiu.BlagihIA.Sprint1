using Tyuiu.BlagihIA.Sprint1.Task7.V10.Lib;
namespace Tyuiu.BlagihIA.Sprint1.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 13;
            var res = ds.Calculate(x);
            Assert.AreEqual(0.556, res);
        }
    }
}