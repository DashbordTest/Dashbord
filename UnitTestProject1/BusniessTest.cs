using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Business;

namespace UnitTestProject1
{
    /// <summary>
    /// BusinessTest 的摘要说明
    /// </summary>
    [TestClass]
    public class BusinessTest
    {
        public BusinessTest()
        {
            //
            //TODO:  在此处添加构造函数逻辑
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性: 
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void testAdd()
        {
            //int num1 = 0;
            //int num2 = 0;
            //try
            //{
            //    String filename = "C:/Users/yaxiaoyi/Desktop/dashboard1/test.txt";
            //    List<String[]> list = CsvStreamReader.ReadCSV(filename);
            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        String[] element = list[i];
            //        num1 = int.Parse(element[0]);
            //        num2 = int.Parse(element[1]);
            //        int value = Test.add(num1, num2);
            //    }
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine("路径名为空！");
            //}
            //catch (FileNotFoundException e)
            //{
            //    Console.WriteLine("文件不存在");
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("Exception caught: {0}", e);
            //}
        }
    }
}
