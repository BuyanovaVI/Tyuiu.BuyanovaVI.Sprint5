using Tyuiu.BuyanovaVI.Sprint5.Task2.V20.Lib;

namespace Tyuiu.BuyanovaVI.Sprint5.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(fileExists, wait);

        }
    }
}