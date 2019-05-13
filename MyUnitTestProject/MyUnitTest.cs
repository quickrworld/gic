using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyUnitTestProject
{
    [TestClass]
    public class MyUnitTest
    {
        [TestMethod]
        public void MyTestMethod()
        {
            string result = Greet.sayHello("Trump");
            Assert.AreEqual("Hello, Trump", result);
        }

        [TestMethod]
        public void MyTestMethod2()
        {
            string result = Greet.sayHello("");
            Assert.AreEqual("Hello, World", result);
        }
    }
}
