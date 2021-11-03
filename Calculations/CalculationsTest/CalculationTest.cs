using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculationsTest
{
    public class CalculationTest
    {
        [Fact]
        public void Sum_TwoDouble_ReturnDouble()
        {
            // Arrange
            var num1 = 2.9;
            var num2 = 3.1;
            var expectedValue = 6;

            // Act
            var sum = Calculations.Calculation.Addition(num1, num2);

            // Assert
            Assert.Equal(expectedValue, sum);
        }

        [Fact]
        public void Sum_TwoInt_ReturnInt()
        {
            // Arrange
            var num1 = 2;
            var num2 = 3;
            var expectedValue = 5;

            // Act
            var sum = Calculations.Calculation.Addition(num1, num2);

            // Assert
            Assert.Equal(expectedValue, sum);
        }

        [Fact]
        public void Subtract_TwoDouble_ReturnDouble()
        {
            // Arrange
            var num1 = 5.5;
            var num2 = 3.3;
            var expectedValue = 2.2;

            // Act
            var sum = Calculations.Calculation.Subtraction(num1, num2);

            // Assert
            Assert.Equal(expectedValue, sum);
        }

        [Fact]
        public void Subtract_TwoInt_ReturnInt()
        {
            // Arrange
            var num1 = 3;
            var num2 = 3;
            var expectedValue = 0;

            // Act
            var sum = Calculations.Calculation.Subtraction(num1, num2);

            // Assert
            Assert.Equal(expectedValue, sum);
        }

        [Fact]
        public void Multiply_TwoDouble_ReturnDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 8.99;
            // Act  
            var mult = Calculations.Calculation.Multiplication(num1, num2);
            //Assert  
            Assert.Equal(valorEsperado, mult, 2);
        }
        [Fact]
        public void Divide_TwoDouble_ReturnDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 0.94; //Rounded value  
            // Act  
            var div = Calculations.Calculation.Division(num1, num2);
            //Assert  
            Assert.Equal(valorEsperado, div, 2);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        [InlineData(int.MinValue, +1, int.MinValue +1)]
        public void Sum_TwoRelativeNumbers_ReturnRelativeNumber(int num1, int num2, int expectedValue)
        {
            //Act
            var result = Calculations.Calculation.Addition(num1, num2);
            //Assert
            Assert.Equal(expectedValue, result);
        }
    }
}
