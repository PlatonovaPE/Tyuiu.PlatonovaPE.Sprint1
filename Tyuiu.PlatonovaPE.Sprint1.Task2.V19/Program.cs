using Tyuiu.PlatonovaPE.Sprint1.Task2.V19.Lib;

namespace Tyuiu.PlatonovaPE.Sprint1.Task1.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Платонова.П.Е| ИСПб-24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                    *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                             *");
            Console.WriteLine("* Задание #0                                                                   *");
            Console.WriteLine("* Вариант #27                                                                  *");
            Console.WriteLine("* Выполнила: Платонова.П.Е | ИСПб-24-1                                         *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                =                    *");
            Console.WriteLine("*Написать программу,выполняет указанные расчёты и печатает результат на экране.*");
            Console.WriteLine("* и печатает результат на экране.                                              *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            int x;
            Console.WriteLine("*Введите значение Х: ***********************************************************");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Расстояние в метрах Х =" + ds.ConvertInchToKm(x));
            Console.ReadLine();

        }
    }
}