﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YangolenkoDS.Sprint3.Task3.V14.Lib
{
    public class DataService : ISprint3Task3V14
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            foreach (char c in value)
            {
                if (c == 'd')
                {
                    value = value.Replace(c, '’');
                }
            }
            return value;
        }
    }
}
