using System;
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
            Car c = new Car();

            //Act
            decimal actual = c.Price();
            //Assert
            Assert.AreEqual(240, actual);
        }
        [TestMethod]
        public void MCTest()
        {

            //Arrange
           MC mc =new MC();

            //Act
            decimal actual = mc.Price();
            //Assert
            Assert.AreEqual(125, actual);
        }
    }

   
}
