using Tyuiu.MironenkoSE.Sprint7.Project.V11.Lib;

namespace Tyuiu.MironenkoSE.Sprint7.Project.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\664\source\repos\Tyuiu.MironenkoSE.Sprint6\InPutDataFileSprint7Task7V11.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.AreEqual(true, fileExist);
        }
    }
}