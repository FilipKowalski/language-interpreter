using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterpretScript;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIfStatement()
        {
            // arrange
            //String input = "int p = 2; if(p == 2){p = 4}";
            int p = 2;
            if (p == 2)
                {
                    p = 4;
                }

            // assert
            //int actual = Interpreter(input);
            //Assert.AreEqual(expected, actual, "Wrong interpreter response");
        }

        [TestMethod]
        public void TestBoolValues()
        {
            String expected = "false;";
            bool a = false;

            Assert.AreEqual(expected, a);
        }

        [TestMethod]
        public void TestForLoop()
        {
            String expected = "3";
            int a = 0;
            for (int i = 0; i < 3; i++)
            {
                a++;
            }
            Assert.AreEqual(expected, a);
        }
    }
}
