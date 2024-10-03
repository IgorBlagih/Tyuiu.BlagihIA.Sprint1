using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BlagihIA.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {

        public string SymbolCode(string value)
        {
            char x = value[0];
            int y = Convert.ToInt32(x);
            string res = Convert.ToString(y);
            return res;
        }
    }
}
