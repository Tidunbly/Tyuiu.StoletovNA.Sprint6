using Tyuiu.StoletovNA.Sprint6.Task4.V25.Lib;
namespace Tyuiu.StoletovNA.Sprint6.Task4.V25.Test {
    [TestClass]
    public sealed class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] valueArray = ds.GetMassFunction(startValue, stopValue);
            double[] waitArray = { 4.67, 0.43, -8.26, -9.87, -3.98, 1, 0.02, -1.87, 3.74, 16.43, 24.67 };
            CollectionAssert.AreEqual(valueArray, waitArray);
        }
    }
}
