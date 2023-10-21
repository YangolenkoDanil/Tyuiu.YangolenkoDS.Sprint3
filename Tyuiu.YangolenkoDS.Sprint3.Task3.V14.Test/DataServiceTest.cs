﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YangolenkoDS.Sprint3.Task3.V14.Lib;

namespace Tyuiu.YangolenkoDS.Sprint3.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharInString()
        {
            DataService ds = new DataService();
            string value = "dgt ghedd bed";
            char replaceable = 'd';
            char replacement = '’';

            string res = ds.ReplaceCharInString(value, replaceable, replacement);
            string wait = "’gt ghe’’ be’";
            Assert.AreEqual(wait, res);
        }
    }
}
