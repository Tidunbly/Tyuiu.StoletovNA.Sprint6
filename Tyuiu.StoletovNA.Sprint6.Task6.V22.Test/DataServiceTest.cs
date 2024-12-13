using Tyuiu.StoletovNA.Sprint6.Task6.V22.Lib;
namespace Tyuiu.StoletovNA.Sprint6.Task6.V22.Test {
    [TestClass]
    public sealed class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask6V22.txt";
            DataService ds = new DataService();
            var res = ds.CollectTextFromFile(path);
            string wait = "MLgyapd kEPQzl IOuDWll TMRyztkPxzEVkcarVMlQ unwTmf";
            Assert.AreEqual(wait, res);
        }
    }
}
