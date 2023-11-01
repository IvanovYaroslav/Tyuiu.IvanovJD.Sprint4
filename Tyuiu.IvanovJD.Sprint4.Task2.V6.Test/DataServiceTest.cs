using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint4.Task2.V6.Lib;

namespace Tyuiu.IvanovJD.Sprint4.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 ,3,2,2};
            int res = ds.Calculate(numsArray);
            int wait = 6144;
            Assert.AreEqual(wait, res);

        }
    }
}
