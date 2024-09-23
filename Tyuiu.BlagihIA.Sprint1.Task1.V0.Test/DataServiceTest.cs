using Tyuiu.BlagihIA.Sprint1.Task1.V0.Lib;
namespace Tyuiu.BlagihIA.Sprint1.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 4.0;
            double b = 1.0;
            double c = 4.0;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(1.8, res);
        }
    }
}