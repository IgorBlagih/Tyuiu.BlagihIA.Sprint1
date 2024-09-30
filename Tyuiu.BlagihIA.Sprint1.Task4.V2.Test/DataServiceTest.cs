using Tyuiu.BlagihIA.Sprint1.Task4.V2.Lib;
namespace Tyuiu.BlagihIA.Sprint1.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 8 ;
            double y = 4;
            var result = ds.Calculate(x , y);
            Assert.AreEqual(0.25, result);
        }
    }
}