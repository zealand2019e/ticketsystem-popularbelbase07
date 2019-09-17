using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarUnitTest
{
    [TestClass]
    public class UnitTest1
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
    }
}
