using Tyuiu.PlatonovaPE.Sprint1.Task6.V3.Lib;
namespace Tyuiu.PlatonovaPE.Sprint1.Task6.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Исходные данные                                                              *");
            Console.WriteLine("********************************************************************************");

           
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Результат:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine(ds.LastLetterWord(str));

            Console.ReadKey();

        }
    }
}
