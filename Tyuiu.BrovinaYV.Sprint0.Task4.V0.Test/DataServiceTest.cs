using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinaYV.Sprint0.Task4.V0.Lib;

namespace Tyuiu.BrovinaYV.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionalVelid()
        {
            Assert.AreEqual(10, DataService.Additional(5, 5));
        }

        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        public void CheckedMultiplicationValod()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
        public void CheckedDivisionValod()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }

    }
}
