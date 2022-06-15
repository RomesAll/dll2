using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DllMarkirovka;
namespace DllMarkirovkaTestMethod
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodEnterDateFalse()
        {
            Class1 class1 = new Class1();
            int actual = class1.GetYear("99999999FFF101");
            Assert.AreEqual(0,actual);
        }
        [TestMethod]
        public void TestMethodEnterDateTrue()
        {
            Class1 class1 = new Class1();
            int actual = class1.GetYear("02122022FFF101");
            Assert.AreEqual(02122022, actual);
        }
    }
}
