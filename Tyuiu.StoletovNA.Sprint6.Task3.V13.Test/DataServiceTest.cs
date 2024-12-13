using Tyuiu.StoletovNA.Sprint6.Task3.V13.Lib;
namespace Tyuiu.StoletovNA.Sprint6.Task3.V13.Test {
    [TestClass]
    public sealed class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[5, 5] { { -7, 34, -2, 25, 5},
                                      { -16, -12, 30, -3, 17},
                                      { 3, -15, 12, 5, -5},
                                      { 17, 22, -3, 32, -11},
                                      { 9, 28, 1, -9, -2} };

            var res = ds.Calculate(mtrx);
            int[,] wait = new int[5, 5] { { -7, -15, -2, 25, 5},
                                      { -16, -12, 30, -3, 17},
                                      { 3, 22, 12, 5, -5},
                                      { 17, 28, -3, 32, -11},
                                      { 9, 34, 1, -9, -2} }; ;

        }
    }
}
