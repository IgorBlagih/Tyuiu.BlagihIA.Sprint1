﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BlagihIA.Sprint1.Task7.V10.Lib
{
    public class DataService : ISprint1Task7V10
    {
        public double Calculate(double x)
        {
           return Math.Round(2 * (1 / Math.Tan(3 * x)) - (Math.Log(Math.Cos(x)) / (Math.Log(1 + Math.Pow(x,x)))),3);
        }
    }
}
