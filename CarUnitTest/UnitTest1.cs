using System;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CarTest()
        {

            //Arrange
            Car cr = new Car();

            //Act
            double actual;
            actual = cr.Price();
            //Assert
            Assert.AreEqual(240, actual);
        }
        [TestMethod]
        public void MCTest()
        {

            //Arrange
            MC mc = new MC();

            //Act
            double actual = mc.Price();
            //Assert
            Assert.AreEqual(125, actual);
        }
    }


}
