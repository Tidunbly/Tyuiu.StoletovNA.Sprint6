﻿using System;
using Tyuiu.StoletovNA.Sprint6.Task1.V20.Lib;
namespace Tyuiu.StoletovNA.Sprint6.Task1.V20.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            var res = ds.GetMassFunction(start, end);
            double[] wait = new double[11] { -27.22, -22.25, -16.66, -11.04, -6.13, -3.00, 4.84, 8.86, 14.43, 20.18, 25.24 };

            CollectionAssert.AreEqual(res, wait);

        }
    }
}