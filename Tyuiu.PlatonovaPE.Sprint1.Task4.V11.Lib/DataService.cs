using tyuiu.cources.programming.interfaces.Sprint1;

using Tyuiu.PlatonovaPE.Sprint1.Task4.V11.Lib;

namespace Tyuiu.PlatonovaPE.Sprint1.Task4.V11.Lib
{
    public class DataService : ISprint1Task4V11
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round((Math.Atan(5) / Math.Exp(5)), 3);
            return res;
        }
    }
}
