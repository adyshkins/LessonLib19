using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using MathLibrary19;

namespace UnitTestProject19
{
    [TestClass]
    public class GeometryClassUnitTest
    {
        [TestMethod]
        public void SRectangleTesta4b5s20()
        {
            //Arrange
            double a = 4;
            double b = 5;
            double s = 20;

            //Act
            double res = GeometryClass.SRectangle(a, b);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void SRectangleTesta3b8s24()
        {
            //Arrange
            double a = 3;
            double b = 8;
            double s = 24;

            //Act
            double res = GeometryClass.SRectangle(a, b);

            //Assert
            Assert.AreEqual(s, res);
        }

        [TestMethod]
        public void SRectangleTesta3b9s27()
        {
            //Arrange
            double a = 3;
            double b = 9;
            double s = 27;

            //Act
            double res = GeometryClass.SRectangle(a, b);

            //Assert
            Assert.AreEqual(s, res);
        }

    }
}
