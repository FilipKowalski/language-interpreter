using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterpretScript;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            String input = "int p = 2; if(p == 2){p = 4}";
            int p = 2;
            if (p == 2)
                {
                    p = 4;
                }

            // assert
            //int actual = Interpreter(input);
            //Assert.AreEqual(expected, actual, "Wrong interpreter response");
        }
    }
}
