﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YangolenkoDS.Sprint3.Task6.V20.Lib
{
    public class DataService : ISprint3Task6V20
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sumSeries = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    if (i % j == 0)
                    {
                        sumSeries += 1;
                    }
                }    
            }
            return sumSeries;
        }
    }
}
