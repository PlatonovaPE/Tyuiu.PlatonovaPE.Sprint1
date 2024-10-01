using Tyuiu.PlatonovaPE.Sprint1.Task3.V9.Lib;

namespace Tyuiu.PlatonovaPE.Sprint1.Task3.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Исходные данные                                                              *");
            Console.WriteLine("********************************************************************************");

            int minutes = 150;


            Console.WriteLine("* Количество минут = " + minutes                                                 );
 
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Результат:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Время в часах = " + ds.ConvertMinutesToHours(minutes));

            Console.ReadLine();

        }
    }
}
