using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YangolenkoDS.Sprint3.Task2.V5.Lib;

namespace Tyuiu.YangolenkoDS.Sprint3.Task2.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Янголенко Д. С. | АСОиУб-23-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                         *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                                     *");
            Console.WriteLine("* Задание #2                                                                        *");
            Console.WriteLine("* Вариант #5                                                                        *");
            Console.WriteLine("* Выполнил: Янголенко Данил Сергеевич | АСОиУб-23-1                                 *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу используя цикл do-while,которая вычисляет сумму ряда по формуле*");
            Console.WriteLine("* при а = 0,75                                                                      *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            double value = 0.75;
            int startValue = 1;
            int stopValue = 20;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            Console.WriteLine("Переменная A = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Сумма ряда = " + res);
            Console.ReadKey();
        }
    }
}
