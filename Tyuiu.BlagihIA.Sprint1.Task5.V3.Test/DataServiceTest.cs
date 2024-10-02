using System.Runtime.CompilerServices;
using Tyuiu.BlagihIA.Sprint1.Task5.V3.Lib;
namespace Tyuiu.BlagihIA.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 1984;
            var res1 = ds.Calculate(k);
            Assert.AreEqual(9, res1);
            
        }
    }
}