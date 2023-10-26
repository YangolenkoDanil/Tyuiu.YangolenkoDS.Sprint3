using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YangolenkoDS.Sprint3.Task6.V20.Lib;

namespace Tyuiu.YangolenkoDS.Sprint3.Task6.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Янголенко Д. С. | АСОиУб-23-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                         *");
            Console.WriteLine("* Тема:Вложенные циклы                                                              *");
            Console.WriteLine("* Задание #6                                                                        *");
            Console.WriteLine("* Вариант #20                                                                       *");
            Console.WriteLine("* Выполнил: Янголенко Данил Сергеевич | АСОиУб-23-1                                 *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих числовому       *");
            Console.WriteLine("* отрезку [20, 32] количество всех делителей меньше 12                              *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            int startValue = 20;
            int stopValue = 32;

            double res = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine("Начало отрезка - " + startValue);
            Console.WriteLine("Конец отрезка - " + stopValue);
            

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Количество делителей - " + res);
            Console.ReadKey();
        }
    }
}
