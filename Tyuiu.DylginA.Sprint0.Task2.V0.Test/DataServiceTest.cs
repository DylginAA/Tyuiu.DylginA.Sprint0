using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DylginA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.DylginA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Anton";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Anton", res);
        }
    }
}
