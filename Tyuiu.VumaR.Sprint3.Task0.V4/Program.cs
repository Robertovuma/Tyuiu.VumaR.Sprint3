
using Tyuiu.VumaR.Sprint3.Task0.V4.Lib;


namespace Tyuiu.VumaR.Sprint3.Task0.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 1;
            int stopValue = 7;

            Console.WriteLine("Начало шага=" + startValue);
            Console.WriteLine("Конец шага=" + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда=" + ds.GetMultiplySeries(startValue, stopValue));

            Console.ReadKey();
        }
    }
}
