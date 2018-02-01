using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C_LogicaNegocio;

namespace UnitTest
{
    [TestClass]
    public class UnitTestBuscar
    {
        [TestMethod]
        public void PruebaBuscar1()
        {
            //Arrange
            ReglasMissingNumbers reglasMissingNumbers = new ReglasMissingNumbers
            {
                cantA = 10,
                cantB = 13,
                cadenaA = "203 204 205 206 207 208 203 204 205 206",
                cadenaB = "203 204 204 205 206 207 205 208 203 206 205 206 204"
            };

            //Act
            string result = reglasMissingNumbers.Buscar();

            //Assert
            Assert.AreEqual(result, "204 205 206");
        }

        [TestMethod]
        public void PruebaBuscar2()
        {
            //Arrange
            ReglasMissingNumbers reglasMissingNumbers = new ReglasMissingNumbers
            {
                cantA = 13,
                cantB = 13,
                cadenaA = "203 204 205 206 207 208 203 204 205 206 204 205 206",
                cadenaB = "203 204 204 205 206 207 205 208 203 206 205 206 204"
            };

            //Act
            string result = reglasMissingNumbers.Buscar();

            //Assert
            Assert.AreEqual(result, "");
        }

        [TestMethod]
        public void PruebaBuscar3()
        {
            //Arrange
            ReglasMissingNumbers reglasMissingNumbers = new ReglasMissingNumbers
            {
                cantA = 10,
                cantB = 15,
                cadenaA = "203 204 205 206 207 208 203 204 205 206",
                cadenaB = "203 204 204 205 206 207 205 208 203 206 205 206 204 209 210"
            };

            //Act
            string result = reglasMissingNumbers.Buscar();

            //Assert
            Assert.AreEqual(result, "204 205 206 209 210");
        }

        [TestMethod]
        public void PruebaBuscar4()
        {
            //Arrange
            ReglasMissingNumbers reglasMissingNumbers = new ReglasMissingNumbers
            {
                cantA = 4,
                cantB = 10,
                cadenaA = "1 9 5 3",
                cadenaB = "2 9 10 5 3 8 5 6 4 1"
            };

            //Act
            string result = reglasMissingNumbers.Buscar();

            //Assert
            Assert.AreEqual(result, "2 4 5 6 8 10");
        }

        [TestMethod]
        public void PruebaBuscar5()
        {
            //Arrange
            ReglasMissingNumbers reglasMissingNumbers = new ReglasMissingNumbers
            {
                cantA = 10,
                cantB = 12,
                cadenaA = "1 7 1 9 7 3 1 3 3 9",
                cadenaB = "3 9 1 9 3 9 7 9 7 1 1 3"
            };

            //Act
            string result = reglasMissingNumbers.Buscar();

            //Assert
            Assert.AreEqual(result, "9");
        }


        [TestMethod]
        public void PruebaBuscar6()
        {
            //Arrange
            ReglasMissingNumbers reglasMissingNumbers = new ReglasMissingNumbers
            {
                cantA = 9,
                cantB = 13,
                cadenaA = "140 100 150 100 170 100 130 190 120",
                cadenaB = "130 100 120 140 190 100 100 170 100 150 100 100 140"
            };

            //Act
            string result = reglasMissingNumbers.Buscar();

            //Assert
            Assert.AreEqual(result, "100 140");
        }

        [TestMethod]
        public void PruebaBuscar7()
        {
            //Arrange
            ReglasMissingNumbers reglasMissingNumbers = new ReglasMissingNumbers
            {
                cantA = 20,
                cantB = 22,
                cadenaA = "140 100 150 100 170 160 100 130 190 120 150 140 190 100 130 180 100 100 140 140",
                cadenaB = "160 130 100 120 130 180 140 190 100 100 130 100 190 140 170 100 150 100 100 140 150 140"
            };

            //Act
            string result = reglasMissingNumbers.Buscar();

            //Assert
            Assert.AreEqual(result, "100 130");
        }


    }
}
