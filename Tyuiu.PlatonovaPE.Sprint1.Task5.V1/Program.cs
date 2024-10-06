using Tyuiu.PlatonovaPE.Sprint1.Task5.V1.Lib;

namespace Tyuiu.PlatonovaPE.Sprint1.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Исходные данные                                                              *");
            Console.WriteLine("********************************************************************************");

          
            Console.WriteLine("Введите значение Х1:");

            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y1:");

            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Х2:");

            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y2:");

            double y2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Результат:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine(Convert.ToDouble(ds.DistanceBetweenDots(x1, y1, x2, y2)));

            Console.ReadKey();

        }
    }
}
