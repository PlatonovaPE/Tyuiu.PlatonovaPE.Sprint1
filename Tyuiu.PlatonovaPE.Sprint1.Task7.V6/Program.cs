using Tyuiu.PlatonovaPE.Sprint1.Task7.V6.Lib;
namespace Tyuiu.PlatonovaPE.Sprint1.Task7.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Исходные данные                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("( 1 + 1/ X** 2) ** x - 12 * x ** 2 * y");


            double x, y;

            Console.WriteLine("Введите значение Х:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение У:");
            y = Convert.ToDouble(Console.ReadLine());




            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Результат:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadKey();

        }
    }
}
