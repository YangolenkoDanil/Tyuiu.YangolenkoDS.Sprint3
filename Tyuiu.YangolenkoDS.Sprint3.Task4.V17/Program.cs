﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.YangolenkoDS.Sprint3.Task4.V17.Lib;

namespace Tyuiu.YangolenkoDS.Sprint3.Task4.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Янголенко Д. С. | АСОиУб-23-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                         *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                          *");
            Console.WriteLine("* Задание #4                                                                        *");
            Console.WriteLine("* Вариант #17                                                                       *");
            Console.WriteLine("* Выполнил: Янголенко Данил Сергеевич | АСОиУб-23-1                                 *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение функции       *");
            Console.WriteLine("* y=cos(x)/sin(x). При х = 0 прервать цикл. Полученные значения перемножать.        *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            Console.WriteLine("Старт шага " + startValue);
            Console.WriteLine("Стоп шага " + stopValue);
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Произведение ряда = " + res);
            Console.ReadKey();
        }
    }
}
