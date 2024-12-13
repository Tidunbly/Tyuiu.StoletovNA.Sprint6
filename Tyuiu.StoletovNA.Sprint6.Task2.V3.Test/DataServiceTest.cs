using Tyuiu.StoletovNA.Sprint6.Task2.V3.Lib;
namespace Tyuiu.StoletovNA.Sprint6.Task2.V3.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            var res = ds.GetMassFunction(start, end);
            double[] wait = new double[11] { -12.18, 16.03, 18.87, 4.96, -9.99, -2, 2.16, -7.54, -22.76, -20.45, 7.77 };

            CollectionAssert.AreEqual(res, wait);


        }
    }
}
