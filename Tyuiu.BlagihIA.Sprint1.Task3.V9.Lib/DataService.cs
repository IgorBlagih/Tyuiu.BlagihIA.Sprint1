using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BlagihIA.Sprint1.Task3.V9.Lib
{
    public class DataService : ISprint1Task3V9
    {
        public double ConvertMinutesToHours(int minutes)
        {
            return minutes / 60 ;
        }

        public double ConvertMinutesToHours2(int minutes)
        {
            return minutes % 60;
        }



    }
}
