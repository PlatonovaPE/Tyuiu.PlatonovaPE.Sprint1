using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PlatonovaPE.Sprint1.Task3.V9.Lib
{
    public class DataService : ISprint1Task3V9
    {
        public double ConvertMinutesToHours(int minutes)
        {
            return Math.Floor(TimeSpan.FromMinutes(minutes).TotalHours);
        }
    }
}
