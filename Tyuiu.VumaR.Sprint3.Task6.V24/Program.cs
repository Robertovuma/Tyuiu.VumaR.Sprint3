using Tyuiu.VumaR.Sprint3.Task6.V24.Lib;

namespace Tyuiu.VumaR.Sprint3.Task6.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      *");
            Console.WriteLine("*************************************************************************");
            int startValue = 17;
            int stopValue = 26;
            Console.WriteLine("Старт шага первой суммы ряда = " + startValue);
            Console.WriteLine("Конец шага первой суммы ряда =  " + stopValue);



            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
