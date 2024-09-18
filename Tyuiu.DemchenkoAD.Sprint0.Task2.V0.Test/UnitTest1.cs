using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DemchenkoAD.Sprint0.Task2.V0.Lib;

namespace Tyuiu.DemchenkoAD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckMessageVaid()
        {
            var name = "Cаша";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Cаша", res);
        }
    }
}
