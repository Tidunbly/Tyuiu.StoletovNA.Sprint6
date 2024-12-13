using System;
using Tyuiu.StoletovNA.Sprint6.Task0.V30.Lib;
namespace Tyuiu.StoletovNA.Sprint6.Task0.V30.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 7.348;

            Assert.AreEqual(wait, res);
            
        }
    }
}