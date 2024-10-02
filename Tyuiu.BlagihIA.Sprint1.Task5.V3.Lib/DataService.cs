using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BlagihIA.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            string res = Convert.ToString(k);
            char a = res[^3];
            int bar = Convert.ToInt32(new string(a, 1));
            return bar;
        }
    }
}
