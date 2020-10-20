using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary.InterfaceModel;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdditionTest()
        {
            //Arrange
            string number1 = "200";
            string number2 = "100";
            var expected = "300";
            ArithmenticOperation addValues = new ArithmenticOperation();

            //Act
            var actual = addValues.Addition(number1, number2);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void SubtractionTest()
        {

            //Arrange
            string number1 = "500";
            string number2 = "100";
            var expected = "400";
            ArithmenticOperation addValues = new ArithmenticOperation();

            //Act
            var actual = addValues.Subtraction(number1, number2);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void DivisionTest()
        {

            //Arrange
            string number1 = "500";
            string number2 = "200";
            var expected = "2.5";
            ArithmenticOperation addValues = new ArithmenticOperation();

            //Act
            var actual = addValues.Division(number1, number2);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void DivideByZero()
        {

            //Arrange
            string number1 = "80";
            string number2 = "0";
            
            ArithmenticOperation addValues = new ArithmenticOperation();

            //Act and Assert
            Assert.ThrowsException<DivideByZeroException>(
                    () => addValues.Division(number1, number2)
                );

        }

        [TestMethod]
        public void MultiplicationTest()
        {

            //Arrange
            string number1 = "30";
            string number2 = "5";
            var expected = "150";
            ArithmenticOperation addValues = new ArithmenticOperation();

            //Act
            var actual = addValues.Multiplication(number1, number2);

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void NegatorTest()
        {

            //Arrange
            string value = "39";
            string expected = "-39";
            UnitaryOperation theValue = new UnitaryOperation();

            //Act
            var actual = theValue.Negator(value);
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void SquareTest()
        {
            //Arrange
            string value = "5";
            string expected = "25";
            UnitaryOperation theValue = new UnitaryOperation();

            //Act
            var actual = theValue.Square(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void SquareRootTest()
        {

            //Arrange
            string value = "25";
            string expected = "5";
            UnitaryOperation theValue = new UnitaryOperation();

            //Act
            var actual = theValue.SquareRoot(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void PercentageTest()
        {

            //Arrange
            string value = "25";
            string expected = "0.25";
            UnitaryOperation theValue = new UnitaryOperation();

            //Act
            var actual = theValue.Percent(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
