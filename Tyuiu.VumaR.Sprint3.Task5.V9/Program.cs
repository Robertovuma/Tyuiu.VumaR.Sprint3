using Tyuiu.VumaR.Sprint3.Task5.V9.Lib;


namespace Tyuiu.VumaR.Sprint3.Task5.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 14;
            Console.WriteLine("Переменная X = " + x);
            Console.WriteLine("Старт шага 1 = " + startValue1);
            Console.WriteLine("Старт шага 2 = " + startValue2);
            Console.WriteLine("Конец шага 1 = " + stopValue1);
            Console.WriteLine("Конец шага 2 = " + stopValue2);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine("Сумма ряда = " + res);
            Console.ReadKey();
        }
    }
}
