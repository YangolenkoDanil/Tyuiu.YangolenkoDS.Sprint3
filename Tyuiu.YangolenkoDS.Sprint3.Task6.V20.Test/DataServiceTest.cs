using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YangolenkoDS.Sprint3.Task6.V20.Lib;

namespace Tyuiu.YangolenkoDS.Sprint3.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 20;
            int stopValue = 32;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 42;

            Assert.AreEqual(wait, res);
        }
    }
}
