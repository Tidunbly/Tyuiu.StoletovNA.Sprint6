using System;
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
            double[] wait = new double[2];

            Assert.AreEqual(wait, res);

        }
    }
}