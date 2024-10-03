using Tyuiu.BlagihIA.Sprint1.Task6.V1.Lib;
namespace Tyuiu.BlagihIA.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "1";
            var res = ds.SymbolCode(value);
            Assert.AreEqual("49", res);
        }
    }
}