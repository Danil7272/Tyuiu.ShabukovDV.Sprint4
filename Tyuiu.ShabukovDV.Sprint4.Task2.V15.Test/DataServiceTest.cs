using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabukovDV.Sprint4.Task2.V15.Lib;

namespace Tyuiu.ShabukovDV.Sprint4.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 8, 2, 7, 5, 0, 7, 4, 7, 5, 7 };

            int res = ds.Calculate(numsArray);
            int wait = 14;

            Assert.AreEqual(wait, res);
        }
    }
}
