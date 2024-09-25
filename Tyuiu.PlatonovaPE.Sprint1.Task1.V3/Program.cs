using Tyuiu.PlatonovaPE.Sprint1.Task1.V3.Lib;

namespace Tyuiu.PlatonovaPE.Sprint1.Task1.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Платонова.П.Е| ИСПб-24-1";
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                      *");
            Console.WriteLine("* Тема: Организация ввода и вывода в консольных приложениях                      *");
            Console.WriteLine("* Задание #0                                                                     *");
            Console.WriteLine("* Вариант #27                                                                    *");
            Console.WriteLine("* Выполнила: Платонова.П.Е | ИСПб-24-1                                           *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные,         *");
            Console.WriteLine("* вычисляет результат по формуле (x - y) / (x + 3) + 3 и печатает его на экране. *");
            Console.WriteLine("*                                                                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            double x, y; 
            Console.WriteLine("Ввeдите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ввeдите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();

        }
    }
}