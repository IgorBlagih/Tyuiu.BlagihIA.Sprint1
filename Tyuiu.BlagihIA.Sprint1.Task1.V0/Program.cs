using Tyuiu.BlagihIA.Sprint1.Task1.V14.Lib;
namespace Tyuiu.BlagihIA.Sprint1.Task1.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Благих И.А | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки  работы в С#                                       *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Благих Игорь Александрович | ИИПб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу которая вычисляет выражение a * b / c + (a / (b + c))*");
            Console.WriteLine("* и выводит результат на экран                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");



            double a, b, c;

            Console.WriteLine("Введите а:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите b:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите c:");
            c = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(a, b, c));
            Console.ReadKey();


            
        }
    }
}
