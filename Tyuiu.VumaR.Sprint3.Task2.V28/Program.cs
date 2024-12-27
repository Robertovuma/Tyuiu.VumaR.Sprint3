
using Tyuiu.VumaR.Sprint3.Task2.V28.Lib;


namespace Tyuiu.VumaR.Sprint3.Task2.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Написать программу используя цикл do...while, которая вычисляет         #");
            Console.WriteLine("# произведение ряда по формуле                                            #");
            Console.WriteLine("#                                                                         #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            int startValue = 1;
            int stopValue = 9;

            Console.WriteLine("Старт шага: " + startValue);
            Console.WriteLine("Конец шага: " + stopValue);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Произведение ряда: " + ds.GetMultiplySeries(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
