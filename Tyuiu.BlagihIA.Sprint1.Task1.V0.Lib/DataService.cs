using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BlagihIA.Sprint1.Task1.V0.Lib
{
    public class DataService : ISprint1Task1V14
    {
        public double Calculate(double a, double b, double c)
        {
            return a * b / c + (a / (b + c));
        }
    }
}
