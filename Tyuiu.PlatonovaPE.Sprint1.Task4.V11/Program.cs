using Tyuiu.PlatonovaPE.Sprint1.Task4.V11.Lib;

namespace Tyuiu.PlatonovaPE.Sprint1.Task4.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Исходные данные                                                              *");
            Console.WriteLine("********************************************************************************");

            int x, y;


            Console.WriteLine("Введите значение Х:");

            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");

            y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Результат:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine(" Math.Atan(2) / Math.Exp(2) = " + ds.Calculate(x, y));

            Console.ReadKey();

        }
    }
}
